using System;
using System.ComponentModel;
using System.Windows.Input;

namespace HotelReservations.ViewModels
{
    public class MakeReservationViewModel : ViewModelBase
    {
        
        #region Binding_Properties

        private string name;
        public string Name
        {
            get 
            { 
                return name; 
            }
            set 
            { 
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        
        private int roomNumber;
        public int RoomNumber
        {
            get 
            { 
                return roomNumber;
            }
            set
            {
                roomNumber = value;
                OnPropertyChanged(nameof(RoomNumber));
            }

        }
        
        private int floorNumber;
        public int FloorNumber
        {
            get 
            {
                return floorNumber;
            }
            set
            {
                floorNumber = value;
                OnPropertyChanged(nameof(FloorNumber));
            }
        }

        private DateTime startDate;
        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                startDate = value;
                OnPropertyChanged(nameof(StartDate));
            }
        }
        
        private DateTime endDate;
        public DateTime EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                endDate = value;
                OnPropertyChanged(nameof(EndDate));
            }
        }
        #endregion
        
        #region Commands
        public ICommand SubmitCommand { get; }

        public ICommand CancelCommand { get; }
        
        #endregion  // Commands

        public MakeReservationViewModel()
        {
            
        }
    }

}