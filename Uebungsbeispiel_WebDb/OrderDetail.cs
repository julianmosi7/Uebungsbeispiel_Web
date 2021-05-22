using System;
using System.Collections.Generic;

#nullable disable

namespace Uebungsbeispiel_WebDb
{
    public partial class OrderDetail
    {
        public long Id { get; set; }
        public long CountProducts { get; set; }
        public long? ProductId { get; set; }
        public long? OrderId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
