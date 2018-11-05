using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IHotel
    {
        //Creating
        Task CreateHotel(Hotel hotel);

        //Updating
        Task UpdateHotel(Hotel hotel);

        //Deleting
        Task DeleteHotel(int id);

        //Reading
        Task<List<Hotel>> GetHotels();
        Task<Hotel> GetHotel(int? id);
    }
}

