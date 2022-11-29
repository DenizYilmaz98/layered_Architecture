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

        public int abId { get; set; }
        public string abDetails1 { get; set; }
        public string abDetails2 { get; set; }
        public string abİmage1 { get; set; }
        public string abİmage2 { get; set; }
        public string abMapLocation { get; set; }
        public bool abStatus { get; set; }

    }
}
