using System.ComponentModel;
using HotelReservations.Model;
using HotelReservations.ViewModels;
namespace HotelReservations.Commands
{
    public class SubmitReservationCommand : CommandBase
    {
        private MakeReservationViewModel viewModel;
        private Hotel hotel;

       public SubmitReservationCommand(MakeReservationViewModel viewModel, Hotel hotel)
        {
            this.viewModel = viewModel;
            this.hotel = hotel;

            this.viewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(MakeReservationViewModel.Name))
            {
                OnCanExecuteChanged();
            }
        }

        public override bool CanExecute(object parameter)
        {
            return !string.IsNullOrEmpty(viewModel.Name) && base.CanExecute(parameter);
        }

        public override void Execute(object param)
        {
            Reservation reservation = new Reservation(
                new RoomID(1, viewModel.RoomNumber), 
                viewModel.Name, 
                viewModel.StartDate,
                viewModel.EndDate);

            hotel.AddReservation(reservation);
        }
    }
}