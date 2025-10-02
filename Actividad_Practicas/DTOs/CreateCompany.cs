namespace CleanShop.Api.DTOs.Companies;

public record CreateCompanyDto(string Name,string UkNiu,string Address,Guid CityId, string Email);
