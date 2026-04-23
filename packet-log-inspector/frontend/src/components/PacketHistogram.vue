<script setup lang="ts">
import { ref, computed, watch, onMounted } from 'vue'
import { usePacketStore } from '../stores/packetStore'
import { getHistogram } from '../api/client'
import type { HistogramBucket } from '../types'

const store = usePacketStore()

const buckets = ref<HistogramBucket[]>([])
const loading = ref(false)
const hoveredIdx = ref(-1)
const BUCKET_COUNT = 60

const maxCount = computed(() => Math.max(...buckets.value.map(b => b.count), 1))
const totalShown = computed(() => buckets.value.reduce((s, b) => s + b.count, 0))

async function fetchHistogram() {
  if (!store.hasFile) return
  loading.value = true
  try {
    const data = await getHistogram(BUCKET_COUNT)
    buckets.value = data.buckets
  } catch {
    buckets.value = []
  } finally {
    loading.value = false
  }
}

onMounted(fetchHistogram)
watch(() => store.total, fetchHistogram)

function barHeight(count: number): number {
  if (maxCount.value === 0) return 0
  return Math.max((count / maxCount.value) * 100, count > 0 ? 4 : 0)
}

function selectBucket(b: HistogramBucket) {
  store.applyFilter({ ...store.filter, startTime: b.startTime, endTime: b.endTime })
}

function formatBucketTime(iso: string): string {
  const d = new Date(iso)
  return d.toLocaleTimeString('zh-CN', { hour: '2-digit', minute: '2-digit', second: '2-digit' })
}

// X-axis label indices: show ~5 labels evenly spaced
const labelIndices = computed<number[]>(() => {
  const n = buckets.value.length
  if (n === 0) return []
  const step = Math.max(1, Math.floor(n / 5))
  const res: number[] = []
  for (let i = 0; i < n; i += step) res.push(i)
  return res
})

const isFilteredBucket = (b: HistogramBucket): boolean => {
  const start = store.filter.startTime
  const end = store.filter.endTime
  if (!start || !end) return false
  const bs = new Date(b.startTime).getTime()
  const be = new Date(b.endTime).getTime()
  const fs = new Date(start).getTime()
  const fe = new Date(end).getTime()
  return bs >= fs && be <= fe
}
</script>

<template>
  <div class="bg-zinc-900 border border-zinc-800 rounded-lg px-4 pt-3 pb-1 select-none">
    <!-- Header row -->
    <div class="flex items-center justify-between mb-2">
      <div class="flex items-center gap-3">
        <span class="text-xs font-semibold text-zinc-400 uppercase tracking-wider">Packets</span>
        <span class="text-xs text-zinc-500">
          <span class="text-zinc-200 font-medium">{{ totalShown.toLocaleString() }}</span>
          &nbsp;Total
        </span>
      </div>
      <button
        v-if="store.filter.startTime || store.filter.endTime"
        class="text-xs text-blue-400 hover:text-blue-300 transition-colors"
        @click="store.applyFilter({ ...store.filter, startTime: undefined, endTime: undefined })"
      >
        清除时间筛选 ✕
      </button>
    </div>

    <!-- Chart area -->
    <div class="relative h-20" v-if="buckets.length > 0">
      <!-- Bars -->
      <div class="flex items-end gap-px h-full pb-4">
        <div
          v-for="(b, i) in buckets"
          :key="i"
          class="flex-1 flex flex-col items-center justify-end h-full cursor-pointer group relative"
          @click="selectBucket(b)"
          @mouseenter="hoveredIdx = i"
          @mouseleave="hoveredIdx = -1"
        >
          <!-- Bar -->
          <div
            class="w-full rounded-sm transition-all duration-75"
            :class="[
              isFilteredBucket(b) ? 'bg-blue-400' : 'bg-blue-600',
              hoveredIdx === i ? '!bg-blue-400 opacity-100' : 'opacity-80'
            ]"
            :style="{ height: barHeight(b.count) + '%' }"
          />
          <!-- Tooltip -->
          <div
            v-if="hoveredIdx === i && b.count > 0"
            class="absolute bottom-full mb-1 left-1/2 -translate-x-1/2 z-20 pointer-events-none whitespace-nowrap"
          >
            <div class="bg-zinc-800 border border-zinc-600 rounded px-2 py-1 text-xs text-zinc-100 shadow-xl">
              <div class="font-semibold text-blue-300">{{ b.count }} packets</div>
              <div class="text-zinc-400">{{ formatBucketTime(b.startTime) }} – {{ formatBucketTime(b.endTime) }}</div>
            </div>
          </div>
        </div>
      </div>

      <!-- X-axis labels -->
      <div class="absolute bottom-0 left-0 right-0 h-4 flex">
        <div
          v-for="(li, n) in labelIndices"
          :key="n"
          class="absolute text-[10px] text-zinc-600"
          :style="{ left: ((li / buckets.length) * 100) + '%' }"
        >
          {{ formatBucketTime(buckets[li].startTime) }}
        </div>
      </div>
    </div>

    <!-- Empty state -->
    <div v-else-if="loading" class="h-20 flex items-center justify-center">
      <span class="text-xs text-zinc-600">加载中...</span>
    </div>
    <div v-else class="h-20 flex items-center justify-center">
      <span class="text-xs text-zinc-600">暂无数据</span>
    </div>
  </div>
</template>
