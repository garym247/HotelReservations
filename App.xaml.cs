using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using HotelReservations.Model;

namespace HotelReservations
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("The Big G's Hotel");

            Reservation reservationFred1 = new Reservation(new RoomID(1,1), "fred", new DateTime(2020, 1, 1), new DateTime(2020, 1, 10) );
            Reservation reservationFred2 = new Reservation(new RoomID(1,1), "fred", new DateTime(2020, 1, 25), new DateTime(2020, 1, 27) );
            Reservation reservationBob1 = new Reservation(new RoomID(1,2), "bob", new DateTime(2020, 1, 1), new DateTime(2020, 1, 5) );

            hotel.AddReservation(reservationFred1);
            hotel.AddReservation(reservationFred2);
            hotel.AddReservation(reservationBob1);

            var fredsReservations = hotel.GetReservationsForClient("fred");
            var numFredsReservations = fredsReservations.Count(); 

            base.OnStartup(e);
        }
    }
}
