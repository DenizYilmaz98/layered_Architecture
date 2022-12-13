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

        public int contactId { get; set; }
        public string contactUserName { get; set; }
        public string contactMail { get; set; }
        public string contactSubject { get; set; }
        public string contactMassege { get; set; }
        public DateTime contactDate { get; set; }
        public bool contactBool { get; set; }

    }
}
