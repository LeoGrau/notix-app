import 'primevue/resources/primevue.css'
import "primeflex/primeflex.css"
import '@/assets/styles/main.css'

import PrimeVue from 'primevue/config'

import "primevue/resources/themes/lara-dark-green/theme.css"

// Icons
import 'primeicons/primeicons.css'
// import 'boxicons/css/boxicons.min.css'
import 'bootstrap-icons/font/bootstrap-icons.min.css'

import { createApp } from 'vue'
import { createPinia } from 'pinia'

// Primevue Components


import App from './App.vue'
import router from './router'

// Primevue Componetns
import Button from "primevue/button"
import TabView from 'primevue/tabview'
import TabPanel from 'primevue/tabpanel'

const app = createApp(App)

app.use(PrimeVue, { ripple: true })
app.use(createPinia())
app.use(router)


app.component("pv-button", Button)
app.component("pv-tabview", TabView)
app.component("pv-tabpanel", TabPanel)

app.mount('#app')
