using System;
using System.Collections.Generic;

namespace planner
{
    public class Building
    {
        // Private Fields with public Get methods
        private string _designer = "William Mitchell";
        public string GetDesigner() => _designer;
        private DateTime _dateConstructed { get; set; }
        public DateTime GetDateTime() => _dateConstructed;
        private string _address { get; set; }
        public string GetAddress() => _address;
        private string _owner { get; set; }
        public string GetOwner() => _owner;

        // Public Properties
        public int stories { get; set; }
        public double width { get; set; }
        public double depth { get; set; }
        public string volume
        {
            get
            {
                return $"{(3 * stories) * width * depth}";
            }
        }

        // Constructor
        public Building(string address)
        {
            _dateConstructed = DateTime.Now;
            _address = address;
            stories = 0;
            width = double.MaxValue;
            depth = double.MaxValue;
        }

        public void Construct() => _dateConstructed = DateTime.Now;

        public void Purchase(string owner) => _owner = owner;

        public void DisplayBuildingDetails()
        {
            Console.WriteLine();
            Console.WriteLine($"The building located at {this._address}");
            Console.WriteLine("--------------");
            Console.WriteLine($"Was designed by: {this._designer}");
            Console.WriteLine($"Time construction completed: {this._dateConstructed}");
            Console.WriteLine($"It is owned by: {this._owner}");
            Console.WriteLine($"And it contains {this.volume} cubic meters of space");
        }
    }
}