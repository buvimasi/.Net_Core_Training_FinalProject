using FinalProjectAPI.Data;
using FinalProjectAPI.IServices;
using FinalProjectAPI.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectAPI.Services
{
    public class EmployeeServices : IEmployeeService
    {
        private readonly EmployeeDbContext _dbContext;

        public EmployeeServices(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<EmployeeDto>> GetAllEmployees()
        {
            var employees = await _dbContext.Employees.Include(s => s.SkillMaps).ThenInclude(s => s.Skills).Where(s=>s.LockStatus == "not_requested").Select(x => new EmployeeDto
            {
                EmployeeID = x.EmployeeID,
                Email = x.Email,
                Name = x.Name,
                Manager = x.Manager,
                Experience = x.Experience,
                Wfm_Manager = x.Wfm_Manager,
                Skills = x.SkillMaps.Select(y => y.Skills.Name).ToList()
            }).ToListAsync();

            return employees;
        }
    }
}
