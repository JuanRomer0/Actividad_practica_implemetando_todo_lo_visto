using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanShop.Domain.Entities
{
    public class Cities
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public int RegionId { get; private set; }
        public virtual Regions Regions { get; private set; } = null!;
        public virtual ICollection<Branch> Branches { get; set; } = new HashSet<Branch>();

        public Cities() { }

        public Cities(string name, int regionId)
        {
            Name = name;
            RegionId = regionId;
        }
    }
}
