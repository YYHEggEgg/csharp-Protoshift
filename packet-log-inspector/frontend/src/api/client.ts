import axios from 'axios'
import * as signalR from '@microsoft/signalr'
import type { PacketSummary, PacketDetail, DiffResult, LogStatus, PagedResult, FilterParams, HistogramData, DirectoryListing } from '../types'

const api = axios.create({
  baseURL: '/api',
  headers: { 'Content-Type': 'application/json' }
})

export async function getStatus(): Promise<LogStatus> {
  return api.get<LogStatus>('/status').then(r => r.data)
}

export async function getPackets(
  params: FilterParams & { page: number; pageSize: number }
): Promise<PagedResult<PacketSummary>> {
  const cleaned = Object.fromEntries(
    Object.entries(params).filter(([, v]) => v !== undefined && v !== null && v !== '')
  )
  return api.get<PagedResult<PacketSummary>>('/packets', { params: cleaned }).then(r => r.data)
}

export async function getPacketDetail(id: number): Promise<PacketDetail> {
  return api.get<PacketDetail>(`/packets/${id}`).then(r => r.data)
}

export async function getDiff(id: number): Promise<DiffResult> {
  return api.get<DiffResult>(`/packets/${id}/diff`).then(r => r.data)
}

export async function changeFile(filePath: string): Promise<{ message: string; path: string; total: number }> {
  return api.post('/file', { filePath }).then(r => r.data)
}

export async function listDirectory(path?: string): Promise<DirectoryListing> {
  return api.get<DirectoryListing>('/file/ls', path ? { params: { path } } : {}).then(r => r.data)
}

export async function getSuggestedDirs(): Promise<{ home: string | null; appDir: string }> {
  return api.get<{ home: string | null; appDir: string }>('/file/suggested-dirs').then(r => r.data)
}

export async function getHistogram(buckets = 60): Promise<HistogramData> {
  return api.get<HistogramData>('/packets/histogram', { params: { buckets } }).then(r => r.data)
}

export function buildExportUrl(params: {
  scope: 'all' | 'filtered' | 'selected'
  includeShifted: boolean
  selectedIds?: number[]
  packetName?: string
  cmdId?: number
  startTime?: string
  endTime?: string
}): string {
  const q = new URLSearchParams()
  q.set('scope', params.scope)
  q.set('includeShifted', String(params.includeShifted))
  if (params.selectedIds?.length) q.set('selectedIds', params.selectedIds.join(','))
  if (params.packetName) q.set('packetName', params.packetName)
  if (params.cmdId !== undefined) q.set('cmdId', String(params.cmdId))
  if (params.startTime) q.set('startTime', params.startTime)
  if (params.endTime) q.set('endTime', params.endTime)
  return `/api/packets/export?${q.toString()}`
}

// SignalR hub connection (singleton)
export const hubConnection = new signalR.HubConnectionBuilder()
  .withUrl('/packetHub')
  .withAutomaticReconnect()
  .build()

export async function startHub() {
  try {
    await hubConnection.start()
    console.log('[SignalR] Connected')
  } catch (e) {
    console.error('[SignalR] Connection failed:', e)
  }
}
