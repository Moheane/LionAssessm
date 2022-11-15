using API.Backend.Models;

using API.Backend.ServiceLayer;
using Microsoft.AspNetCore.Mvc;


namespace API.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LeaveController : ControllerBase
    {
        private readonly IServiceLayer _serviceLayer;
        public LeaveController(IServiceLayer serviceLayer)
        {
            _serviceLayer = serviceLayer;
            
        }
        [HttpGet("Leaves")]

        public Task<List<EmployeeLeave>> Get()
        {
            return _serviceLayer.GetLeaves();
        }

        [HttpPost("Leaves/add")]
        public async Task<IActionResult> Post([FromBody] EmployeeLeave data)
        {
            await _serviceLayer.AddLeave(data);

            return StatusCode(200);
        }
    }
}
