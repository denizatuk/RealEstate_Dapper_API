using Dapper;
using RealEstate_Dapper_API.Dtos.PropertyDtos;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.PropertyRepository
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly Context _context;

        public PropertyRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultPropertyDto>> GetAllPropertyAsync()
        {
            string query = "Select * From Property";
            using(var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPropertyDto>(query);
                return values.ToList();
            }
            
        }
    }
}
