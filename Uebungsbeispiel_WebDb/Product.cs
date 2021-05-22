using System;
using System.Collections.Generic;

#nullable disable

namespace Uebungsbeispiel_WebDb
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public long Id { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public long InStock { get; set; }
        public long? CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
