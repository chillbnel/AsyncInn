using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class Hotel
    {
        [Required]
        [Display(Name = "Hotel ID")]
        public int ID { get; set; }//assigns a key

        [Required]
        [Display(Name = "Hotel Name")]
        [StringLength(15, ErrorMessage = "15 characters or less required")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Hotel Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Hotel Phone Number")]
        public string Phone { get; set; }

        public HotelRoom HotelRoom { get; set; }
    }
}
