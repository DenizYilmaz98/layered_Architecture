using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.Entity.Concrete
{
    public class Category
    {
        [Key]

        public int Id { get; set; }
        public string caName { get; set; }
        public string caDescription { get; set; }
        public bool caStatus { get; set; }

    }
}
