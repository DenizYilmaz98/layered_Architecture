using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.Entity.Concrete
{
    public class Blog
    {
            [Key]

        public int blId { get; set; }
        public string blTitle { get; set; }
        public string blContent { get; set; }
        public string blthumbNailİmage { get; set; }
        public string blİmage { get; set; }
        public DateTime blCreateDate { get; set; }
        public bool blStatus { get; set; }
    }
}
