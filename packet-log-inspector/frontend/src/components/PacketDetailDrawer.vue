<script setup lang="ts">
import { ref, watch, onMounted } from 'vue'
import { useRouter } from 'vue-router'
import { getPacketDetail } from '../api/client'
import MonacoJsonViewer from './MonacoJsonViewer.vue'
import type { PacketDetail } from '../types'

interface Props {
  visible: boolean
  packetId: number
}
const props = defineProps<Props>()
const emit = defineEmits<{ (e: 'update:visible', val: boolean): void }>()

const router = useRouter()
const detail = ref<PacketDetail | null>(null)
const loading = ref(false)

async function loadDetail(id: number) {
  loading.value = true
  detail.value = null
  try {
    detail.value = await getPacketDetail(id)
  } finally {
    loading.value = false
  }
}

watch(() => props.packetId, (id) => {
  if (id !== null) loadDetail(id)
}, { immediate: true })

function formatTime(iso: string) {
  const d = new Date(iso)
  const base = d.toLocaleString('zh-CN', {
    year: 'numeric', month: '2-digit', day: '2-digit',
    hour: '2-digit', minute: '2-digit', second: '2-digit'
  })
  const ms = d.getMilliseconds().toString().padStart(3, '0')
  return `${base}.${ms}`
}

function goToDiff() {
  if (detail.value) {
    emit('update:visible', false)
    router.push(`/diff/${detail.value.id}`)
  }
}
</script>

<template>
  <el-drawer
    :model-value="visible"
    @update:model-value="(v: boolean) => emit('update:visible', v)"
    direction="rtl"
    size="50%"
    :title="detail?.packetName ?? '数据包详情'"
  >
    <div v-if="loading" class="loading-center">
      <el-icon class="is-loading"><i-ep-loading /></el-icon>
    </div>
    <template v-else-if="detail">
      <el-descriptions :column="2" border size="small" style="margin-bottom: 16px">
        <el-descriptions-item label="UID">{{ detail.uid }}</el-descriptions-item>
        <el-descriptions-item label="CmdId">{{ detail.cmdId }}</el-descriptions-item>
        <el-descriptions-item label="时间" :span="2">
          {{ formatTime(detail.packetTime) }}
        </el-descriptions-item>
        <el-descriptions-item label="PacketName" :span="2">{{ detail.packetName }}</el-descriptions-item>
        <el-descriptions-item label="方向">
          <el-tag :type="detail.sentByClient ? 'primary' : 'success'" size="small">
            {{ detail.sentByClient ? 'Client ↑' : 'Server ↓' }}
          </el-tag>
        </el-descriptions-item>
        <el-descriptions-item label="处理时间 (ns)">{{ detail.handleIntervalNanoseconds }}</el-descriptions-item>
      </el-descriptions>

      <div class="json-section">
        <div class="section-header">
          <span>Body (反序列化)</span>
          <el-button
            size="small"
            type="primary"
            :disabled="!detail.hasShiftedData"
            @click="goToDiff"
          >
            查看 Diff
          </el-button>
        </div>
        <div class="json-viewer-wrapper">
          <MonacoJsonViewer :value="detail.bodyJson" />
        </div>
      </div>
    </template>
  </el-drawer>
</template>

<style scoped>
.loading-center {
  display: flex;
  justify-content: center;
  padding: 40px;
}
.json-section {
  display: flex;
  flex-direction: column;
  flex: 1;
  min-height: 0;
  height: calc(100vh - 320px);
}
.section-header {
  display: flex;
  justify-content: space-between;
  align-items: center;
  font-size: 13px;
  font-weight: 600;
  color: #c0c0d0;
  margin-bottom: 8px;
}
.json-viewer-wrapper {
  flex: 1;
  min-height: 0;
}
</style>
