using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTravelGem.Models
{
    internal class Booking
    {
        public int Id { get; set; }
        public String FirstName { get; set; }   
        public String LastName { get; set; }    
        public String Email { get; set; }   
        public DateTime Created { get; set; }
        public DateTime ReservationDateTime { get; set; }
        public String PhoneNumber { get; set; }
        public int NumberOfGuest { get; set; }
        public String SpecialRequirements { get; set; }
    }
}
