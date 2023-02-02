using layered_Architecture.BusinessLayer.Abstract;
using layered_Architecture.BusinessLayer.Validation_Rules;
using layered_Architecture.DataAccess.Abstract;
using layered_Architecture.DataAccess.EntityFramework;
using layered_Architecture.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.BusinessLayer.Concrete
{
    public class Writer_Manager : IWriter_Service
    {
        private readonly IWriterDal _writerDal;

        public Writer_Manager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public List<Writer> GetById(int Id)
        {
            return _writerDal.GetListAll(x => x.writerId == Id);
        }

        public List<Writer> GetWriters()
        {
            return _writerDal.GetListAll();
        }

        public void writerAdd(Writer writer)
        {
           
            _writerDal.Insert(writer);
        }
    



            public void writerDelete(Writer writer)
            {
                _writerDal.Delete(writer);
            }

            public void writerUpdate(Writer writer)
            {
                _writerDal.Update(writer);
              }
    }
}

