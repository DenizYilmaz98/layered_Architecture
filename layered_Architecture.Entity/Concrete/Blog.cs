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

        public int blogId { get; set; }
        public string blogTitle { get; set; }
        public string blogContent { get; set; }
        public string blogthumbNailİmage { get; set; }
        public string blogİmage { get; set; }
        public DateTime blogCreateDate { get; set; }
        public bool blogStatus { get; set; }
        public int categoryId { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
