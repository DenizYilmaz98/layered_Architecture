using layered_Architecture.BusinessLayer.Abstract;
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
        public Writer GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetWriters()
        {
            throw new NotImplementedException();
        }

        public void WriterAdd(Writer writer)
        {
            throw new NotImplementedException();
        }

        public void WriterDelete(Writer writer)
        {
            throw new NotImplementedException();
        }

        public void WriterUpdate(Writer writer)
        {
            throw new NotImplementedException();
        }
    }
}
