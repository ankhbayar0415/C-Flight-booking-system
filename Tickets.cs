using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA
{
    class Tickets
    {
        string firstName;
        string lastName;
        string daate;
        string seatRow;
        string seatAlign;
        string flightNameT;
        int ticketID;

        public Tickets(){}

        public Tickets(string firstName, string lastName, string daate, string seatRow, string seatAlign, string flightNameT, int ticketID)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.daate = daate;
            this.seatRow = seatRow;
            this.seatAlign = seatAlign;
            this.flightNameT = flightNameT;
            this.ticketID = ticketID;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Daate { get => daate; set => daate = value; }
        public string SeatRow { get => seatRow; set => seatRow = value; }
        public string SeatAlign { get => seatAlign; set => seatAlign = value; }
        public string FlightNameT { get => flightNameT; set => flightNameT = value; }
        public int TicketID { get => ticketID; set => ticketID = value; }


        public static List<Tickets> ticketList = new List<Tickets>();
        public void AddToFlight(Tickets tick)
        {
            ticketList.Add(tick);
        }
    }
}
