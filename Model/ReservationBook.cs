using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelReservations.Model
{
    public class ReservationBook
    {
        private readonly List<Reservation> reservations = new List<Reservation>();
    
        public IEnumerable<Reservation> GetReservationsForClient(string client)
        {
            return reservations.Where(r => r.Client == client);
        }
        public void AddReservation(Reservation newReservation)
        {
            foreach (var existingReservation in reservations)
            {
                if(newReservation.Conflicts(existingReservation))
                {
                    throw new ReservationConflictException(newReservation, existingReservation );
                }
            }

            reservations.Add(newReservation);
        }
    };
}
