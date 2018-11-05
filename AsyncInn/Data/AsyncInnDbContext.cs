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
                    Phone = "206-666-5555"
                },

                new Hotel
                {
                    ID = 3,
                    Name = "Ballard",
                    Address = "111 Rodeo Drive, Seattle, WA 98105",
                    Phone = "206-888-5555"
                },

                new Hotel
                {
                    ID = 4,
                    Name = "Central District",
                    Address = "1526 29th Avenue, Seattle, WA 98122",
                    Phone = "206-739-9112"
                },

                new Hotel
                {
                    ID = 5,
                    Name = "Bothell",
                    Address = "200 200th Place SE, Bothell, WA 98012",
                    Phone = "425-487-9840"
                }
            );

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    ID = 1,
                    Name = "Hawks Nest",
                    Layout = Layout.Studio,
                },
                new Room
                {
                    ID = 2,
                    Name = "Sonics Court",
                    Layout = Layout.Studio
                },
                new Room
                {
                    ID = 3,
                    Name = "Husky Den",
                    Layout = Layout.OneBedroom
                },
                new Room
                {
                    ID = 4,
                    Name = "Sounders Club",
                    Layout = Layout.OneBedroom
                },
                new Room
                {
                    ID = 5,
                    Name = "Storms Court",
                    Layout = Layout.TwoBedroom
                },
                new Room
                {
                    ID = 6,
                    Name = "Dreamin' NHL",
                    Layout = Layout.TwoBedroom
                }
            );

            modelBuilder.Entity<Amenities>().HasData(
                new Amenities
                {
                    ID = 1,
                    Name = "Hot Tub"
                },
                new Amenities
                {
                    ID = 2,
                    Name = "Heart Shaped Pillows",
                },
                new Amenities
                {
                    ID = 3,
                    Name = "Rose Pedals"
                },
                new Amenities
                {
                    ID = 4,
                    Name = "Champange Dispensor"
                },
                new Amenities
                {
                    ID = 5,
                    Name = "Fluffy Handcuffs"
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
