<template>
  <pv-button @click="toggleTheme()" label="Change" severity="success"></pv-button>
</template>
<script setup lang="ts">
function toggleTheme() {
  document.getElementsByTagName('html')[0].classList.toggle('p-dark')
}
</script>
<style lang=""></style>
