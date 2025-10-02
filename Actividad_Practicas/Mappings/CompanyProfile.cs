using AutoMapper;
using CleanShop.Domain.Entities;
using CleanShop.Api.DTOs.Companies;

namespace CleanShop.Application.Mappings
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<Company, CompanyDto>();

            CreateMap<CreateCompanyDto, Company>()
                .ConstructUsing(dto => new Company(
                    dto.Name,
                    dto.UkNiu,
                    dto.Address,
                    dto.CityId,
                    dto.Email
                ));
        }
    }
}
