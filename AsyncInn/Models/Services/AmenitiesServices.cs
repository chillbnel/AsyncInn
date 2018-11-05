using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class AmenitiesServices : IAmenities
    {
        private AsyncInnDbContext _context;

        public AmenitiesServices(AsyncInnDbContext context)
        {
            _context = context;
        }

        public async Task CreateAmenity(Amenities amenity)
        {
            _context.Amenities.Add(amenity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAmenity(int id)
        {
            var amenity = await GetAmenities(id);
            _context.Amenities.Remove(amenity);
            await _context.SaveChangesAsync();
        }

        public async Task<Amenities> GetAmenities(int? id)
        {
            return await _context.Amenities
                .FirstOrDefaultAsync(m => m.ID == id);
        }

        public async Task<List<Amenities>> GetAmenity()
        {
            return await _context.Amenities.ToListAsync();
        }

        public async Task UpdateAmenity(Amenities amenity)
        {
            _context.Amenities.Update(amenity);
            await _context.SaveChangesAsync();
        }
    }
}
