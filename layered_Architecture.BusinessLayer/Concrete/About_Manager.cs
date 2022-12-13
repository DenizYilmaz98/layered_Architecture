using layered_Architecture.BusinessLayer.Abstract;
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
        private readonly IAbout_Service _about_Service;

        public About_Manager(IAbout_Service about_Service )
        {
            _about_Service = about_Service;
        }
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
