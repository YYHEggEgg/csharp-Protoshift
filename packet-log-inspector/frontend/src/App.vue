<script setup lang="ts">
import { onMounted } from 'vue'
import { useRouter } from 'vue-router'
import { usePacketStore } from './stores/packetStore'
import { hubConnection } from './api/client'

const router = useRouter()
const store = usePacketStore()

onMounted(async () => {
  const status = await store.fetchStatus()
  if (status.filePath) {
    await store.fetchPackets()
    router.push('/home')
  }

  // Subscribe to incremental update notifications from server
  hubConnection.on('NewRecordsAdded', async (count: number) => {
    await store.onNewRecords(count)
  })
})
</script>

<template>
  <router-view />
</template>
