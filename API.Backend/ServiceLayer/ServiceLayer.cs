using API.Backend.Models;
using API.Backend.Repo;

namespace API.Backend.ServiceLayer
{
    public class ServiceLayer : IServiceLayer
    {
        private readonly IRepo _repo;
        public ServiceLayer(IRepo repo)
        {
            _repo = repo;
        }
        public Task<List<EmployeeLeave>> GetLeaves()
        {
            return _repo.GetLeaves();
        }

        public async Task<bool> AddLeave(EmployeeLeave emp)
        {
            await _repo.AddLeave(emp);
            return true;
        }
    }
}
