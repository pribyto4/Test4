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
       // [RegularExpression(@"[\x00-\x7F]")] //povolení jen Ascii7, chyběly hranaté závorky, zkusit odkomentovat
        // kdyby pořád nešlo, tak zkusit tohle: [ -~] a v nejhorším povolit písmema, čísla a zbytek doplnit 
        public string? SMSText { get; set; }
    }
}