using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IAmenities
    {
        //Creating
        Task CreateAmenity(Amenities amenity);

        //Updating
        Task UpdateAmenity(Amenities amenity);

        //Deleting
        Task DeleteAmenity(int id);

        //Reading
        Task<List<Amenities>> GetAmenity();
        Task<Amenities> GetAmenities(int? id);
    }
}
