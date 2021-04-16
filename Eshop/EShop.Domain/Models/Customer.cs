using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Models
{
    public class Customer 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Ssn { get; set; }
        public string PhotoUrl { get; set; }
        internal ICollection<ContactDetails> ContactDetails { get; }
        public string Username { get; set; }

}
}
