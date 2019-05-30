using System;
using System.Collections.Generic;

namespace planner
{
    class Program
    {
        static void Main()
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                depth = 45.5,
                width = 48.5,
                stories = 102
            };

            Building FiveOneOneEigth = new Building("511 8th Avenue")
            {
                depth = 25.5,
                width = 32.5,
                stories = 75
            };

            Building FiveOnZeroEigth = new Building("510 8th Avenue")
            {
                depth = 33.5,
                width = 52.5,
                stories = 123
            };

            FiveOneTwoEigth.Construct();
            FiveOneOneEigth.Construct();
            FiveOnZeroEigth.Construct();

            FiveOneTwoEigth.Purchase("Bob");
            FiveOneOneEigth.Purchase("Tom");
            FiveOnZeroEigth.Purchase("Sally");

            List<Building> listOfBuildings = new List<Building>() {
                FiveOneTwoEigth, FiveOneOneEigth, FiveOnZeroEigth
            };

            City BillysTown = new City()
            {
                cityName = "Billy's Town",
                mayorName = "Billy Mitchell",
                dateEstablished = new DateTime(2019, 5, 29)
            };

            foreach (Building building in listOfBuildings)
            {
                BillysTown.AddBuildingToCity(building);
            }

            List<City> listOfCities = new List<City>() {
                BillysTown
            };

            foreach(City city in listOfCities) {
                city.DisplayCityDetails();
                foreach(Building building in listOfBuildings) {
                    building.DisplayBuildingDetails();
                }
            }
        }
    }
}
