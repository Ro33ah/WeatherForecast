<template>
  <p class="homeText">
    A SIMPLE WEBPAGE :D
    <br>
    <b-form-select class="col-sm-4" v-model="selected" :options="options" @change="getWeather($event)"/>
    <br>
    <canvas v-show="isCanvasNull" id="forecastChart">
    </canvas>
  </p>
</template>

<script>
import {APIService} from '../APIService';
//const API_URL = 'https://localhost:5001';
const apiService = new APIService();

export default {
  name: 'Home',
  data() {
    return {
      selected: null,
      options: [ 
        { value: null, text: 'Choose a city', disabled: true},
        { value: '2879139', text: 'Leipzig'},
        { value: '2929670', text: 'Erfurt' },
        { value: '2950158', text: 'Berlin' },
        { value: '2911298', text: 'Hamburg' }
      ],
      // forecasts:[
      //   {date: data.list.newDate, temp: data.list.main.temp, humidity: data.list.main.humidity}
      // ]
    }
  },
  methods:{
    getWeather(event){
      apiService.getWeather(event).then((data)=> {
        this.dates = data.list.map(list => {
          return list.newDate;
        });
        this.temps = data.list.map( list => {
          return list.main.temp;
        });
        this.humidities = data.list.map( list => {
          return list.main.humidity;
        });
        console.log(this.dates);
        console.log(this.temps);
        console.log(this.humidities);
          var ctx = document.getElementById("forecastChart").getContext('2d');
      this.chart = new Chart(ctx, {
        type: "line",
        data: {
          isCanvasNull: '',
          labels: this.dates,
          datasets: [
            {
              data: this.temps,
              label: "Av.Temp (F)",
              //backgroundColor: ["rgba(54, 162, 235, 0.5)"],
              borderColor: ["rgb(54, 162, 235)"],
              borderWidth: 3,
            },
            {
              data: this.humidities,
              label: "Humidity (%)",
              //backgroundColor: ["rgba(71, 183,132,0.5)"],
              borderColor: ["rgb(71, 183,132,.5)"],
              borderWidth: 3,
            }
          ]
        },
        options: {
          lineTension: 6,
          responsive: true,
          title: {
            display: true,
            fontSize: 30,
            fontColor: '#FA8072',
            text: "5-day Temperature & Humidity"
          },
          scales: {
            yAxes: [{
              ticks: {
                beginAtZero: true
              }
            }],
            xAxes: [{
              ticks:{
                beginAtZero: true
              }
            }]
          }
        }
      })
      });
    
    }
    },
    mounted() {
this.getWeather();
this.isCanvasNull = this.canvas === null? false : true;
}
};
</script>

<style scoped>
.homeText{
    font-size: 35px;
    color: black;
    text-align: center;
    position: relative;
    top:30px;
    text-shadow: 2px 2px 2px gray;
}
.header{
  font-size: 25px;
    color: black;
    text-align: center;
    position: relative;
    text-shadow: 2px 2px 2px gray;
}
.col-sm-4{
  display: inline-block;
}
#forecastChart{
  background: #212733;
  border-radius: 15px;
  /* box-shadow: 0px 2px 15px rgba(25, 25, 25, 0.27); */
  margin:  25px 0;
}

</style>
