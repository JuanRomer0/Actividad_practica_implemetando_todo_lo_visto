namespace CleanShop.Api.DTOs.Companies;

public record CompanyDto(Guid Id,string Name,string UkNiu,string Address,Guid CityId,string Email);
