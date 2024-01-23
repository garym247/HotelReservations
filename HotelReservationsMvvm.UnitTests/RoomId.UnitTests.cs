namespace HotelReservationsMvvm.UnitTests;

using HotelReservations.Models;

public class RoomIdUnitTests
{
    [Fact]
    public void ConstructorTest()
    {
        RoomId roomId = new RoomId(1, 2);

        roomId.FloorNumber.Should().Be(1);
        roomId.RoomNumber.Should().Be(2);
    }
}