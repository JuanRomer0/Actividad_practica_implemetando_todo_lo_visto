using System;
using System.Collections.Generic;

namespace CleanShop.Domain.Entities
{
    public class Company
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string UkNiu { get; private set; } = null!; // Identificador único
        public string Address { get; private set; } = null!;
        public Guid CityId { get; private set; }
        public string Email { get; private set; } = null!;

        public virtual City City { get; private set; } = null!;
        public virtual ICollection<Branch> Branches { get; private set; } = new HashSet<Branch>();

        public Company() { }

        public Company(string name, string ukNiu, string address, Guid cityId, string email)
        {
            Id = Guid.NewGuid();
            Name = name;
            UkNiu = ukNiu;
            Address = address;
            CityId = cityId;
            Email = email;
        }
    }
}
