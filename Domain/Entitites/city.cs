using System;
using System.Collections.Generic;

namespace CleanShop.Domain.Entities
{
    public class City
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; } = null!;
        public Guid RegionId { get; private set; }

        public virtual Region Region { get; private set; } = null!;
        public virtual ICollection<Branch> Branches { get; private set; } = new HashSet<Branch>();

        public City() { }

        public City(string name, Guid regionId)
        {
            Id = Guid.NewGuid();
            Name = name;
            RegionId = regionId;
        }
    }
}

