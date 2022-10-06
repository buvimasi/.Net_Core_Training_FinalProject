using FinalProjectAPI.Helpers;
using FinalProjectAPI.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        /// <summary>
        /// Get All Employess Information
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public async Task<ActionResult> Employees()
        {
            try
            {

                var employeeList = await _employeeService.GetAllEmployees();
                return new OkObjectResult(employeeList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
    }
}
