using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Models
{
    public class SendSMS
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Phone number")]
        [MaxLength(25)] //not found specifications of length in international format E123
        [Column(TypeName = "varchar(25)")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "SMS text")]
        [StringLength(320)]
        [RegularExpression(@"[\x00-\x7F]+", ErrorMessage = "Must be Ascii7 chars.")]
        public string SMSText { get; set; }
    }
}