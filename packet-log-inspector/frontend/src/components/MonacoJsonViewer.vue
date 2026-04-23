<script setup lang="ts">
import { ref, onMounted, onBeforeUnmount, watch } from 'vue'
import * as monaco from 'monaco-editor'

interface Props {
  value: string
}
const props = defineProps<Props>()

const containerRef = ref<HTMLDivElement | null>(null)
let editor: monaco.editor.IStandaloneCodeEditor | null = null

onMounted(() => {
  if (!containerRef.value) return
  editor = monaco.editor.create(containerRef.value, {
    value: props.value,
    language: 'json',
    readOnly: true,
    theme: 'vs-dark',
    minimap: { enabled: false },
    folding: true,
    automaticLayout: true,
    scrollBeyondLastLine: false,
    fontSize: 13
  })
})

watch(() => props.value, (val) => {
  if (editor && editor.getValue() !== val) {
    editor.setValue(val)
  }
})

onBeforeUnmount(() => {
  editor?.dispose()
  editor = null
})

function foldAll() {
  editor?.getAction('editor.foldAll')?.run()
}
function unfoldAll() {
  editor?.getAction('editor.unfoldAll')?.run()
}

defineExpose({ foldAll, unfoldAll })
</script>

<template>
  <div class="monaco-json-wrapper">
    <div class="viewer-toolbar">
      <el-button size="small" @click="foldAll">全部折叠</el-button>
      <el-button size="small" @click="unfoldAll">全部展开</el-button>
    </div>
    <div ref="containerRef" class="editor-container" />
  </div>
</template>

<style scoped>
.monaco-json-wrapper {
  display: flex;
  flex-direction: column;
  height: 100%;
}
.viewer-toolbar {
  display: flex;
  gap: 8px;
  padding: 6px 0;
  flex-shrink: 0;
}
.editor-container {
  flex: 1;
  min-height: 0;
  border: 1px solid #3a3a55;
  border-radius: 4px;
  overflow: hidden;
}
</style>
