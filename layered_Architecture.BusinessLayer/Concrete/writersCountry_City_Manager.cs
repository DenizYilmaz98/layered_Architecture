using layered_Architecture.BusinessLayer.Abstract;
using layered_Architecture.DataAccess.Abstract;
using layered_Architecture.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.BusinessLayer.Concrete
{
    public class writersCountry_City_Manager : IwritersCountry_City_Service
    {
        private readonly IwritersCountry_CityDal _cityDal;

        public writersCountry_City_Manager(IwritersCountry_CityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public void Insert(writersCountry_City writersCountry_City)
        {
           _cityDal.Insert(writersCountry_City);
        }

        public List<writersCountry_City> WriterCCList(int Id)
        {
           return _cityDal.GetListAll(x=>x.CCID==Id);
        }
    }
}
