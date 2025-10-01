using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanShop.Domain.Entities
{
    public class Regions
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public virtual ICollection<Cities> Cities { get; set; } = new HashSet<Cities>();
        public int CountryId { get; private set; }
        public virtual Countries Countries { get; private set; } = null!;

        public Regions() { }

        public Regions(string name, int countryId)
        {
            Name = name;
            CountryId = countryId;
        }
    }
}
