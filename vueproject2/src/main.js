import Vue from 'vue';
import '@progress/kendo-ui';
import '@progress/kendo-theme-default/dist/all.css';
import { Button, ButtonsInstaller } from '@progress/kendo-buttons-vue-wrapper';
import { GaugesInstaller } from '@progress/kendo-gauges-vue-wrapper';
import { Grid, GridColumn, GridInstaller } from '@progress/kendo-grid-vue-wrapper';


import App from './App.vue';
import router from './router';

Vue.config.productionTip = false;
Vue.use(ButtonsInstaller);
Vue.use(GaugesInstaller);
Vue.use(GridInstaller);
Vue.use(GridColumn);
Vue.use(Grid);
Vue.use(Button);


new Vue({
  router,
  render: h => h(App),
}).$mount('#app');
