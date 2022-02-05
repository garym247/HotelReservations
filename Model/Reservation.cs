using System;

namespace HotelReservations.Model
{
    public class Reservation
    {
        public RoomID Room { get; }
        public string Client { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }

        public Reservation(RoomID room, string client, DateTime startDate, DateTime endDate)
        {
            Room = room;
            Client = client;
            StartDate = startDate;
            EndDate = endDate;
        }

        public bool Conflicts(Reservation otherReservation)
        {
            if( Room == otherReservation.Room && 
                StartDate < otherReservation.EndDate && 
                EndDate > otherReservation.StartDate)
            {
                return true;
            }

            return false;
        }
    };
}
