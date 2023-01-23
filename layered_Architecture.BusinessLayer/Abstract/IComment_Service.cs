using layered_Architecture.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.BusinessLayer.Abstract
{
    public interface IComment_Service
    {
        List<Comment> GetList(int id);
        void CommentAdd(Comment comment);
        void CommentUpdate(Comment comment);
        void CommentDelete(Comment comment);
        Comment GetById(int Id);
    }
}
