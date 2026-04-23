<script setup lang="ts">
import { ref, computed, watch, nextTick } from 'vue'
import { listDirectory, getSuggestedDirs } from '../api/client'
import type { DirectoryListing, FsEntry } from '../types'

const props = defineProps<{ visible: boolean; initialDir?: string }>()
const emit = defineEmits<{
  (e: 'update:visible', v: boolean): void
  (e: 'select', path: string): void
}>()

const listing = ref<DirectoryListing | null>(null)
const loading = ref(false)
const selectedPath = ref<string | null>(null)
const errorMsg = ref('')
const errorParentPath = ref<string | null | undefined>(undefined) // undefined = no error; null = error at root

// Path edit mode
const editingPath = ref(false)
const pathInputValue = ref('')
const pathInputRef = ref<any>(null)

/**
 * Navigate to a directory. Returns true on success, false on failure.
 * @param silent - if true, do not update errorMsg/errorParentPath on failure
 *                 (used during fallback chain so intermediate errors aren't shown)
 */
async function navigate(path?: string, silent = false): Promise<boolean> {
  if (!silent) {
    errorMsg.value = ''
    errorParentPath.value = undefined
    selectedPath.value = null
  }
  loading.value = true
  try {
    listing.value = await listDirectory(path)
    errorMsg.value = ''
    errorParentPath.value = undefined
    if (!silent) selectedPath.value = null
    return true
  } catch (e: any) {
    if (!silent) {
      const data = e?.response?.data
      errorMsg.value = data?.error ?? String(e)
      // parentPath from server tells us where to go when the user clicks "go up"
      errorParentPath.value = data?.parentPath ?? null
    }
    return false
  } finally {
    loading.value = false
  }
}

/** On dialog open: try initialDir → root → home → appDir (silently), show last fallback result. */
async function openDialog() {
  errorMsg.value = ''
  errorParentPath.value = undefined
  selectedPath.value = null
  editingPath.value = false

  if (props.initialDir && await navigate(props.initialDir, true)) return
  if (await navigate(undefined, true)) return  // root — should always work

  try {
    const suggested = await getSuggestedDirs()
    if (suggested.home && await navigate(suggested.home, true)) return
    if (await navigate(suggested.appDir, true)) return
  } catch { /* couldn't fetch suggested dirs */ }

  // All fallbacks failed — try root one more time, this time NOT silent so the error is shown
  await navigate(undefined, false)
}

watch(() => props.visible, (v) => { if (v) openDialog() })

function onEntryClick(entry: FsEntry) {
  if (entry.type === 'dir') navigate(entry.fullPath)
  else selectedPath.value = entry.fullPath
}

function onEntryDblClick(entry: FsEntry) {
  if (entry.type === 'dir') { navigate(entry.fullPath); return }
  selectedPath.value = entry.fullPath
  confirmSelect()
}

function goUp() {
  navigate(listing.value?.parentPath ?? undefined)
}

/** Navigate away from an error state — use parentPath provided by server, or root as last resort. */
function goUpFromError() {
  // errorParentPath === null → server said we're at root; undefined shouldn't reach here
  navigate(errorParentPath.value ?? undefined)
}

function confirmSelect() {
  if (!selectedPath.value) return
  emit('select', selectedPath.value)
  emit('update:visible', false)
}

async function startEditPath() {
  pathInputValue.value = listing.value?.currentPath ?? ''
  editingPath.value = true
  await nextTick()
  pathInputRef.value?.focus?.()
}

async function commitPathEdit() {
  const val = pathInputValue.value.trim()
  editingPath.value = false
  if (val) await navigate(val, false)
}

function cancelPathEdit() {
  editingPath.value = false
}

function formatSize(bytes?: number | null): string {
  if (!bytes) return ''
  if (bytes < 1024) return `${bytes} B`
  if (bytes < 1024 * 1024) return `${(bytes / 1024).toFixed(1)} KB`
  return `${(bytes / 1024 / 1024).toFixed(1)} MB`
}

const breadcrumbs = computed<{ label: string; path: string }[]>(() => {
  const p = listing.value?.currentPath
  if (!p) return []
  const sep = p.includes('\\') ? '\\' : '/'
  const parts = p.split(sep).filter(Boolean)
  const result: { label: string; path: string }[] = []
  let built = ''
  for (let i = 0; i < parts.length; i++) {
    if (i === 0 && p.startsWith('/')) {
      built = '/' + parts[0]
    } else if (i === 0) {
      built = parts[0] + sep
    } else {
      built = built.endsWith(sep) ? built + parts[i] : built + sep + parts[i]
    }
    result.push({ label: parts[i] || sep, path: built })
  }
  return result
})
</script>

