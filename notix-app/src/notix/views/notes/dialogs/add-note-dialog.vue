<template>
  <div>
    <form @submit="onSubmit" class="grid m-0 mt-3">
      <div class="col-12 p-0 pr-2 py-2">
        <div class="p-float-label">
          <pv-input-text class="w-full" id="username" v-model="title" />
          <label for="username">Title</label>
        </div>
        <small class="p-error" id="text-error">{{ titleErrorMessage || '&nbsp;' }}</small>
      </div>
      <div class="col-12 p-0 pr-2 py-2">
        <div class="p-float-label">
          <pv-text-area class="w-full" id="username" v-model="description" />
          <label for="username">Description</label>
        </div>
        <small class="p-error" id="text-error">{{ descriptionErrorMessage || '&nbsp;' }}</small>
      </div>
      <div class="flex gap-2 justify-content-end w-full">
        <pv-button type="submit" label="Submit"></pv-button>
        <pv-button
          type="submit"
          label="Cancel"
          severity="danger"
          @click="closeDialog()"
        ></pv-button>
      </div>
    </form>
  </div>
</template>
<script setup lang="ts">
import { useField, useForm } from 'vee-validate'
import { inject } from 'vue'

// Tools
import { defaultValidator } from '../../../../tools/validator/validator'

// Forms
const { handleSubmit } = useForm()

// Inputs
const { value: title, errorMessage: titleErrorMessage } = useField(
  'title',
  defaultValidator('Title')
)
const { value: description, errorMessage: descriptionErrorMessage } = useField(
  'description',
  defaultValidator('Description')
)

// Dialog
const dialogRef = inject('dialogRef') as any

const onSubmit = handleSubmit((values) => {
  dialogRef.value.close({ values })
})

function closeDialog() {
  dialogRef.value.close({ values: 12 })
}
</script>
<style lang=""></style>
