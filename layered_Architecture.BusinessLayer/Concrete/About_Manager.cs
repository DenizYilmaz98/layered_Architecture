using layered_Architecture.BusinessLayer.Abstract;
using layered_Architecture.DataAccess.Abstract;
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
        private readonly IAboutDal _aboutDal;

        public About_Manager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public void AboutAdd(About about)
        {

            _aboutDal.Insert(about);
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
