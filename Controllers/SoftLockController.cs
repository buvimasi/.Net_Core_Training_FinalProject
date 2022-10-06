using FinalProjectAPI.Helpers;
using FinalProjectAPI.IServices;
using FinalProjectAPI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SoftLockController : ControllerBase
    {
        private readonly ISoftLockService _softLockService;

        public SoftLockController(ISoftLockService softLockService)
        {
            _softLockService = softLockService;
        }

        /// <summary>
        /// Get List of SoftLock
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> GetSoftLock()
        {
            var softlock = await _softLockService.GetSoftLocks();
            return new OkObjectResult(softlock);
        }

        /// <summary>
        /// Add softlock
        /// </summary>
        /// <param name="softLockModel"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddSoftLock(SoftLockDto softLockModel)
        {
            try
            {
                var softlock = _softLockService.AddSoftLock(softLockModel);
                return new OkObjectResult(softlock);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Update softlock info
        /// </summary>
        /// <param name="id"></param>
        /// <param name="softLockModel"></param>
        /// <returns></returns>
        [HttpPut, Route("{id}")]
        public ActionResult UpdateSoftLock(int id, SoftLockDto softLockModel)
        {
            try
            {
                var softlock = _softLockService.UpdateSoftLockStatus(id, softLockModel);
                return new OkObjectResult(softlock);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
    }
}
