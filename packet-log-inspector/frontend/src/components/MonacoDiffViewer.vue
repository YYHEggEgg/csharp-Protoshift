<script setup lang="ts">
import { ref, onMounted, onBeforeUnmount, watch } from 'vue'
import * as monaco from 'monaco-editor'

interface Props {
  original: string
  modified: string
}
const props = defineProps<Props>()

const containerRef = ref<HTMLDivElement | null>(null)
let diffEditor: monaco.editor.IStandaloneDiffEditor | null = null
let originalModel: monaco.editor.ITextModel | null = null
let modifiedModel: monaco.editor.ITextModel | null = null

function createModels(orig: string, mod: string) {
  originalModel?.dispose()
  modifiedModel?.dispose()
  originalModel = monaco.editor.createModel(orig, 'json')
  modifiedModel = monaco.editor.createModel(mod, 'json')
  diffEditor?.setModel({ original: originalModel, modified: modifiedModel })
}

onMounted(() => {
  if (!containerRef.value) return
  diffEditor = monaco.editor.createDiffEditor(containerRef.value, {
    readOnly: true,
    renderSideBySide: true,
    theme: 'vs-dark',
    hideUnchangedRegions: { enabled: true, minimumLineCount: 3 },
    automaticLayout: true,
    scrollBeyondLastLine: false,
    fontSize: 13
  })
  createModels(props.original, props.modified)
})

watch([() => props.original, () => props.modified], ([orig, mod]) => {
  createModels(orig, mod)
})

onBeforeUnmount(() => {
  originalModel?.dispose()
  modifiedModel?.dispose()
  diffEditor?.dispose()
  diffEditor = null
})
</script>

<template>
  <div ref="containerRef" class="diff-editor-container" />
</template>

<style scoped>
.diff-editor-container {
  width: 100%;
  height: 100%;
  border: 1px solid #3a3a55;
  border-radius: 4px;
  overflow: hidden;
}
</style>
