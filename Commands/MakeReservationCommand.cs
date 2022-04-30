using HotelReservations.ViewModels;
using HotelReservations.Model;

namespace HotelReservations.Commands
{
    public class MakeReservationCommand : CommandBase
    {
        private MakeReservationViewModel viewModel;
        private Hotel hotel;

        public MakeReservationCommand(MakeReservationViewModel viewModel, Hotel hotel)
        {
            this.viewModel = viewModel;
            this.hotel = hotel;
        }
        public override void Execute(object parameter)
        {
        }
    }

}