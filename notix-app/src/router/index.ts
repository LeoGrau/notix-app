import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '@/notix/views/home-view.vue'
import NotesView from '@/notix/views/notes/notes-view.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: HomeView
    },
    {
      path: '/my-notes',
      name: 'my-notes',
      component: NotesView
    },
  ]
})

export default router
