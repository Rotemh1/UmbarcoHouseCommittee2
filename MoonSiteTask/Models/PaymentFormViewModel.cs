using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace MoonSiteTask.Models
{
    //view model for form
    public class PaymentFormViewModel 
    {
        [Required]
        public int AptNum { get; set; }
        [Required]
        public string? ResName { get; set; }
        [Required]
        [IntegerValidator]
        public int Amount { get; set; }
        [Required]
        public int[]? PayMonth { get; set; }
        [Required]
        public string? PayedWith { get; set; }
        public string? errLine { get; set; }
    }
    

    
}