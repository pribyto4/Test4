using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class SendSMS
    {
        [Display(Name = "Phone number (with Country prefix)")]
        [RegularExpression(@"[0-9]+|^\+[0-9]+", ErrorMessage = "Must be digits.")]
        [MaxLength(16, ErrorMessage = "Maximum length is 16")]
        public string? PhoneNumber { get; set; } = null;

        [Display(Name = "SMS text")]
        [StringLength(320)]
       // [RegularExpression(@"\x00-\x7F")] //mělo by být povolení jen Ascii7, nefunguje
        public string? SMSText { get; set; }
    }
}