<script setup lang="ts">
import { ref, computed } from 'vue'
import { usePacketStore } from '../stores/packetStore'

interface Props {
  start: string | undefined
  end: string | undefined
}
const props = defineProps<Props>()
const emit = defineEmits<{
  (e: 'change', start: string | undefined, end: string | undefined): void
}>()

const store = usePacketStore()
const visible = ref(false)

const customStart = ref<Date | null>(props.start ? new Date(props.start) : null)
const customEnd = ref<Date | null>(props.end ? new Date(props.end) : null)

const PRESETS = [
  { label: '最近 15 分钟', minutes: 15 },
  { label: '最近 1 小时', minutes: 60 },
  { label: '最近 12 小时', minutes: 720 },
  { label: '最近 24 小时', minutes: 1440 },
  { label: '最近 3 天', minutes: 4320 },
  { label: '最近 7 天', minutes: 10080 },
  { label: '全部', minutes: null }
] as const

const activePresetLabel = ref<string>('')

const rangeLabel = computed(() => {
  if (activePresetLabel.value) return activePresetLabel.value
  if (props.start && props.end) {
    const s = new Date(props.start).toLocaleString('zh-CN')
    const e = new Date(props.end).toLocaleString('zh-CN')
    return `${s} — ${e}`
  }
  if (!props.start && !props.end) return '全部时间'
  return '自定义范围'
})

function applyPreset(minutes: number | null, label: string) {
  activePresetLabel.value = label
  store.applyPreset(minutes)
  // also update local date pickers to reflect the computed range
  const latest = store.logTimeRange.latest
  if (latest && minutes !== null) {
    const end = new Date(latest)
    const start = new Date(end.getTime() - minutes * 60 * 1000)
    customStart.value = start
    customEnd.value = end
    emit('change', start.toISOString(), end.toISOString())
  } else {
    customStart.value = null
    customEnd.value = null
    emit('change', undefined, undefined)
  }
  visible.value = false
}

function applyCustom() {
  activePresetLabel.value = ''
  const s = customStart.value?.toISOString()
  const e = customEnd.value?.toISOString()
  emit('change', s, e)
  store.applyFilter({ ...store.filter, startTime: s, endTime: e })
  visible.value = false
}

function clearRange() {
  activePresetLabel.value = ''
  customStart.value = null
  customEnd.value = null
  emit('change', undefined, undefined)
  store.applyFilter({ ...store.filter, startTime: undefined, endTime: undefined })
  visible.value = false
}
</script>

<template>
  <el-popover v-model:visible="visible" trigger="click" :width="580" placement="bottom-start">
    <template #reference>
      <el-button>
        🕐 {{ rangeLabel }}
      </el-button>
    </template>

    <div class="flex gap-4 p-1">
      <!-- Left: Custom date range -->
      <div class="w-56 shrink-0">
        <p class="text-xs text-zinc-400 uppercase tracking-wider mb-2 font-medium">自定义范围</p>
        <el-date-picker
          v-model="customStart"
          type="datetime"
          placeholder="开始时间"
          format="YYYY-MM-DD HH:mm:ss"
          style="width: 100%; margin-bottom: 8px"
        />
        <el-date-picker
          v-model="customEnd"
          type="datetime"
          placeholder="结束时间"
          format="YYYY-MM-DD HH:mm:ss"
          style="width: 100%; margin-bottom: 10px"
        />
        <div class="flex gap-2">
          <el-button size="small" type="primary" @click="applyCustom">应用</el-button>
          <el-button size="small" @click="clearRange">清空</el-button>
        </div>
      </div>

      <!-- Divider -->
      <el-divider direction="vertical" style="height: auto" />

      <!-- Right: Presets -->
      <div class="flex-1">
        <p class="text-xs text-zinc-400 uppercase tracking-wider mb-2 font-medium">快速选择</p>
        <div
          v-for="preset in PRESETS"
          :key="preset.label"
          class="px-2 py-1.5 rounded cursor-pointer text-sm transition-colors"
          :class="activePresetLabel === preset.label
            ? 'bg-blue-500/20 text-blue-300 font-semibold'
            : 'text-zinc-300 hover:bg-zinc-700'"
          @click="applyPreset(preset.minutes, preset.label)"
        >
          {{ preset.label }}
        </div>
        <div class="mt-3 pt-3 border-t border-zinc-700 text-xs text-zinc-600">
          <span class="block text-zinc-500 mb-0.5">日志最新时间：</span>
          <span class="text-zinc-400 font-mono">{{ store.logTimeRange.latest ?? '—' }}</span>
        </div>
      </div>
    </div>
  </el-popover>
</template>
