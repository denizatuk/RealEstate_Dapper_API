using RealEstate_Dapper_API.Dtos.PropertyDtos;

namespace RealEstate_Dapper_API.Repositories.PropertyRepository
{
    public interface IPropertyRepository
    {
        Task<List<ResultPropertyDto>> GetAllPropertyAsync();
    }
}
