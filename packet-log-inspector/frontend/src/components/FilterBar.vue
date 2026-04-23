<script setup lang="ts">
import { ref, computed } from 'vue'
import { usePacketStore } from '../stores/packetStore'
import type { FilterParams } from '../types'
import TimeRangePicker from './TimeRangePicker.vue'

const store = usePacketStore()
const localName = ref(store.filter.packetName ?? '')
const localCmdId = ref<number | undefined>(store.filter.cmdId)
const localStart = ref<string | undefined>(store.filter.startTime)
const localEnd = ref<string | undefined>(store.filter.endTime)

function onTimeRangeChange(start: string | undefined, end: string | undefined) {
  localStart.value = start
  localEnd.value = end
}

function doFilter() {
  const f: FilterParams = {}
  if (localName.value.trim()) f.packetName = localName.value.trim()
  if (localCmdId.value !== undefined) f.cmdId = localCmdId.value
  if (localStart.value) f.startTime = localStart.value
  if (localEnd.value) f.endTime = localEnd.value
  store.applyFilter(f)
}

function doClear() {
  localName.value = ''
  localCmdId.value = undefined
  localStart.value = undefined
  localEnd.value = undefined
  store.applyFilter({})
}
</script>

<template>
  <div class="flex items-center gap-2 flex-wrap py-2">
    <TimeRangePicker
      :start="localStart"
      :end="localEnd"
      @change="onTimeRangeChange"
    />

    <el-input
      v-model="localName"
      placeholder="PacketName"
      clearable
      style="width: 200px"
      @keyup.enter="doFilter"
    />

    <el-input-number
      v-model="localCmdId"
      :min="0"
      :controls="false"
      placeholder="CmdId"
      style="width: 100px"
    />

    <el-button type="primary" @click="doFilter">筛选</el-button>
    <el-button @click="doClear">清空</el-button>
  </div>
</template>
