import { defineStore } from 'pinia'
import { ref, computed } from 'vue'
import * as api from '../api/client'
import type { PacketSummary, FilterParams, LogStatus } from '../types'

export const usePacketStore = defineStore('packets', () => {
  const records = ref<PacketSummary[]>([])
  const total = ref(0)
  const page = ref(1)
  const pageSize = ref(50)
  const selectedIds = ref<Set<number>>(new Set())
  const filter = ref<FilterParams>({})
  const logStatus = ref<LogStatus | null>(null)
  const loading = ref(false)

  const logTimeRange = computed(() => ({
    earliest: logStatus.value?.earliest ?? null,
    latest: logStatus.value?.latest ?? null
  }))

  const hasFile = computed(() => !!logStatus.value?.filePath)

  async function fetchStatus(): Promise<LogStatus> {
    const status = await api.getStatus()
    logStatus.value = status
    return status
  }

  async function fetchPackets() {
    if (!logStatus.value?.filePath) return
    loading.value = true
    try {
      const result = await api.getPackets({
        ...filter.value,
        page: page.value,
        pageSize: pageSize.value
      })
      records.value = result.items
      total.value = result.total
    } finally {
      loading.value = false
    }
  }

  async function applyFilter(newFilter: FilterParams) {
    filter.value = newFilter
    page.value = 1
    await fetchPackets()
  }

  /**
   * Apply a preset time range relative to the latest packet time in the log.
   * @param presetMinutes minutes to go back from latest time, or null for "All"
   */
  function applyPreset(presetMinutes: number | null) {
    const latest = logTimeRange.value.latest
    if (!latest) return

    if (presetMinutes === null) {
      filter.value = { ...filter.value, startTime: undefined, endTime: undefined }
    } else {
      const endDate = new Date(latest)
      const startDate = new Date(endDate.getTime() - presetMinutes * 60 * 1000)
      filter.value = {
        ...filter.value,
        startTime: startDate.toISOString(),
        endTime: latest
      }
    }
    page.value = 1
    fetchPackets()
  }

  function setPage(newPage: number) {
    page.value = newPage
    fetchPackets()
  }

  function toggleSelect(id: number) {
    const s = new Set(selectedIds.value)
    if (s.has(id)) s.delete(id)
    else s.add(id)
    selectedIds.value = s
  }

  function setSelectedIds(ids: number[]) {
    selectedIds.value = new Set(ids)
  }

  async function onNewRecords(_count: number) {
    // Refresh status (updates total / latestTime) then re-fetch current page
    await fetchStatus()
    await fetchPackets()
  }

  return {
    records, total, page, pageSize, filter, logStatus, loading,
    selectedIds, logTimeRange, hasFile,
    fetchStatus, fetchPackets, applyFilter, applyPreset,
    setPage, toggleSelect, setSelectedIds, onNewRecords
  }
})
