using System;
using System.Collections.Generic;
using System.Net;

namespace backend.Models
{
    public class WeatherModel
    {
        public IEnumerable<List> List { get; set; }

    }
    
    public class List
    {
        public Main Main { get; set; }
        public long Dt { get; set; }
        public DateTime NewDate
        {
            get
            {
                //Dt /= 1000;
                DateTime NewDate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                NewDate = NewDate.AddSeconds(Dt);
                return NewDate;
                // return NewDate.Date.ToString("d");
            }
        }
    }
    public class Main
    {
        public float Temp { get; set; }
        public int Humidity { get; set; }

    }
}

