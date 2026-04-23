<script setup lang="ts">
import { ref, computed } from 'vue'
import { usePacketStore } from '../stores/packetStore'
import { buildExportUrl } from '../api/client'

interface Props {
  visible: boolean
}
defineProps<Props>()
const emit = defineEmits<{ (e: 'update:visible', val: boolean): void }>()

const store = usePacketStore()
const scope = ref<'all' | 'filtered' | 'selected'>('filtered')
const includeShifted = ref(false)

const selectedCount = computed(() => store.selectedIds.size)
const allCount = computed(() => store.logStatus?.total ?? 0)
const filteredCount = computed(() => store.total)

function download() {
  const url = buildExportUrl({
    scope: scope.value,
    includeShifted: includeShifted.value,
    selectedIds: scope.value === 'selected' ? [...store.selectedIds] : undefined,
    packetName: store.filter.packetName,
    cmdId: store.filter.cmdId,
    startTime: store.filter.startTime,
    endTime: store.filter.endTime
  })
  const a = document.createElement('a')
  a.href = url
  a.download = 'export.packet.log'
  document.body.appendChild(a)
  a.click()
  document.body.removeChild(a)
  emit('update:visible', false)
}
</script>

<template>
  <el-dialog
    :model-value="visible"
    @update:model-value="(v: boolean) => emit('update:visible', v)"
    title="导出数据"
    width="460px"
  >
    <p class="text-xs text-zinc-400 mb-4 -mt-1">导出 JSON 解码数据（.packet.log 格式）</p>

    <el-form label-width="auto">
      <el-form-item label="导出范围">
        <el-radio-group v-model="scope">
          <el-radio value="all">
            全部
            <span class="text-zinc-400 text-xs ml-1">({{ allCount.toLocaleString() }} 条)</span>
          </el-radio>
          <el-radio value="filtered">
            当前筛选
            <span class="text-zinc-400 text-xs ml-1">({{ filteredCount.toLocaleString() }} 条)</span>
          </el-radio>
          <el-radio value="selected" :disabled="selectedCount === 0">
            已选中
            <span class="text-zinc-400 text-xs ml-1">({{ selectedCount }} 条)</span>
          </el-radio>
        </el-radio-group>
      </el-form-item>
      <el-form-item label="包含 Protoshift 转换后数据">
        <el-switch v-model="includeShifted" />
      </el-form-item>
    </el-form>

    <template #footer>
      <el-button @click="emit('update:visible', false)">取消</el-button>
      <el-button type="primary" @click="download">下载</el-button>
    </template>
  </el-dialog>
</template>
