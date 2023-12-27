<template>
  <div>
    <p>
      {{ text?.slice(0, 50) + '...' }}
    </p>
    <span class="hover:text-green-400 cursor-pointer transition-duration-100">Read More</span>
  </div>
</template>
<script lang="ts">
import { defineComponent } from 'vue'
export default defineComponent({
  props: {
    text: String
  }
})
</script>
<style lang=""></style>
