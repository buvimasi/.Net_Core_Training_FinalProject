using FinalProjectAPI.ViewModels;
using System.Threading.Tasks;

namespace FinalProjectAPI.IServices
{
    public interface IEmployeeService
    {
        Task<List<EmployeeDto>> GetAllEmployees();
    }
}
