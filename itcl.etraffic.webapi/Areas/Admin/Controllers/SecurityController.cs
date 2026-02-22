using itcl.etraffic.application.Interface;
using itcl.etraffic.domain.Entity;
using Microsoft.AspNetCore.Mvc;

namespace itcl.etraffic.webapi.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("api/[Area]/[controller]")]
    [ApiController]
    public class SecurityController : Controller
    {

        private readonly IAuth _auth;

        public SecurityController(IAuth auth)
        {
            _auth = auth;
        }


        [HttpGet("get-roledata")]
        public async Task<IActionResult> GetRoleData()
        {
            var result = await _auth.getRoleDataAsync();
            return Ok(new
            {
                Status = result.Status,
                Message = result.Message,
                data = result.rolelist
            });
        }
    }
}
