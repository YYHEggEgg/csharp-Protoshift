<script setup lang="ts">
import { ref, onMounted, onUnmounted } from 'vue'
import { usePacketStore } from '../stores/packetStore'
import type { PacketSummary } from '../types'

const emit = defineEmits<{
  (e: 'row-click', row: PacketSummary): void
}>()

const store = usePacketStore()

// ResizeObserver: pass an explicit pixel height to el-table so it creates its
// own scrollbar and the pagination below is always visible.
const containerRef = ref<HTMLElement | null>(null)
const tableHeight = ref(400)
let ro: ResizeObserver | null = null

onMounted(() => {
  ro = new ResizeObserver(() => {
    if (containerRef.value) {
      // 56 px = pagination row height
      tableHeight.value = Math.max(100, containerRef.value.clientHeight - 56)
    }
  })
  if (containerRef.value) ro.observe(containerRef.value)
})
onUnmounted(() => ro?.disconnect())

function handleSelectionChange(rows: PacketSummary[]) {
  store.setSelectedIds(rows.map(r => r.id))
}

function formatTime(iso: string) {
  const d = new Date(iso)
  const base = d.toLocaleString('zh-CN', {
    year: 'numeric', month: '2-digit', day: '2-digit',
    hour: '2-digit', minute: '2-digit', second: '2-digit'
  })
  const ms = d.getMilliseconds().toString().padStart(3, '0')
  return `${base}.${ms}`
}

function formatBytes(n: number): string {
  if (n === 0) return '—'
  if (n < 1024) return `${n} B`
  return `${(n / 1024).toFixed(1)} KB`
}

function handlePageChange(p: number) {
  store.setPage(p)
}

function handleSizeChange(sz: number) {
  store.pageSize = sz
  store.setPage(1)
}
</script>

<template>
  <div ref="containerRef" class="flex flex-col h-full">
    <el-table
      :data="store.records"
      v-loading="store.loading"
      stripe
      highlight-current-row
      style="width: 100%"
      :height="tableHeight"
      @selection-change="handleSelectionChange"
      @row-click="(row: PacketSummary) => emit('row-click', row)"
    >
      <el-table-column type="selection" width="44" />
      <el-table-column prop="packetTime" label="时间" width="210">
        <template #default="{ row }">
          <span class="text-zinc-300 font-mono text-xs">{{ formatTime(row.packetTime) }}</span>
        </template>
      </el-table-column>
      <el-table-column prop="packetName" label="PacketName" min-width="180">
        <template #default="{ row }">
          <span class="font-medium text-zinc-100">{{ row.packetName }}</span>
        </template>
      </el-table-column>
      <el-table-column prop="cmdId" label="CmdId" width="80">
        <template #default="{ row }">
          <span class="text-zinc-400 font-mono text-xs">{{ row.cmdId }}</span>
        </template>
      </el-table-column>
      <el-table-column label="方向" width="95">
        <template #default="{ row }">
          <el-tag :type="row.sentByClient ? 'primary' : 'success'" size="small">
            {{ row.sentByClient ? 'Client ↑' : 'Server ↓' }}
          </el-tag>
        </template>
      </el-table-column>
      <el-table-column label="Body" width="90" align="right">
        <template #default="{ row }">
          <span class="text-zinc-400 font-mono text-xs">{{ formatBytes(row.bodySize) }}</span>
        </template>
      </el-table-column>
      <el-table-column label="Shifted" width="90" align="right">
        <template #default="{ row }">
          <span class="text-zinc-400 font-mono text-xs">{{ row.hasShiftedData ? formatBytes(row.shiftedDataSize) : '—' }}</span>
        </template>
      </el-table-column>
      <el-table-column label="处理时间 (ns)" width="130" align="right">
        <template #default="{ row }">
          <span class="text-zinc-500 font-mono text-xs">{{ row.handleIntervalNanoseconds.toLocaleString() }}</span>
        </template>
      </el-table-column>
    </el-table>

    <div class="shrink-0 flex justify-end py-3 border-t border-zinc-800">
      <el-pagination
        v-model:current-page="store.page"
        v-model:page-size="store.pageSize"
        :total="store.total"
        :page-sizes="[20, 50, 100, 200]"
        layout="total, sizes, prev, pager, next, jumper"
        background
        @current-change="handlePageChange"
        @size-change="handleSizeChange"
      />
    </div>
  </div>
</template>
