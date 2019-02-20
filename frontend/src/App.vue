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
import Navbar from './components/Navbar';
import Chart from "chart.js";
import {Line} from "vue-chartjs";

export default {
  name: 'App',
  components: {
    Navbar
  }

};
</script>
