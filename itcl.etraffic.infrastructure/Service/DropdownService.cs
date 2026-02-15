using itcl.etraffic.application.Interface;
using itcl.etraffic.application.ViewDto;
using itcl.etraffic.persistance.DataConnection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itcl.etraffic.infrastructure.Service
{
    public class DropdownService : IDropDown
    {

        private readonly DMPDBContext _dmpdbcontext;

        public DropdownService(DMPDBContext dmpdbcontext)
        {
            _dmpdbcontext = dmpdbcontext;
        }
        public async Task<(string Message, bool Status, List<DropDown> datalist)> getBrtaDataAsync()
        {
            try
            {
                var Brtadata = await _dmpdbcontext.Vehicleregistration
                    .Where(i => i.Isremoved == 0)
                    .Select(i => new DropDown
                    {
                        Id = i.IId,
                        Name = i.Code,

                    }).ToListAsync();

                return ("Data Retrieved Successfully.", true, Brtadata);

            }catch(Exception ex)
            {
                string actionName = $"{nameof(DropdownService)}.{nameof(getBrtaDataAsync)}";
                return ($"{actionName} : {ex.Message}", false, new List<DropDown>());
            }
        }

        public async Task<(string Message, bool Status, List<DropDown> datalist)> getDivisionWiseUserAsync( int UserId)
        {
            try
            {
                var divisionData = await (from m in _dmpdbcontext.V2_Division_Filter_ForUser

                                          join n in _dmpdbcontext.Division on m.DivisionId equals n.IId

                                          where m.UserId == UserId && m.IsActive == 0
                                          select new DropDown
                                          {
                                              Id =Convert.ToInt32(n.IId),
                                              Name = n.Name,
                                          }
                                        ).ToListAsync();

                return ("Data Retrieved Successfully.", true, divisionData);
            }
            catch(Exception ex)
            {
                string actionName = $"{nameof(DropdownService)}.{nameof(getDivisionWiseUserAsync)}";
                return ($"{actionName} : {ex.Message}", false, new List<DropDown>());
            }
        }

        public async Task<(string Message, bool Status, List<DropDown> datalist)> getDocuSeizedAsync()
        {
            try
            {
                var serialTYpe = await _dmpdbcontext.DocumentSeized
                    .Where(i => i.IsRemoved == 0)
                    .Select(i => new DropDown
                    {
                        Id = i.IId,
                        Name = i.ShortName,

                    }).ToListAsync();

                return ("Data Retrieved Successfully.", true, serialTYpe);

            }
            catch (Exception ex)
            {
                string actionName = $"{nameof(DropdownService)}.{nameof(getDocuSeizedAsync)}";
                return ($"{actionName} : {ex.Message}", false, new List<DropDown>());
            }
        }

        public async Task<(string Message, bool Status, List<DropDown> datalist)> getProcecutorAsync()
        {
            try
            {
                var serialTYpe = await _dmpdbcontext.Sergeant
                    .Where(i => i.IsRemoved == 0)
                    .Select(i => new DropDown
                    {
                        Id =Convert.ToInt32(i.IId),
                        Name = i.Name,

                    }).ToListAsync();

                return ("Data Retrieved Successfully.", true, serialTYpe);

            }
            catch (Exception ex)
            {
                string actionName = $"{nameof(DropdownService)}.{nameof(getProcecutorAsync)}";
                return ($"{actionName} : {ex.Message}", false, new List<DropDown>());
            }
        }

        public async Task<(string Message, bool Status, List<DropDown> datalist)> getSerialNoTypeAsync()
        {
            try
            {
                var serialTYpe = await _dmpdbcontext.SerialNoType
                    .Where(i => i.Isremoved == 0)
                    .Select(i => new DropDown
                    {
                        Id = i.IId,
                        Name = i.Name,

                    }).ToListAsync();

                return ("Data Retrieved Successfully.", true, serialTYpe);

            }
            catch (Exception ex)
            {
                string actionName = $"{nameof(DropdownService)}.{nameof(getSerialNoTypeAsync)}";
                return ($"{actionName} : {ex.Message}", false, new List<DropDown>());
            }
        }

        public async Task<(string Message, bool Status, List<DropDown> datalist)> getSeriesDataAsync()
        {
            try
            {
                var seriesdata = await _dmpdbcontext.VehicleSeriesNo
                    .Where(i => i.Isremoved == 0)
                    .Select(i => new DropDown
                    {
                        Id = i.IId,
                        Name = i.Code +"(" + i.Banglacode + ")",

                    }).ToListAsync();

                return ("Data Retrieved Successfully.", true, seriesdata);

            }
            catch (Exception ex)
            {
                string actionName = $"{nameof(DropdownService)}.{nameof(getSeriesDataAsync)}";
                return ($"{actionName} : {ex.Message}", false, new List<DropDown>());
            }
        }
    }
}
