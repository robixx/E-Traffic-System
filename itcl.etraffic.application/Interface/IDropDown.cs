using itcl.etraffic.application.ViewDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itcl.etraffic.application.Interface
{
    public interface IDropDown
    {
        Task<(string Message, bool Status, List<DropDown>datalist)> getBrtaDataAsync();
        Task<(string Message, bool Status, List<DropDown>datalist)> getSeriesDataAsync();
        Task<(string Message, bool Status, List<DropDown>datalist)> getSerialNoTypeAsync();
        Task<(string Message, bool Status, List<DropDown>datalist)> getDocuSeizedAsync();
        Task<(string Message, bool Status, List<DropDown>datalist)> getProcecutorAsync();
        Task<(string Message, bool Status, List<DropDown>datalist)> getDivisionWiseUserAsync(int userId);
        
    }
}
