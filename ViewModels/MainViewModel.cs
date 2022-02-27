using System.ComponentModel;

namespace HotelReservations.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel()
        {
            CurrentViewModel = new ReservationsListViewModel();
        }
    } 

}