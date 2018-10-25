using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class Hotel
    {
        public int ID { get; set; }//assigns a key
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public HotelRoom HotelRoom { get; set; }
    }
}
