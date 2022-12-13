using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.Entity.Concrete
{
    public class Comment
    {
        [Key]
        public int commentId { get; set; }
        public string commentUserName { get; set; }
        public string commentTitle { get; set; }
        public string commentContent { get; set; }
        public DateTime commentDate { get; set; }
        public bool commentStatus { get; set; }
        public int blogId { get; set; }
        public Blog Blog { get; set; }

    }
}
