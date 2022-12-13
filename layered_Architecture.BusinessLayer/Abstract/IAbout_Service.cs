using layered_Architecture.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.BusinessLayer.Abstract
{
    public interface IAbout_Service
    {
        List<About> GetAbouts();
        void AboutAdd(About about);
        void AboutUpdate(About about);
        void AboutDelete(About about);
        About GetById(int Id);
    }
}
