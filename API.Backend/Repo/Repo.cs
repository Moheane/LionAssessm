using API.Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Backend.Repo
{
    public class Repo : IRepo
    {
        private readonly EmployeeContext _EmployeeContext;

        public Repo(EmployeeContext employeeContext)
        {
            _EmployeeContext = employeeContext; 

        }
        public async Task<List<EmployeeLeave>> GetLeaves()
        {
            var results = await _EmployeeContext.EmployeeLeaves.ToListAsync();
            return results;
        }
    }
}
