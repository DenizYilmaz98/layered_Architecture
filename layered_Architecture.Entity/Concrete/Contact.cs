using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.Entity.Concrete
{
    public class Contact
    {
        [Key]

        public int conId { get; set; }
        public string conUserName { get; set; }
        public string conMail { get; set; }
        public string conSubject { get; set; }
        public string conMassege { get; set; }
        public DateTime conDate { get; set; }
        public bool conBool { get; set; }

    }
}
