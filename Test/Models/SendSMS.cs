using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
   // [Keyless] nefunguje
    public class SendSMS
    {
        public int Id { get; set; }

        [Display(Name = "Phone number")]
        [RegularExpression(@"^\+[0-9]+", ErrorMessage = "Must be digits.")]
        [MaxLength(16, ErrorMessage = "Maximum length is 16")]
        public string? PhoneNumber { get; set; } = null;

        [Display(Name = "SMS text")]
        [StringLength(320)]
        [RegularExpression(@"[\x00-\x7F]+", ErrorMessage = "Must be Ascii7 chars.")]
        public string? SMSText { get; set; }
    }
}