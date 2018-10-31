using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class HotelRoom
    {
        [Required]
        [Display(Name = "Hotel ID")]
        public int HotelID { get; set; }

        [Required]
        [Display(Name = "Room Number")]
        [Range(1, 1000, ErrorMessage = "Your room number is not accepted")]
        public int RoomNumber { get; set; }

        [Required]
        [Display(Name = "Room ID")]
        public int RoomID { get; set; }

        [Required]
        [Display(Name = "Room Rate")]
        public decimal Rate { get; set; }

        [Required]
        [Display(Name = "Pet Friendly")]
        public bool PetFriendly { get; set; }

        public Hotel Hotel { get; set; }
        public Room Room { get; set; }
    }
}
