using System;
using System.Collections.Generic;

namespace CleanShop.Domain.Entities
{
    public class Region
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; } = null!;
        public Guid CountryId { get; private set; }

        public virtual Country Country { get; private set; } = null!;
        public virtual ICollection<City> Cities { get; private set; } = new HashSet<City>();

        public Region() { }

        public Region(string name, Guid countryId)
        {
            Id = Guid.NewGuid();
            Name = name;
            CountryId = countryId;
        }
    }
}
