using itcl.etraffic.application.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace itcl.etraffic.webapi.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("api/[Area]/[controller]")]
    [ApiController]
    public class ProsecutionController : ControllerBase
    {

        private readonly IDropDown _dropdown;

        public ProsecutionController(IDropDown dropdown)
        {
            _dropdown = dropdown;
        }


        [HttpGet("get-brtadata")]
        public async Task<IActionResult>getBrtaData()
        {

            var result= await _dropdown.getBrtaDataAsync();
            return Ok(new
            {
                Status=result.Status,
                Message= result.Message,
                data=result.datalist
            });
        }
    }
}
