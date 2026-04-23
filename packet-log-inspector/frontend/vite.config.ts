import { defineConfig } from 'vite'
import vue from '@vitejs/plugin-vue'
import tailwindcss from '@tailwindcss/vite'
import monacoEditorPlugin from 'vite-plugin-monaco-editor'

// vite-plugin-monaco-editor may export default as the function or nested under .default
const monacoPlugin = (monacoEditorPlugin as any).default ?? monacoEditorPlugin

export default defineConfig({
  plugins: [
    vue(),
    tailwindcss(),
    monacoPlugin({ languageWorkers: ['json'] })
  ],
  build: {
    outDir: '../wwwroot',
    emptyOutDir: true
  },
  server: {
    proxy: {
      '/api': {
        target: 'http://localhost:18880',
        changeOrigin: true
      },
      '/packetHub': {
        target: 'http://localhost:18880',
        ws: true,
        changeOrigin: true
      }
    }
  }
})
