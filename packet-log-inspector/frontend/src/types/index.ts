export interface PacketSummary {
  id: number
  packetTime: string
  packetName: string
  cmdId: number
  sentByClient: boolean
  handleIntervalNanoseconds: number
  hasShiftedData: boolean
  bodySize: number
  shiftedDataSize: number
}

export interface PacketDetail {
  id: number
  packetTime: string
  uid: number
  packetName: string
  cmdId: number
  sentByClient: boolean
  handleIntervalNanoseconds: number
  hasShiftedData: boolean
  bodyJson: string
}

export interface DiffResult {
  originalJson: string
  modifiedJson: string
}

export interface LogStatus {
  filePath: string | null
  total: number
  earliest: string | null
  latest: string | null
}

export interface PagedResult<T> {
  items: T[]
  total: number
  page: number
  pageSize: number
}

export interface FilterParams {
  packetName?: string
  cmdId?: number
  startTime?: string
  endTime?: string
}

export interface TimeRange {
  earliest: string | null
  latest: string | null
}

export interface HistogramBucket {
  startTime: string
  endTime: string
  count: number
}

export interface HistogramData {
  buckets: HistogramBucket[]
  earliest: string | null
  latest: string | null
}

export interface FsEntry {
  name: string
  fullPath: string
  type: 'dir' | 'file'
  size?: number
}

export interface DirectoryListing {
  currentPath: string | null
  parentPath: string | null
  isRoot: boolean
  entries: FsEntry[]
}
