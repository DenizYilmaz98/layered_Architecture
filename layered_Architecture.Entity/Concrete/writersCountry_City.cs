using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.Entity.Concrete
{
    public class writersCountry_City
    {
        [Key]
        public int CCID { get; set; }
        public string Country_City { get; set; }
        public List<Writer> writers { get; set; }

    }
}
