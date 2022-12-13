using layered_Architecture.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.BusinessLayer.Abstract
{
    public interface IContact_Service
    {
        List<Contact> GetContacts();
        void ContactAdd(Contact contact);
        void ContactUpdate(Contact contact);
        void ContactDelete(Contact contact);
        Contact GetById(int Id);
    }
}
