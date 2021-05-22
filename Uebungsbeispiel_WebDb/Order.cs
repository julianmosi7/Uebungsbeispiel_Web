using System;
using System.Collections.Generic;

#nullable disable

namespace Uebungsbeispiel_WebDb
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public long Id { get; set; }
        public long? CustomerId { get; set; }
        public long? EmployeeId { get; set; }
        public long? SupplierId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
