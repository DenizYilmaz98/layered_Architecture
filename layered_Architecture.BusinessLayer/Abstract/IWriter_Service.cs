using layered_Architecture.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.BusinessLayer.Abstract
{
    public interface IWriter_Service
    {
        List<Writer> GetWriters();
        void WriterAdd(Writer writer);
        void WriterUpdate(Writer writer);
        void WriterDelete(Writer writer);
        Writer GetById(int Id);
    }
}
