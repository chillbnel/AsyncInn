﻿using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class HotelServices : IHotel
    {
        private AsyncInnDbContext _context;

        public HotelServices(AsyncInnDbContext context)
        {
            _context = context;
        }

        public async Task CreateHotel(Hotel hotel)
        {
            _context.Add(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteHotel(int id)
        {
            var hotel = await _context.Hotels.FindAsync(id);
            _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task<Hotel> GetHotel(int? id)
        {
            return await _context.Hotels
                .FirstOrDefaultAsync(m => m.ID == id);
        }

        public async Task<List<Hotel>> GetHotels()
        {
            return await _context.Hotels.ToListAsync();
        }

        public async Task UpdateHotel(Hotel hotel)
        {
            _context.Update(hotel);
            await _context.SaveChangesAsync();
        }
    }
}
