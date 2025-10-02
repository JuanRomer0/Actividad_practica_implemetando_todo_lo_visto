using AutoMapper;
using CleanShop.Domain.Entities;
using CleanShop.Api.DTOs.Branches;

namespace CleanShop.Application.Mappings
{
    public class BranchProfile : Profile
    {
        public BranchProfile()
        {
            CreateMap<Branch, BranchDto>();

            CreateMap<CreateBranchDto, Branch>()
                .ConstructUsing(dto => new Branch(
                    dto.NumberComercial,
                    dto.Address,
                    dto.Email,
                    dto.ContactName,
                    dto.Phone,
                    dto.CityId,
                    dto.CompanyId
                ));
        }
    }
}
