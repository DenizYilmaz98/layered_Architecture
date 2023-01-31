using layered_Architecture.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.BusinessLayer.Abstract
{
   public interface IwritersCountry_City_Service
    {
        List<writersCountry_City> WriterCCList(int Id);
        void Insert(writersCountry_City writersCountry_City);
    }
}
