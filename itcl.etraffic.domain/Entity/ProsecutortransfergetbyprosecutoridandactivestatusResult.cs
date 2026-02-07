using System;

namespace itcl.etraffic.domain.Entity
{
    public class ProsecutortransfergetbyprosecutoridandactivestatusResult
    {
        public long Iid { get; set; }
        public int Divisionid { get; set; }
        public long Prosecutorid { get; set; }
        public DateTime Createdate { get; set; }
        public DateTime Updatedate { get; set; }
        public long Createby { get; set; }
        public long Updateby { get; set; }
        public int Isremoved { get; set; }
        public int Isactive { get; set; }
    }
}