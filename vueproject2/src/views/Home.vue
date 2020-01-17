<template>
  <div class="home">
    <img alt="Vue logo" src="../assets/logo.png">
    <HelloWorld msg="Welcome to Your Vue.js App"/>
    <Grid msg="The Grid view"/>
  </div>
</template>

<script>
// @ is an alias to /src
import HelloWorld from '@/components/HelloWorld.vue';
import Grid from '@/components/Grid.vue';


export default {
  name: 'home',
  components: {
    HelloWorld,
    Grid,
  },
};
</script>
