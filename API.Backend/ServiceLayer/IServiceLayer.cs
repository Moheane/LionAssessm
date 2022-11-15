
using API.Backend.Models;

namespace API.Backend.ServiceLayer
{
    public interface IServiceLayer
    {
        public Task<List<EmployeeLeave>> GetLeaves();
        public Task<bool> AddLeave(EmployeeLeave emp);

    }
}
