using System;

namespace HotelReservations.Model
{
    public class RoomID
    {
        public int FloorNumber { get; }
        public int RoomNumber { get; }

        public RoomID(int floorNumber, int roomNumber)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
        }

        public override string ToString()
        {
            return $"{FloorNumber}, {RoomNumber}";
        }

        public static bool operator ==(RoomID room, RoomID otherRoom)
        {
            if (room is null && otherRoom is null)
            {
                return true;
            }

            return !(room is null) && room.Equals(otherRoom);
        }

        public static bool operator !=(RoomID room, RoomID otherRooom)
        {
            return !(room == otherRooom);
        }

        public override bool Equals(object obj)
        {
            return obj is RoomID roomId && 
                FloorNumber == roomId.FloorNumber &&
                RoomNumber == roomId.RoomNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FloorNumber,RoomNumber);
        }

    }
}
