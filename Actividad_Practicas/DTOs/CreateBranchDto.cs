namespace CleanShop.Api.DTOs.Branches;

public record CreateBranchDto(string NumberComercial,string Address,string Email,string ContactName,string Phone,Guid CityId,Guid CompanyId);
