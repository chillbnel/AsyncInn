using AsyncInn.Data;
using AsyncInn.Models;
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
            HotelRoom hotelRoom= new HotelRoom();
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

    }


}
