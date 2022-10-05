using FinalProjectAPI.Helpers;
using FinalProjectAPI.IServices;
using FinalProjectAPI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        /// <summary>
        /// Authenticate method
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>

        [HttpGet("authenticate")]
        public IActionResult Authenticate([FromQuery] AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }


        ///// <summary>
        ///// Get User List
        ///// </summary>
        ///// <returns></returns>
        //[Authorize]
        //[HttpGet]
        //public IActionResult GetUser()
        //{
        //    try
        //    {
        //        var userlist = _userService.GetUser();

        //        return new OkObjectResult(userlist);
        //    }
        //    catch (Exception ex)

        //    {
        //        return StatusCode(500, ex.Message);
        //    }
        //}
    }
}
