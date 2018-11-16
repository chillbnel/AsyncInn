using AsyncInn.Data;
using AsyncInn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;


namespace XUnitTestAsyncInn
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests Amenities Get
        /// </summary>
        [Fact]
        public void AmenitiesGet()
        {
            Amenities amenityGet = new Amenities();
            amenityGet.Name = "Jeff";

            Assert.Equal("Jeff", amenityGet.Name);
        }

        /// <summary>
        /// Tests Amenitites Set
        /// </summary>
        [Fact]
        public void AmenitiesSet()
        {
            Amenities amenitySet = new Amenities();
            amenitySet.Name = "Jeff";

            amenitySet.Name = "Is a stud";

            Assert.Equal("Is a stud", amenitySet.Name);
        }

        /// <summary>
        /// Tests HotelRoom Get
        /// </summary>
        [Fact]
        public void HotelRoomGet()
        {
            HotelRoom hotelRoomGet = new HotelRoom();
            hotelRoomGet.RoomNumber = 666;

            Assert.Equal(666, hotelRoomGet.RoomNumber);
        }

        /// <summary>
        /// Tests HotelRoom Set
        /// </summary>
        [Fact]
        public void HotelRoomSet()
        {
            HotelRoom hotelRoom = new HotelRoom();
            hotelRoom.RoomNumber = 666;

            hotelRoom.RoomNumber = 187;

            Assert.Equal(187, hotelRoom.RoomNumber);
        }

        /// <summary>
        /// Tests Hotel Get
        /// </summary>
        [Fact]
        public void HotelGet()
        {
            Hotel hotelSet = new Hotel();
            hotelSet.Name = "Fallout 4 ate 3 months of my life";

            Assert.Equal("Fallout 4 ate 3 months of my life", hotelSet.Name);
        }

        /// <summary>
        ///Tests Hotel Set
        /// </summary>
        [Fact]
        public void HotelSet()
        {
            Hotel hotelSet = new Hotel();
            hotelSet.Name = "Aliens";

            hotelSet.Name = "Is better than Alien";

            Assert.Equal("Is better than Alien", hotelSet.Name);
        }

        /// <summary>
        ///Tests RoomAmenities Get
        /// </summary>
        [Fact]
        public void RoomAmenitiesGet()
        {
            RoomAmenities roomAmenityGet = new RoomAmenities();
            Amenities amenityGet = new Amenities();
            roomAmenityGet.Amenities = amenityGet;
            amenityGet.Name = "Basketball Court";

            Assert.Equal("Basketball Court", roomAmenityGet.Amenities.Name);
        }

        /// <summary>
        ///Tests RoomAmenities Set
        /// </summary>
        [Fact]
        public void RoomAmenitiesSet()
        {
            RoomAmenities roomAmenitySet = new RoomAmenities();
            Amenities amenitySet = new Amenities();
            roomAmenitySet.Amenities = amenitySet;
            amenitySet.Name = "Some crappy thing no one wants";

            amenitySet.Name = "Probably something badass that everyone will pay an extra $100 for";

            Assert.Equal("Probably something badass that everyone will pay an extra $100 for", roomAmenitySet.Amenities.Name);
        }

        /// <summary>
        /// Tests Room Get
        /// </summary>
        [Fact]
        public void RoomGet()
        {
            Room roomGet = new Room();
            roomGet.Name = "This better have a king bed in it";

            Assert.Equal("This better have a king bed in it", roomGet.Name);
        }

        /// <summary>
        /// Tests Room Set
        /// </summary>
        [Fact]
        public void RoomSet()
        {
            Room roomSet = new Room();
            roomSet.Name = "Love Shack";

            roomSet.Name = "Ultimate Pleasure Pad";

            Assert.Equal("Ultimate Pleasure Pad", roomSet.Name);
        }



        /// <summary>
        /// Tests the Hotel table Create/Read operations
        /// </summary>
        [Fact]
        public async void CreateReadHotel()
        {
            DbContextOptions<AsyncInnDbContext> options = new DbContextOptionsBuilder<AsyncInnDbContext>()
                .UseInMemoryDatabase("CreateHotel")
                .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Hotel hotelCreate = new Hotel();
                hotelCreate.Name = "Jeff's Discount Hourly Rooms";

                context.Hotels.Add(hotelCreate);
                context.SaveChanges();

                var wasHotelCreated = await context.Hotels.FirstOrDefaultAsync(x => x.Name == hotelCreate.Name);

                Assert.Equal("Jeff's Discount Hourly Rooms", wasHotelCreated.Name);
            }

        }

        /// <summary>
        /// Tests the Hotel Table Update operation
        /// </summary>
        [Fact]
        public async void UpdateHotel()
        {
            DbContextOptions<AsyncInnDbContext> options =
                new DbContextOptionsBuilder<AsyncInnDbContext>()
                .UseInMemoryDatabase("CreateHotel")
                .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Hotel hotelCreate = new Hotel();
                hotelCreate.Name = "Sort a Good Hotel";

                context.Hotels.Add(hotelCreate);
                context.SaveChanges();

                hotelCreate.Name = "Now a Really Good Hotel";

                context.Hotels.Update(hotelCreate);
                context.SaveChanges();

                var hotelWasUpdated = await context.Hotels.FirstOrDefaultAsync(x => x.Name == hotelCreate.Name);

                Assert.Equal("Now a Really Good Hotel", hotelWasUpdated.Name);
            }
        }

        /// <summary>
        /// Tests the Hotel Table Delete operation
        /// </summary>
        [Fact]
        public async void DeleteHotel()
        {
            DbContextOptions<AsyncInnDbContext> options =
                new DbContextOptionsBuilder<AsyncInnDbContext>()
                .UseInMemoryDatabase("CreateHotel")
                .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Hotel hotelCreate = new Hotel();
                hotelCreate.Name = "Going Out of Business Inn";

                context.Hotels.Add(hotelCreate);
                context.SaveChanges();

                context.Hotels.Remove(hotelCreate);
                context.SaveChanges();

                var hotelListWithoutDeletedHotel = await context.Hotels.ToListAsync();

                Assert.DoesNotContain(hotelCreate, hotelListWithoutDeletedHotel);
            }
        }

        /// <summary>
        /// Tests Room Ammenities Table Create and Read operations
        /// </summary>
        [Fact]
        public async void CreateReadRoomAmenity()
        {
            DbContextOptions<AsyncInnDbContext> options =
                new DbContextOptionsBuilder<AsyncInnDbContext>()
                .UseInMemoryDatabase("CreateRA")
                .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Amenities amenityCreate = new Amenities();
                amenityCreate.Name = "High Pressure Bidet";

                RoomAmenities roomAmenity = new RoomAmenities();
                roomAmenity.Amenities = amenityCreate;

                context.RoomAmenities.Add(roomAmenity);
                context.SaveChanges();

                var amenityWasCreated = await context.RoomAmenities.FirstOrDefaultAsync(x => x.Amenities == amenityCreate);

                Assert.Contains("High Pressure Bidet", amenityWasCreated.Amenities.Name);
            }
        }

        /// <summary>
        /// Tests Room Amenities Table Delete operation
        /// </summary>
        [Fact]
        public async void DeleteRoomAmenity()
        {
            DbContextOptions<AsyncInnDbContext> options =
                new DbContextOptionsBuilder<AsyncInnDbContext>()
                .UseInMemoryDatabase("CreateRA")
                .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Amenities amenityCreate = new Amenities();
                amenityCreate.Name = "Moldy Floor Scent";

                RoomAmenities roomAmenity = new RoomAmenities();
                roomAmenity.Amenities = amenityCreate;

                context.RoomAmenities.Add(roomAmenity);
                context.SaveChanges();

                context.RoomAmenities.Remove(roomAmenity);
                context.SaveChanges();

                var roomAmenityListWithoutDeletedRoomAmenity = await context.RoomAmenities.ToListAsync();

                Assert.DoesNotContain(roomAmenity, roomAmenityListWithoutDeletedRoomAmenity);
            }
        }
    }

}
