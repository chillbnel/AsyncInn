using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IRoom
    {
        //Creating
        Task CreateRoom(Room room);

        //Updating
        Task UpdateRoom(Room room);

        //Deleting
        Task DeleteRoom(int id);

        //Reading
        Task<List<Room>> GetRooms();
        Task<Room> GetRoom(int? id);

        HotelRoom GetHotelRoomByRoomType(int RoomID);
        RoomAmenities GetRoomAmenitiesByRoomType(int RoomID, int AmenitiesID);
    }
}
