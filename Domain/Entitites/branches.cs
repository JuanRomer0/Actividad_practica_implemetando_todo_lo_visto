using System;

namespace CleanShop.Domain.Entities
{
    public class Branch
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string Address { get; private set; } = null!;
        public int CityId { get; private set; }
        public virtual Cities Cities { get; private set; } = null!;
        public int CompanyId { get; private set; }
        public virtual Company Company { get; private set; } = null!;

        public Branch() { }

        public Branch(string name, string address, int cityId, int companyId)
        {
            Name = name;
            Address = address;
            CityId = cityId;
            CompanyId = companyId;
        }
    }
}
