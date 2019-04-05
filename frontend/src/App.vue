<template>
  <b-container id="app">
    <b-row>
      <b-col>
        <navbar></navbar>
      </b-col>
    </b-row>
    <b-row>
      <b-col>
        <router-view/>
      </b-col>
    </b-row>
  </b-container>
</template>

<script>
import Vue from "vue";
import Navbar from './components/Navbar';
import Chart from "chart.js";
import {Line} from "vue-chartjs";
import VueMask from "v-mask"
Vue.use(VueMask);

export default {
  name: 'App',
  components: {
    Navbar
  }

};
</script>
