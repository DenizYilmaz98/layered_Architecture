using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.Entity.Concrete
{
    public class Writer
    {
        [Key]
        public int writerId { get; set; }
        public string writerName { get; set; }
        public string writerAbout { get; set; }
        public string writerImage { get; set; }
        public string writerMail { get; set; }
        public string writerPassword { get; set; }
        public int CCID { get; set; }
        
        public bool writerStatus { get; set; }


    }
}
