using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA
{
    class Flight
    {
        int flightID;
        string from;
        string to;
        string stopovers;
        string airplaneName;
        int capacity;
        int numberOfRows;
        string meal;
        string departureDate;
        string arrivalDate;
        string flightName;
        string departureTime;

        

        public Flight() { }

        public Flight(string flightName, int flightID, string from, string to, string stopovers, string airplaneName, int capacity, int numberOfRows, string meal, string departureDate, string arrivalDate,  string departureTime)
        {
            this.flightName = flightName;
            this.flightID = flightID;
            this.from = from;
            this.to = to;
            this.stopovers = stopovers;
            this.airplaneName = airplaneName;
            this.capacity = capacity;
            this.numberOfRows = numberOfRows;
            this.meal = meal;
            this.departureDate = departureDate;
            this.arrivalDate = arrivalDate;
            this.departureTime = departureTime;
        }

        public int FlightID { get => flightID; set => flightID = value; }
        public string From { get => from; set => from = value; }
        public string To { get => to; set => to = value; }
        public string Stopovers { get => stopovers; set => stopovers = value; }
        public string AirplaneName { get => airplaneName; set => airplaneName = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public int NumberOfRows { get => numberOfRows; set => numberOfRows = value; }
        public string Meal { get => meal; set => meal = value; }
        public string DepartureDate { get => departureDate; set => departureDate = value; }
        public string ArrivalDate { get => arrivalDate; set => arrivalDate = value; }
        public string FlightName { get => flightName; set => flightName = value; }
        public string DepartureTime { get => departureTime; set => departureTime = value; }

        public static List<Flight> flightList = new List<Flight>();

        public void Add(Flight fly)
        {
            flightList.Add(fly);
        }

    }

}
