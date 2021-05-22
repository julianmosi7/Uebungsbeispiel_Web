using System;
using System.Collections.Generic;

#nullable disable

namespace Uebungsbeispiel_WebDb
{
    public partial class City
    {
        public City()
        {
            Locations = new HashSet<Location>();
        }

        public long Id { get; set; }
        public string CityName { get; set; }
        public long? CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }
}
