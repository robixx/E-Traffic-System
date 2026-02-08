using System;

namespace itcl.etraffic.domain.Entity
{
    public class VehiclecasesentforsundarbanResult
    {
        public long Iid { get; set; }
        public long Vehiclecaseid { get; set; }
        public DateTime Transferdate { get; set; }
        public DateTime? Createdate { get; set; }
        public DateTime? Updatedate { get; set; }
        public int? Createby { get; set; }
        public int? Updateby { get; set; }
        public int? Isremoved { get; set; }
    }
}