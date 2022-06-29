using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class SendSMS
    {

    [Display(Name = "Phone number (with Country prefix)")]
    [RegularExpression(@"[0-9]+", ErrorMessage = "Must be digits.")] //má být max 15
    [MaxLength(15, ErrorMessage = "Maximum length is 15")]
    public string? PhoneNumber { get; set; } = null;

    [Display(Name = "SMS text")] 
    [StringLength(320)]
    [RegularExpression(@"\x00-\x7F")]
    public string? SMSText { get; set; }
    
    }
}