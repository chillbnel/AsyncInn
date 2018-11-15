using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class RoomServices : IRoom
    {
        private AsyncInnDbContext _context;

        public RoomServices(AsyncInnDbContext context)
        {
            _context = context;
        }

        public async Task CreateRoom(Room room)
        {
            _context.Add(room);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRoom(int id)
        {
            var room = await GetRoom(id);
            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();
        }

        public HotelRoom GetHotelRoomByRoomType(int RoomID)
        {
            var hotelRoom = _context.HotelRooms
                .Where(x => x.RoomID == RoomID)
                .Include(h => h.Hotel)
                .Include(r => r.Room).FirstOrDefault();
            return hotelRoom;
        }

        public async Task<Room> GetRoom(int? id)
        {
            return await _context.Rooms
                     .FirstOrDefaultAsync(m => m.ID == id);
        }

        public RoomAmenities GetRoomAmenitiesByRoomType(int RoomID, int AmenitiesID)
        {
            var roomAmenities = _context.RoomAmenities
                .Where(x => x.RoomID == RoomID && x.AmenitiesID == AmenitiesID)
                .Include(a => a.Amenities)
                .Include(r => r.Room).FirstOrDefault();
            return roomAmenities;
        }

        public async Task<List<Room>> GetRooms()
        {
            return await _context.Rooms.ToListAsync();
        }

        public async Task UpdateRoom(Room room)
        {
            _context.Update(room);
            await _context.SaveChangesAsync();
        }
    }
}
