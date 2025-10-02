namespace CleanShop.Api.DTOs.Branches;

public record BranchDto(Guid Id,string NumberComercial,string Address,string Email,string ContactName,string Phone,Guid CityId,Guid CompanyId);
