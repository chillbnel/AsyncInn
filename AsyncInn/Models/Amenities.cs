using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class Amenities
    {
        [Required]
        [Display(Name = "Amenity ID")]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Amenity Name")]
        [StringLength(20, ErrorMessage = "20 characters or less required")]
        public string Name { get; set; }

        public HotelRoom HotelRoom { get; set; }
    }
}
