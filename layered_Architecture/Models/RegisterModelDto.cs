using System.ComponentModel.DataAnnotations;

namespace layered_Architecture.UI.Models
{
    public class RegisterModelDto
    {
        [Required(ErrorMessage = "Lütfen Boş Geçmeyiniz")]
        public string writerName { get; set; }
        [MaxLength(250)]
        [Required(ErrorMessage = "Lütfen Boş Geçmeyiniz")]
        public string writerAbout { get; set; }

        [Required (ErrorMessage ="Lütfen Boş Geçmeyiniz")]
        public string writerImage { get; set; }

        [Required(ErrorMessage = "Lütfen bir şehir seçin")]

        public string writerMail { get; set; }

        [Required(ErrorMessage = "Lütfen bir şehir seçin")]

        public string writerPassword { get; set; }

        [Required(ErrorMessage = "Lütfen bir şehir seçin")]
        public int CCID { get; set; }
    }
}
