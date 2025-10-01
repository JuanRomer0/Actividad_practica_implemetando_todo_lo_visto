using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanShop.Domain.Entities
{
    public class Countries
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string Code { get; private set; } = null!;
        public virtual ICollection<Regions> Regions { get; set; } = new HashSet<Regions>();

        public Countries() { }

        public Countries(string name, string code)
        {
            Name = name;
            Code = code;
        }
    }
}
