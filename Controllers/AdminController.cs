using Microsoft.AspNetCore.Mvc;
using SwiftEd.Dtos;
using SwiftEd.Interface.Services;

namespace SwiftEd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController :ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        [HttpPost("CreateAdmin")]
        public IActionResult   Create([FromBody] CreateAdminRequestModel model)
        {
            var result = _adminService.CreateAdmin(model);
            return Ok(result);
        }
    }
}