using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
   // [Keyless] nefunguje
    public class SendSMS
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Phone number")]
        [MaxLength(16, ErrorMessage = "Maximum length is 16")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "SMS text")]
        [StringLength(320)]
        [RegularExpression(@"[\x00-\x7F]+", ErrorMessage = "Must be Ascii7 chars.")]
        public string SMSText { get; set; }
    }
}