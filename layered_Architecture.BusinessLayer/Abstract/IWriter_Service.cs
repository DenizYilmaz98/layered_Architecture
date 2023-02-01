using layered_Architecture.BusinessLayer.Validation_Rules;
using layered_Architecture.DataAccess.Model;
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
        void writerAdd(RegisterDtoModel registerrModelDto);
        void writerUpdate(Writer writer);
        void writerDelete(Writer writer);
        List<Writer> GetById(int Id);
    }
}
