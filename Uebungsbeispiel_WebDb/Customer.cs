using System;
using System.Collections.Generic;

#nullable disable

namespace Uebungsbeispiel_WebDb
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public long Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
