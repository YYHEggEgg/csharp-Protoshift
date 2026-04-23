import { createRouter, createWebHistory } from 'vue-router'
import WelcomeView from '../views/WelcomeView.vue'
import HomeView from '../views/HomeView.vue'
import DiffView from '../views/DiffView.vue'

const router = createRouter({
  history: createWebHistory(),
  routes: [
    { path: '/', component: WelcomeView },
    { path: '/home', component: HomeView },
    { path: '/diff/:id', component: DiffView }
  ]
})

export default router
