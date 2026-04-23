<script setup lang="ts">
import { ref, onMounted } from 'vue'
import { useRoute, useRouter } from 'vue-router'
import { getDiff } from '../api/client'
import MonacoDiffViewer from '../components/MonacoDiffViewer.vue'
import type { DiffResult } from '../types'

const route = useRoute()
const router = useRouter()
const id = Number(route.params.id)

const diffData = ref<DiffResult | null>(null)
const loading = ref(true)
const errorMsg = ref('')

onMounted(async () => {
  loading.value = true
  try {
    diffData.value = await getDiff(id)
  } catch (e: any) {
    errorMsg.value = e?.response?.data ?? String(e)
  } finally {
    loading.value = false
  }
})
</script>

<template>
  <div class="diff-view">
    <!-- Breadcrumb -->
    <div class="diff-toolbar">
      <el-breadcrumb separator="/">
        <el-breadcrumb-item @click="router.push('/home')" style="cursor:pointer">
          首页
        </el-breadcrumb-item>
        <el-breadcrumb-item>Diff #{{ id }}</el-breadcrumb-item>
      </el-breadcrumb>
      <el-button size="small" @click="router.back()">返回</el-button>
    </div>

    <!-- Column labels -->
    <div class="diff-labels">
      <div class="label-left">原始 (body)</div>
      <div class="label-right">转换后 (shiftedData)</div>
    </div>

    <!-- Loading / Error / Diff -->
    <div v-if="loading" class="center-msg">
      <el-icon class="is-loading"><i-ep-loading /></el-icon>
      <span>加载中...</span>
    </div>
    <div v-else-if="errorMsg" class="center-msg error">{{ errorMsg }}</div>
    <div v-else-if="diffData" class="diff-editor-container">
      <MonacoDiffViewer :original="diffData.originalJson" :modified="diffData.modifiedJson" />
    </div>
  </div>
</template>

<style scoped>
.diff-view {
  display: flex;
  flex-direction: column;
  height: 100vh;
  padding: 0 16px;
  box-sizing: border-box;
  background: #1e1e2e;
  color: #e0e0e0;
}
.diff-toolbar {
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding: 10px 0;
  border-bottom: 1px solid #3a3a55;
  flex-shrink: 0;
}
.diff-labels {
  display: flex;
  padding: 6px 0;
  font-size: 12px;
  color: #9e9eb0;
  flex-shrink: 0;
}
.label-left {
  flex: 1;
  padding-left: 4px;
}
.label-right {
  flex: 1;
  padding-left: 4px;
}
.diff-editor-container {
  flex: 1;
  min-height: 0;
}
.center-msg {
  display: flex;
  align-items: center;
  justify-content: center;
  gap: 8px;
  flex: 1;
  font-size: 14px;
  color: #9e9eb0;
}
.center-msg.error {
  color: #f56c6c;
}
</style>
