using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Weather
    {
        public MainWeather main;
    }

    public class MainWeather
    {
        public string temp;
    }
}