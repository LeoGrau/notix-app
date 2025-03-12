<template>
<div class="flex items-center justify-center min-h-screen bg-gray-100 px-4 sm:px-6 lg:px-8">
  <div class="w-full max-w-md p-6 bg-white rounded-lg shadow-md">
    <h2 class="text-2xl font-semibold text-center mb-4 text-yellow-400 ">Bienvenido a <span class="text-indigo-700 font-extrabold">Notix</span></h2>
    <p class="text-center font-normal mb-4">Tus ideas, siempre organizadas. Notas rápidas, grandes ideas. ¡Todo en un solo lugar!</p>

    <form @submit.prevent="login">
      <div class="mb-4">
        <label for="email" class="block text-sm font-medium text-gray-700">Correo Electrónico</label>
        <input type="email" v-model="email" id="email" class="w-full px-4 py-2 border rounded-lg focus:ring focus:ring-blue-300 sm:text-lg" required>
      </div>

      <div class="mb-4">
        <label for="password" class="block text-sm font-medium text-gray-700">Contraseña</label>
        <input type="password" v-model="password" id="password" class="w-full px-4 py-2 border rounded-lg focus:ring focus:ring-blue-300 sm:text-lg" required>
      </div>

      <button type="submit" class="w-full bg-indigo-700 text-white py-2 rounded-lg hover:bg-indigo-800 sm:text-lg">Iniciar Sesión</button>

      <div class="mt-4 text-center">
      <p class="text-indigo-700">¿Aún no tienes cuenta? <a href="" class="text-yellow-400 font-semibold hover:underline">Regístrate</a></p>
      <button class="w-full mt-3 flex items-center justify-center bg-indigo-700 text-white py-2 rounded-lg hover:bg-indigo-800">
        <img src="https://cdn-icons-png.flaticon.com/512/2702/2702602.png" alt="Google" class="w-5 h-5 mr-2"> Iniciar sesión con Google
      </button>
    </div>
    </form>
  </div>
</div>
</template>

<script lang = "ts">
export default {
data() {
  return {
    email: '',
    password: '',
    errors: []
  };
},
};
</script>

<style scoped>
@import url('https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100..900;1,100..900&display=swap');

body {
font-family: "Roboto", sans-serif;
}
</style>