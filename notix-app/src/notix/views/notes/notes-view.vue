<template>
  <div class="notes-view">
    <section class="menu p-3 flex flex-column gap-3">
      <div class="buttons flex gap-3">
        <pv-button label="New" icon="pi pi-plus"></pv-button>
      </div>
      <div class="">
        <pv-tabview>
          <pv-tabpanel>
            <template #header>
              <div class="flex gap-2">
                <i class="bi bi-card-checklist"></i>
                <span>My Notes</span>
              </div>
            </template>
            <div class="notes grid m-0">
              <div class="col-12 md:col-6">
                <note-card></note-card>
              </div>
            </div>
          </pv-tabpanel>
          <pv-tabpanel>
            <template #header>
              <div class="flex gap-2">
                <i class="bi bi-archive"></i>
                <span>Archived</span>
              </div>
            </template>
            <div class="notes grid m-0">
              <div class="col-12 md:col-6">
                <note-card></note-card>
              </div>
            </div>
          </pv-tabpanel>
        </pv-tabview>
      </div>
    </section>
  </div>
</template>
<script lang="ts" setup>
import NoteCard from '@/notix/components/notes/note-card.vue';
</script>
<style lang="">
  
</style>