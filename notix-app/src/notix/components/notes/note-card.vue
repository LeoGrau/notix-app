<template>
  <div class="note-card p-card p-3 surface-c flex flex-column justify-content-between">
    <header class="flex justify-content-between">
      <div class="">
        <h3>{{ note?.title }}</h3>
      </div>
      <div class="buttons flex gap-2 align-items-start">
        <pv-button icon="pi pi-eye" severity="success"></pv-button>
      </div>
    </header>
    <body>
      <read-more
        :text="note?.description"
      ></read-more>
    </body>
    <footer class="flex justify-content-end gap-2">
      <pv-button icon="pi pi-trash" severity="danger"></pv-button>
      <pv-button icon="bi bi-archive" severity="warning"></pv-button>
    </footer>
  </div>
</template>
<script lang="ts">
import { defineComponent } from 'vue'
import ReadMore from '@/notix/components/text/read-more.vue'

// Models
import Note from "@/notix/models/notes/note.model"

export default defineComponent({
  components: { ReadMore },
  props: {
    note: Note
  },
  data() {
    return {}
  }
})
</script>
<style scoped>
.note-card {
  min-height: 240px;
}
</style>
