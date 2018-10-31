using AsyncInn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data
{
    public class AsyncInnDbContext : DbContext
    {
        public AsyncInnDbContext(DbContextOptions<AsyncInnDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HotelRoom>().HasKey(hr => new { hr.HotelID, hr.RoomNumber });

            modelBuilder.Entity<RoomAmenities>().HasKey(ra => new { ra.AmenitiesID, ra.RoomID });

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    ID = 1,
                    Name = "Downtown Seattle",
                    Address = "1234 Fake Street, Seattle, WA 98122",
                    Phone = "206-777-5555"
                },

                new Hotel
                {
                    ID = 2,
                    Name = "West Seattle",
                    Address = "555 55th Place, Seattle, WA 98101",
                    Phone = "206-777-5555"
                },

                new Hotel
                {
                    ID = 2,
                    Name = "West Seattle",
                    Address = "555 55th Place, Seattle, WA 98101",
                    Phone = "206-777-5555"
                }
            );
        }

        public DbSet<Amenities> Amenities { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }

    }
}
