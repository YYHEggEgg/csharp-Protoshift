<script setup lang="ts">
import { ref, computed } from 'vue'
import { useRouter } from 'vue-router'
import { changeFile } from '../api/client'
import { usePacketStore } from '../stores/packetStore'
import { ElMessage } from 'element-plus'
import FileBrowserDialog from '../components/FileBrowserDialog.vue'

const router = useRouter()
const store = usePacketStore()

const filePath = ref('')
const loading = ref(false)
const fileBrowserVisible = ref(false)
const errorMsg = ref('')

// Open file browser at the directory of the currently monitored file (if any)
const browserInitialDir = computed(() => {
  const p = store.logStatus?.filePath
  if (!p) return undefined
  const last = Math.max(p.lastIndexOf('/'), p.lastIndexOf('\\'))
  return last > 0 ? p.substring(0, last) : undefined
})

const RECENT_KEY = 'pli_recent_files'
function getRecentFiles(): string[] {
  try { return JSON.parse(localStorage.getItem(RECENT_KEY) ?? '[]') }
  catch { return [] }
}
function saveRecentFile(path: string) {
  const list = getRecentFiles().filter(p => p !== path)
  list.unshift(path)
  localStorage.setItem(RECENT_KEY, JSON.stringify(list.slice(0, 10)))
}

const recentFiles = ref<string[]>(getRecentFiles())

async function openFile(path: string) {
  if (!path.trim()) { errorMsg.value = '请输入或选择文件路径'; return }
  loading.value = true
  errorMsg.value = ''
  try {
    await changeFile(path.trim())
    saveRecentFile(path.trim())
    recentFiles.value = getRecentFiles()
    await store.fetchStatus()
    await store.fetchPackets()
    router.push('/home')
  } catch (e: any) {
    errorMsg.value = e?.response?.data?.error ?? e?.response?.data ?? String(e)
    ElMessage.error('打开失败：' + errorMsg.value)
  } finally {
    loading.value = false
  }
}

function onBrowse() {
  errorMsg.value = ''
  fileBrowserVisible.value = true
}
</script>

<template>
  <div class="min-h-screen bg-zinc-950 flex items-center justify-center p-6">
    <div class="w-full max-w-xl">
      <!-- Logo / Title -->
      <div class="mb-10 text-center">
        <div class="inline-flex items-center gap-3 mb-3">
          <div class="w-10 h-10 rounded-lg bg-blue-600 flex items-center justify-center text-white font-bold text-lg">P</div>
          <h1 class="text-2xl font-semibold text-zinc-100 tracking-tight">Packet Log Inspector</h1>
        </div>
        <p class="text-zinc-500 text-sm">csharp-Protoshift 协议包分析工具</p>
      </div>

      <!-- File open card -->
      <div class="bg-zinc-900 border border-zinc-800 rounded-xl p-6 shadow-2xl">
        <p class="text-sm text-zinc-400 mb-4">打开 packet log 文件</p>

        <!-- File browser dialog -->
        <FileBrowserDialog
          v-model:visible="fileBrowserVisible"
          :initial-dir="browserInitialDir"
          @select="path => { filePath = path; openFile(path) }"
        />

        <!-- Browse button (primary action) -->
        <el-button
          type="primary"
          size="large"
          :loading="loading"
          class="w-full !h-12 !text-base !mb-4"
          @click="onBrowse"
        >
          <span class="mr-2">📂</span>
          浏览并打开文件...
        </el-button>

        <!-- Manual path fallback -->
        <div class="flex gap-2">
          <el-input
            v-model="filePath"
            placeholder="或手动输入文件路径"
            clearable
            :disabled="loading"
            @keyup.enter="openFile(filePath)"
            class="flex-1"
          />
          <el-button :loading="loading" @click="openFile(filePath)">打开</el-button>
        </div>

        <p v-if="errorMsg" class="mt-3 text-red-400 text-sm bg-red-950/40 border border-red-900/50 rounded-md px-3 py-2">
          {{ errorMsg }}
        </p>
      </div>

      <!-- Recent files -->
      <div v-if="recentFiles.length" class="mt-4 bg-zinc-900 border border-zinc-800 rounded-xl overflow-hidden">
        <p class="px-4 pt-3 pb-2 text-xs text-zinc-500 uppercase tracking-wider font-medium border-b border-zinc-800">最近打开</p>
        <div class="max-h-52 overflow-y-auto">
          <button
            v-for="f in recentFiles"
            :key="f"
            class="w-full text-left px-4 py-2.5 text-sm text-zinc-300 hover:bg-zinc-800 hover:text-zinc-100 transition-colors truncate flex items-center gap-2 border-b border-zinc-800/50 last:border-0"
            :disabled="loading"
            @click="filePath = f; openFile(f)"
          >
            <span class="text-zinc-600 shrink-0 text-xs">📄</span>
            <span class="truncate">{{ f }}</span>
          </button>
        </div>
      </div>
    </div>
  </div>
</template>

