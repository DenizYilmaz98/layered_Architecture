using layered_Architecture.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.DataAccess.Abstract
{
    public interface IContactDal:IGenericDal<Contact>
    {
    }
}
