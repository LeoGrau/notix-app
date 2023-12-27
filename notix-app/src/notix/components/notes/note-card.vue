<template>
  <div class="note-card p-card p-3 surface-c">
    <header class="flex justify-content-between">
      <div class="">
        <h3>Hey Do This! Check This! Wtf!</h3>
      </div>
      <div class="buttons flex gap-2 align-items-start">
        <pv-button icon="pi pi-eye" severity="success"></pv-button>
      </div>
    </header>
    <body>
      <read-more
        :text="'lorem ipsum blab abla sorry for party rocking, xdxd, dunno what i m writing'"
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
export default defineComponent({
  components: { ReadMore },
  data() {
    return {}
  }
})
</script>
<style lang=""></style>
