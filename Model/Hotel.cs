using System;
using System.Collections.Generic;

namespace HotelReservations.Model
{
    public class Hotel
    {
        private readonly ReservationBook reservationBook = new ReservationBook();

        public string Name { get; }

        public Hotel(string name)
        {
            Name = name;
        }
        public IEnumerable<Reservation> GetReservationsForClient(string client)
        {
            return reservationBook.GetReservationsForClient(client);
        }
        public void AddReservation(Reservation newReservation)
        {
            reservationBook.AddReservation(newReservation);
        }
    };
}
