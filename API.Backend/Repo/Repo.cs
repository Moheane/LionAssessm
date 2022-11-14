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

        public async Task<bool> AddLeave(EmployeeLeave emp)
        {
            await _EmployeeContext.EmployeeLeaves.AddAsync(emp);
            await _EmployeeContext.SaveChangesAsync();

            return true;
        }
    }
}
