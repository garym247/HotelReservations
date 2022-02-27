using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using HotelReservations.Model;

namespace HotelReservations.ViewModels
{
    public class ReservationsListViewModel : ViewModelBase
    {
        public readonly ObservableCollection<ReservationViewModel> reservations;

        public IEnumerable<ReservationViewModel> Reservations => reservations;

        public ICommand MakeReservationCommand { get; }

        public ReservationsListViewModel()
        {
            reservations = new ObservableCollection<ReservationViewModel>();

            reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 1), "bob", DateTime.Now, DateTime.Now) ));
            reservations.Add(new ReservationViewModel(new Reservation(new RoomID(2, 1), "fred", DateTime.Now, DateTime.Now) ));
            reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 2), "geoff", DateTime.Now, DateTime.Now) ));
            reservations.Add(new ReservationViewModel(new Reservation(new RoomID(2, 2), "harry", DateTime.Now, DateTime.Now) ));
        }
    }
}