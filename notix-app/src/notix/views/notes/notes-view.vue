<template>
  <pv-dynamic-dialog></pv-dynamic-dialog>
  <div class="notes-view">
    <section class="menu p-3 flex flex-column gap-3">
      <div class="buttons flex gap-3">
        <pv-button @click="openAddNewNoteDialog()" label="New" icon="pi pi-plus"></pv-button>
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
              <div class="col-12 md:col-6 lg:col-4" v-for="note in notes" :key="note.id">
                <note-card :note="(note as Note)"></note-card>
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
              <div class="col-12 md:col-6 lg:col-4" v-for="note in notes" :key="note.id">
                <note-card :note="(note as Note)"></note-card>
              </div>
            </div>
          </pv-tabpanel>
        </pv-tabview>
      </div>
    </section>
  </div>
</template>
<script lang="ts" setup>
import NoteCard from '@/notix/components/notes/note-card.vue'
import Note from '@/notix/models/notes/note.model';
import { ref } from 'vue'
import { useDialog } from 'primevue/usedialog';


// Own Dialog Components 
import AddNoteDialog from "@/notix/views/notes/dialogs/add-note-dialog.vue"

const notes = ref([
  new Note(1, "Title 1", "Making me the description 1 for this test. Please make me proud"),
  new Note(2, "Title 2", "Making me the description 2 for this test. Please make me proud"),
  new Note(3, "Title 3", "Making me the description 3 for this test. Please make me proud"),
])

const dialog = useDialog();

// Dialog
function openAddNewNoteDialog() {
  dialog.open(AddNoteDialog, {
    props: {
      style: {
        width: '600px'
      },
      header: "Add New Note",
      modal: true
    },
    onClose(options) {
        console.log(options);
        console.log(options?.data)
    },
  })
}
</script>
<style lang=""></style>
