namespace MoonSiteTask.Models
{
    public class PaymentFormViewModel 
    {
        public int AptNum { get; set; }
        public string? ResName { get; set; }
        public int Amount { get; set; }
        public int[]? PayMonth { get; set; }
        public string? PayedWith { get; set; }
    }
    

    
}