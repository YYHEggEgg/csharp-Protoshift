<script setup lang="ts">
import { ref, computed } from 'vue'
import { useRouter } from 'vue-router'
import { usePacketStore } from '../stores/packetStore'
import { changeFile } from '../api/client'
import { ElMessage } from 'element-plus'
import FilterBar from '../components/FilterBar.vue'
import PacketTable from '../components/PacketTable.vue'
import PacketDetailDrawer from '../components/PacketDetailDrawer.vue'
import ExportDialog from '../components/ExportDialog.vue'
import PacketHistogram from '../components/PacketHistogram.vue'
import FileBrowserDialog from '../components/FileBrowserDialog.vue'
import type { PacketSummary } from '../types'

const router = useRouter()
const store = usePacketStore()

const selectedPacketId = ref<number | null>(null)
const drawerVisible = ref(false)
const exportDialogVisible = ref(false)

const changeFileDialogVisible = ref(false)
const changeBrowserVisible = ref(false)
const newFilePath = ref('')
const changeFileLoading = ref(false)

// Open file browser at the directory of the currently monitored file (if any)
const browserInitialDir = computed(() => {
  const p = store.logStatus?.filePath
  if (!p) return undefined
  const last = Math.max(p.lastIndexOf('/'), p.lastIndexOf('\\'))
  return last > 0 ? p.substring(0, last) : undefined
})

function onRowClick(row: PacketSummary) {
  selectedPacketId.value = row.id
  drawerVisible.value = true
}

async function doChangeFile() {
  if (!newFilePath.value.trim()) return
  changeFileLoading.value = true
  try {
    await changeFile(newFilePath.value.trim())
    await store.fetchStatus()
    await store.fetchPackets()
    changeFileDialogVisible.value = false
    ElMessage.success('文件切换成功')
  } catch (e: any) {
    ElMessage.error('切换失败：' + (e?.response?.data ?? String(e)))
  } finally {
    changeFileLoading.value = false
  }
}

function goWelcome() {
  router.push('/')
}
</script>

<template>
  <div class="flex flex-col h-screen bg-zinc-950 text-zinc-100 px-4 box-border">
    <!-- Toolbar -->
    <div class="flex items-center gap-3 py-2.5 border-b border-zinc-800 shrink-0">
      <span class="flex-1 text-xs text-zinc-500 truncate font-mono" :title="store.logStatus?.filePath ?? ''">
        {{ store.logStatus?.filePath ?? '未加载文件' }}
      </span>
      <span class="text-xs text-zinc-500 whitespace-nowrap shrink-0">
        共 <span class="text-zinc-200 font-medium">{{ store.total.toLocaleString() }}</span> 条
      </span>
      <div class="flex gap-2 shrink-0">
        <el-button size="small" @click="changeFileDialogVisible = true">更换文件</el-button>
        <el-button size="small" @click="goWelcome">首页</el-button>
        <el-button size="small" type="primary" @click="exportDialogVisible = true">导出</el-button>
      </div>
    </div>

    <!-- Histogram -->
    <div class="mt-2 shrink-0" v-if="store.hasFile">
      <PacketHistogram />
    </div>

    <!-- Filter Bar -->
    <FilterBar />

    <!-- Packet Table -->
    <div class="flex-1 min-h-0">
      <PacketTable @row-click="onRowClick" />
    </div>

    <!-- Packet Detail Drawer -->
    <PacketDetailDrawer
      v-if="selectedPacketId !== null"
      v-model:visible="drawerVisible"
      :packet-id="selectedPacketId"
    />

    <!-- Export Dialog -->
    <ExportDialog v-model:visible="exportDialogVisible" />

    <!-- Change File Dialog -->
    <el-dialog v-model="changeFileDialogVisible" title="更换文件" width="540px">
      <div class="flex gap-2 mb-2">
        <el-input
          v-model="newFilePath"
          placeholder="请输入新的 packet log 文件路径"
          clearable
          class="flex-1"
          @keyup.enter="doChangeFile"
        />
        <el-button @click="changeBrowserVisible = true">浏览...</el-button>
      </div>
      <FileBrowserDialog
        v-model:visible="changeBrowserVisible"
        :initial-dir="browserInitialDir"
        @select="newFilePath = $event"
      />
      <template #footer>
        <el-button @click="changeFileDialogVisible = false">取消</el-button>
        <el-button type="primary" :loading="changeFileLoading" @click="doChangeFile">确定</el-button>
      </template>
    </el-dialog>
  </div>
</template>
