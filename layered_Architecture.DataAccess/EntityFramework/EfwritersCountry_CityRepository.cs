using layered_Architecture.DataAccess.Abstract;
using layered_Architecture.DataAccess.Repository;
using layered_Architecture.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.DataAccess.EntityFramework
{
    public class EfwritersCountry_CityRepository:GenericRepository<writersCountry_City>, IwritersCountry_CityDal
    {
    }
}
