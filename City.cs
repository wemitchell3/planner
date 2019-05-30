using System;
using System.Collections.Generic;

namespace planner
{
    public class City
    {
        public City()
        {
            cityName = cityName;
            mayorName = mayorName;
            dateEstablished = dateEstablished;
        }

        public string cityName { get; set; }
        public string mayorName { get; set; }
        public DateTime dateEstablished { get; set; }
        public List<Building> BuildingsInCity = new List<Building>();
        public void AddBuildingToCity(Building building) => BuildingsInCity.Add(building);
        public void DisplayCityDetails()
        {
            Console.WriteLine();
            Console.WriteLine($"The name of this City is: {this.cityName}");
            Console.WriteLine($"The Mayor of the City is: {this.mayorName}");
            Console.WriteLine($"This City was Established on: {this.dateEstablished}");
        }
    }
}