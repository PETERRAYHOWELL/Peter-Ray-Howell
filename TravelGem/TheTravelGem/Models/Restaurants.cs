using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTravelGem.Models
{
    internal class Restaurants
    {
        public int RestaurantID { get; set; }   
        public String Name { get; set; }
        public String PhoneNubmer { get; set; }
        public String Address { get; set; }
        public String Email { get; set; }
        public String WorkHoursWeekDays { get; set; }
        public String WorkHoursSunday { get; set; }
        public String Information { get; set; }
    }
}
