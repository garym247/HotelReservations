using System.ComponentModel;
using HotelReservations.Model;
using HotelReservations.Stores;

namespace HotelReservations.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;

        public MainViewModel(Hotel hotel, NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            //CurrentViewModel = new MakeReservationViewModel(hotel);
            //CurrentViewModel = new ReservationsListViewModel();
        }
    } 

}