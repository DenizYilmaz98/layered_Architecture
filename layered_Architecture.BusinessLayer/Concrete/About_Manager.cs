using layered_Architecture.BusinessLayer.Abstract;
using layered_Architecture.DataAccess.Repository;
using layered_Architecture.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.BusinessLayer.Concrete
{
    public class About_Manager : IAbout_Service
    {
        GenericRepository<About> _genericRepository = new GenericRepository<About>();
     
        public void AboutAdd(About about)
        {
          
         
        }

        public void AboutDelete(About about)
        {
            throw new NotImplementedException();
        }

        public void AboutUpdate(About about)
        {
            throw new NotImplementedException();
        }

        public List<About> GetAbouts()
        {
            throw new NotImplementedException();
        }

        public About GetById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
