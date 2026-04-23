<script setup lang="ts">
import { ref, computed, watch } from 'vue'
import { listDirectory } from '../api/client'
import type { DirectoryListing, FsEntry } from '../types'

const props = defineProps<{ visible: boolean }>()
const emit = defineEmits<{
  (e: 'update:visible', v: boolean): void
  (e: 'select', path: string): void
}>()

const listing = ref<DirectoryListing | null>(null)
const loading = ref(false)
const selectedPath = ref<string | null>(null)
const errorMsg = ref('')

async function navigate(path?: string) {
  loading.value = true
  errorMsg.value = ''
  selectedPath.value = null
  try {
    listing.value = await listDirectory(path)
  } catch (e: any) {
    errorMsg.value = e?.response?.data?.error ?? String(e)
  } finally {
    loading.value = false
  }
}

// Load root listing each time dialog opens
watch(() => props.visible, (v) => { if (v) navigate(undefined) })

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
  // parentPath=null can mean either "we are at fs root" or "drive root → back to drive list"
  navigate(listing.value?.parentPath ?? undefined)
}

function confirmSelect() {
  if (!selectedPath.value) return
  emit('select', selectedPath.value)
  emit('update:visible', false)
}

function formatSize(bytes?: number | null): string {
  if (!bytes) return ''
  if (bytes < 1024) return `${bytes} B`
  if (bytes < 1024 * 1024) return `${(bytes / 1024).toFixed(1)} KB`
  return `${(bytes / 1024 / 1024).toFixed(1)} MB`
}

// Build breadcrumbs from currentPath
const breadcrumbs = computed<{ label: string; path: string }[]>(() => {
  const p = listing.value?.currentPath
  if (!p) return []
  // Normalize separators for splitting
  const sep = p.includes('\\') ? '\\' : '/'
  const parts = p.split(sep).filter(Boolean)
  const result: { label: string; path: string }[] = []
  let built = p.startsWith('/') ? '' : ''
  for (let i = 0; i < parts.length; i++) {
    if (i === 0 && p.startsWith('/')) {
      built = '/' + parts[0]
    } else if (i === 0) {
      // Windows: "C:" → "C:\"
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
      <el-button size="small" :disabled="listing?.isRoot" @click="goUp">
        ↑ 上级
      </el-button>
      <!-- Breadcrumb / current path -->
      <div class="flex items-center gap-0.5 flex-1 min-w-0 text-xs font-mono bg-zinc-900 border border-zinc-700 rounded px-2 py-1.5 overflow-hidden">
        <span v-if="!listing?.currentPath" class="text-zinc-500">根目录 / 驱动器列表</span>
        <template v-else>
          <button
            v-for="(crumb, i) in breadcrumbs"
            :key="i"
            class="flex items-center shrink-0"
            @click="navigate(crumb.path)"
          >
            <span v-if="i > 0" class="text-zinc-600 mx-0.5 select-none">/</span>
            <span class="text-zinc-300 hover:text-blue-400 transition-colors">{{ crumb.label }}</span>
          </button>
        </template>
      </div>
    </div>

    <!-- Listing -->
    <div
      class="h-72 overflow-y-auto border border-zinc-700 rounded bg-zinc-950"
      v-loading="loading"
    >
      <div
        v-if="!loading && listing && listing.entries.length === 0"
        class="flex items-center justify-center h-full text-zinc-600 text-sm"
      >
        此目录为空
      </div>

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

    <p v-if="errorMsg" class="mt-2 text-red-400 text-xs">⚠ {{ errorMsg }}</p>

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
