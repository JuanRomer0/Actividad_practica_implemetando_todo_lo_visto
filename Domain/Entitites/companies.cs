using System;
using System.Collections.Generic;

namespace CleanShop.Domain.Entities
{
    public class Company
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string Description { get; private set; } = null!;
        public virtual ICollection<Branch> Branches { get; set; } = new HashSet<Branch>();

        public Company() { }

        public Company(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
