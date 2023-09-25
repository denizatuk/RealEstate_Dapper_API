using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Repositories.PropertyRepository;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertiesController : ControllerBase
    {
        private readonly IPropertyRepository _propertyRepository;

        public PropertiesController(IPropertyRepository propertyRepository)
        {
            _propertyRepository = propertyRepository;
        }
        [HttpGet]
        public async Task<IActionResult> PropertyList()
        {
            var values = await _propertyRepository.GetAllPropertyAsync();
            return Ok(values);
        }
    }
}
