using System;
using System.Collections.Generic;

namespace CleanShop.Domain.Entities
{
    public class Country
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; } = null!;

        public virtual ICollection<Region> Regions { get; private set; } = new HashSet<Region>();

        public Country() { }

        public Country(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}

