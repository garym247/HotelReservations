using System;
using HotelReservations.Model;

namespace HotelReservations.ViewModels
{
    public class ReservationViewModel : ViewModelBase
    {
        private readonly Reservation reservation;
        public string Room => reservation.Room.ToString();
        public string Client => reservation.Client;
        public DateTime StartDate => reservation.StartDate;
        public DateTime EndDate => reservation.EndDate;

        public ReservationViewModel(Reservation theReservation)
        {
            reservation = theReservation;
        }
        
    }
}