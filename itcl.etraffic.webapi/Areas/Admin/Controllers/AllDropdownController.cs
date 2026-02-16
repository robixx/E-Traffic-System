using itcl.etraffic.application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace itcl.etraffic.webapi.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("api/[Area]/[controller]")]
    [ApiController]
    public class AllDropdownController : Controller
    {
        private readonly IDropDown _dropdown;

        public AllDropdownController(IDropDown dropdown)
        {
            _dropdown = dropdown;
        }


        [HttpGet("get-brtadata")]
        public async Task<IActionResult> getBrtaData()
        {

            var result = await _dropdown.getBrtaDataAsync();
            return Ok(new
            {
                Status = result.Status,
                Message = result.Message,
                data = result.datalist
            });
        }

        [HttpGet("get-series")]
        public async Task<IActionResult> getSeriesData()
        {

            var result = await _dropdown.getSeriesDataAsync();
            return Ok(new
            {
                Status = result.Status,
                Message = result.Message,
                data = result.datalist
            });
        }


        [HttpGet("get-serialtype")]
        public async Task<IActionResult> getSerialNoTypeData()
        {

            var result = await _dropdown.getSerialNoTypeAsync();
            return Ok(new
            {
                Status = result.Status,
                Message = result.Message,
                data = result.datalist
            });
        }



        [HttpGet("get-documentserized")]
        public async Task<IActionResult> getDocumentSerized()
        {

            var result = await _dropdown.getDocuSeizedAsync();
            return Ok(new
            {
                Status = result.Status,
                Message = result.Message,
                data = result.datalist
            });
        }

        [HttpGet("get-procecutor")]
        public async Task<IActionResult> getProcecutorData()
        {

            var result = await _dropdown.getProcecutorAsync();
            return Ok(new
            {
                Status = result.Status,
                Message = result.Message,
                data = result.datalist
            });
        }


        [HttpGet("get-division-wise-procecutor")]
        public async Task<IActionResult> getDivisionWiseUser(int userId)
        {

            var result = await _dropdown.getDivisionWiseUserAsync(userId);
            return Ok(new
            {
                Status = result.Status,
                Message = result.Message,
                data = result.datalist
            });
        }
    }
}
