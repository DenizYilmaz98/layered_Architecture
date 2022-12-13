using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.Entity.Concrete
{
    public class About
    {
        [Key]

        public int aboutID { get; set; }
        public string aboutDetails1 { get; set; }
        public string aboutDetails2 { get; set; }
        public string aboutİmage1 { get; set; }
        public string aboutİmage2 { get; set; }
        public string aboutMapLocation { get; set; }
        public bool aboutStatus { get; set; }

    }
}
