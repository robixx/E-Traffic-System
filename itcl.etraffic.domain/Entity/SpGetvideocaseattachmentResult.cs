using System;


namespace itcl.etraffic.domain.Entity
{
    public class SpGetvideocaseattachmentResult
    {
        public long IId { get; set; }
        public long Videocaseid { get; set; }
        public string? Attachmentfilename { get; set; }
        public int Status { get; set; }
    }
}