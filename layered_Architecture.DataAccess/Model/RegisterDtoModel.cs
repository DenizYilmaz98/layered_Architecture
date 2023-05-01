using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.DataAccess.Model
{
    public class RegisterDtoModel
    {
        public int writerId { get; set; }
        public string writerName { get; set; }
        public string writerAbout { get; set; }
        public string writerImage { get; set; }
        public string writerMail { get; set; }
        public string writerPassword { get; set; }

        [Required(ErrorMessage ="Lütfen bir şehir seçin")]
        public int CCID { get; set; }
    }
}
