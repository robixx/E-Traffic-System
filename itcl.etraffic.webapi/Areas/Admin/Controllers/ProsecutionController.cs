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

        private readonly IProsecution _prosecution;

        public ProsecutionController(IProsecution prosecution)
        {
           _prosecution = prosecution;
        }


        [HttpGet("get-prosecutor-coments")]
        public async Task<IActionResult>getBrtaData()
        {

            var result= await _prosecution.getProsecutionCommentAsync();
            return Ok(new
            {
                Status=result.Status,
                Message= result.Message,
                data=result.Comment
            });
        }

        
    }
}
