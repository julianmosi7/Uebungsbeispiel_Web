using System;
using System.Collections.Generic;

#nullable disable

namespace Uebungsbeispiel_WebDb
{
    public partial class Location
    {
        public long Id { get; set; }
        public long PostalCode { get; set; }
        public string StreetName { get; set; }
        public long HouseNumber { get; set; }
        public long? CityId { get; set; }

        public virtual City City { get; set; }
    }
}