<template>
  <el-dialog
    :model-value="visible"
    @update:model-value="emit('update:visible', $event)"
    title="浏览文件"
    width="640px"
    :close-on-click-modal="false"
  >
    <!-- Toolbar -->
    <div class="flex items-center gap-2 mb-3">
      <el-button size="small" :disabled="!!listing?.isRoot && !errorMsg" @click="goUp">
        ↑ 上级
      </el-button>

      <!-- Editable path input (edit mode) -->
      <el-input
        v-if="editingPath"
        ref="pathInputRef"
        v-model="pathInputValue"
        size="small"
        class="flex-1 font-mono text-xs"
        placeholder="输入目录路径，按 Enter 确认"
        @keyup.enter="commitPathEdit"
        @keyup.escape="cancelPathEdit"
        @blur="cancelPathEdit"
      />

      <!-- Breadcrumb bar (normal mode) — click to enter edit mode -->
      <div
        v-else
        class="flex items-center gap-0.5 flex-1 min-w-0 text-xs font-mono bg-zinc-900 border border-zinc-700 rounded px-2 py-1.5 overflow-hidden cursor-text select-none"
        title="点击可直接输入路径"
        @click="startEditPath"
      >
        <span v-if="!listing?.currentPath" class="text-zinc-500">根目录 / 驱动器列表</span>
        <template v-else>
          <button
            v-for="(crumb, i) in breadcrumbs"
            :key="i"
            class="flex items-center shrink-0"
            @click.stop="navigate(crumb.path)"
          >
            <span v-if="i > 0" class="text-zinc-600 mx-0.5 select-none">/</span>
            <span class="text-zinc-300 hover:text-blue-400 transition-colors">{{ crumb.label }}</span>
          </button>
        </template>
      </div>
    </div>

    <!-- Listing / error area -->
    <div
      class="h-72 overflow-y-auto border border-zinc-700 rounded bg-zinc-950"
      v-loading="loading"
    >
      <!-- Error state: show message + "go up" button -->
      <div
        v-if="errorMsg && !loading"
        class="flex flex-col items-center justify-center h-full gap-3 text-sm"
      >
        <p class="text-red-400 text-center px-4">⚠ {{ errorMsg }}</p>
        <el-button size="small" @click="goUpFromError">
          {{ errorParentPath ? '↑ 返回上级' : '返回根目录' }}
        </el-button>
      </div>

      <!-- Empty directory -->
      <div
        v-else-if="!loading && listing && listing.entries.length === 0"
        class="flex items-center justify-center h-full text-zinc-600 text-sm"
      >
        此目录为空
      </div>

      <!-- File/directory entries -->
      <div
        v-for="entry in listing?.entries ?? []"
        :key="entry.fullPath"
        class="flex items-center gap-2 px-3 py-2 cursor-pointer border-b border-zinc-800/60 last:border-0 transition-colors text-sm select-none"
        :class="[
          entry.type === 'file' && selectedPath === entry.fullPath
            ? 'bg-blue-600/25 text-zinc-100'
            : 'hover:bg-zinc-800 text-zinc-300'
        ]"
        @click="onEntryClick(entry)"
        @dblclick="onEntryDblClick(entry)"
      >
        <span class="shrink-0 text-base leading-none">{{ entry.type === 'dir' ? '📁' : '📄' }}</span>
        <span class="flex-1 truncate font-mono">{{ entry.name }}</span>
        <span v-if="entry.size" class="text-zinc-500 text-xs shrink-0">{{ formatSize(entry.size) }}</span>
      </div>
    </div>

    <template #footer>
      <div class="flex items-center justify-between w-full gap-4">
        <span class="text-xs text-zinc-500 font-mono truncate">
          {{ selectedPath ?? '未选择文件' }}
        </span>
        <div class="flex gap-2 shrink-0">
          <el-button @click="emit('update:visible', false)">取消</el-button>
          <el-button type="primary" :disabled="!selectedPath" @click="confirmSelect">确定</el-button>
        </div>
      </div>
    </template>
  </el-dialog>
</template>

