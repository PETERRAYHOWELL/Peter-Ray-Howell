using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTravelGem.Models
{
    internal class Payment
    {
        public int Id { get; set; }
        public String NameONCard { get; set; }
        public int CardNumber { get; set; }
        public DateTime ExpirationOfCard { get; set; }
        public int CVC { get; set; }   
        public DateTime Created { get; set; }
    }
}
