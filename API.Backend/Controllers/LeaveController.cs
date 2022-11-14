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
    }
}
