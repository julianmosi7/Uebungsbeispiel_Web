using System;
using System.Collections.Generic;

#nullable disable

namespace Uebungsbeispiel_WebDb
{
    public partial class Supplier
    {
        public Supplier()
        {
            Orders = new HashSet<Order>();
        }

        public long Id { get; set; }
        public string CompanyName { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
