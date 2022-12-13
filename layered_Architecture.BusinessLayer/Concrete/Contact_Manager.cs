using layered_Architecture.BusinessLayer.Abstract;
using layered_Architecture.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.BusinessLayer.Concrete
{
    public class Contact_Manager : IContact_Service
    {
        public void ContactAdd(Contact contact)
        {
            throw new NotImplementedException();
        }

        public void ContactDelete(Contact contact)
        {
            throw new NotImplementedException();
        }

        public void ContactUpdate(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Contact GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetContacts()
        {
            throw new NotImplementedException();
        }
    }
}
