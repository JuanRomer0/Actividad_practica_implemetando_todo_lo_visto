using System;

namespace CleanShop.Domain.Entities
{
    public class Branch
    {
        public Guid Id { get; private set; }
        public string NumberComercial { get; private set; } = null!;
        public string Address { get; private set; } = null!;
        public string Email { get; private set; } = null!;
        public string ContactName { get; private set; } = null!;
        public string Phone { get; private set; } = null!;
        public Guid CityId { get; private set; }
        public Guid CompanyId { get; private set; }

        public virtual City City { get; private set; } = null!;
        public virtual Company Company { get; private set; } = null!;

        public Branch() { }

        public Branch(string numberComercial, string address, string email, string contactName, string phone, Guid cityId, Guid companyId)
        {
            Id = Guid.NewGuid();
            NumberComercial = numberComercial;
            Address = address;
            Email = email;
            ContactName = contactName;
            Phone = phone;
            CityId = cityId;
            CompanyId = companyId;
        }
    }
}
