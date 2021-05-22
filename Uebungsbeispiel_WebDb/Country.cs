using System;
using System.Collections.Generic;

#nullable disable

namespace Uebungsbeispiel_WebDb
{
    public partial class Country
    {
        public Country()
        {
            Cities = new HashSet<City>();
        }

        public long Id { get; set; }
        public string CountryName { get; set; }
        public string ShortName { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
