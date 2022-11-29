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
        public int comId { get; set; }
        public string comUserName { get; set; }
        public string comTitle { get; set; }
        public string comContent { get; set; }
        public DateTime comDate { get; set; }
        public bool comStatus { get; set; }

    }
}
