using System;

public class VehiclecasePaymentreversal
{
    public long Caseid { get; set; }
    public DateTime Donedate { get; set; }
    public decimal Totalamount { get; set; }
    public decimal Collectedamount { get; set; }
    public string Reversalsource { get; set; }
    public long Reversalby { get; set; }
    public DateTime Reversaltime { get; set; }
}
