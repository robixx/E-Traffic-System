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
    }
}
