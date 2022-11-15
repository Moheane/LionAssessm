
using API.Backend.Models;

namespace API.Backend.Repo
{
    public interface IRepo
    {
        public Task<List<EmployeeLeave>> GetLeaves();
        public Task<bool> AddLeave(EmployeeLeave emp);

    }
}
