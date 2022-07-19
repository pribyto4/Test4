using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class InputsSMS
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Phone number")]
        [MaxLength(25, ErrorMessage = "Maximum length is 25")]
        public string PhoneNumber { get; set; }

        [Display(Name = "JSInput")]
        [MaxLength(25, ErrorMessage = "Maximum length is 25")]
        public string? JSInput { get; set; }

        [Display(Name = "JSInputCounteryCode")]
        [MaxLength(2, ErrorMessage = "Maximum length is 2")]
        public string? JSInputCounteryCode { get; set; }

        [Required]
        [Display(Name = "SMS text")]
        [StringLength(320)]
        [RegularExpression(@"[\x00-\x7F]+", ErrorMessage = "Must be Ascii7 chars.")]
        public string SMSText { get; set; }
    }
}