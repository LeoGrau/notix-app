<template>
  <div class="bg-blue-900 px-2 flex justify-content-between align-items-center">
    <div class="">
      <h3>Notix.APP</h3>
    </div>
    <ul class="flex gap-4 p-0 m-0">
      <li class="list-none" v-for="route in routes" :key="route.id">
        <router-link class="no-underline" :to="route.path"> {{ route.pathName }}</router-link>
      </li>
    </ul>
  </div>
</template>
<script lang="ts">
import { defineComponent } from 'vue'
export default defineComponent({
  data() {
    return {
      routes: [
        {
          id: 1,
          path: '/',
          pathName: 'Home'
        },
        {
          id: 2,
          path: '/my-notes',
          pathName: 'Notes'
        }
      ]
    }
  }
})
</script>
<style scoped></style>
