using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Models
{
    class ContactDetails 
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerIr { get; set; }
        public string PhotoUrl { get; set; }
    }
}
