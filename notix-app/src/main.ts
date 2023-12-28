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
import Dialog from 'primevue/dialog';
import DynamicDialog from 'primevue/dynamicdialog';
import InputText from 'primevue/inputtext'
import Textarea from 'primevue/textarea'


// Services
import DialogService from 'primevue/dialogservice'


const app = createApp(App)

app.use(PrimeVue, { ripple: true })
app.use(createPinia())
app.use(router)

// Services
app.use(DialogService);


app.component("pv-button", Button)
app.component("pv-tabview", TabView)
app.component("pv-tabpanel", TabPanel)
app.component("pv-dialog", Dialog)
app.component("pv-dynamic-dialog", DynamicDialog)
app.component("pv-input-text", InputText)
app.component("pv-text-area", Textarea)

app.mount('#app')
