using System;
using System.Runtime.Serialization;

namespace HotelReservations.Model
{
    class ReservationConflictException : Exception
    {
        public ReservationConflictException(Reservation newReservation, Reservation existingReservation)
        {
        }

        public ReservationConflictException(string message) : base(message)
        {
        }

        public ReservationConflictException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ReservationConflictException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}