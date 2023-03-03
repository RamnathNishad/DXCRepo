using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHelloWorld.Models
{
    public class City
    {
        public List<string> GetCities()
        {
            var cities = new List<string> { "Bangalore", "Delhi", "Chennai", "Jaipur","Hyderabad" };
            return cities;
        }
    }
}