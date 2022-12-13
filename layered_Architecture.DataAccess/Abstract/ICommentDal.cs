using layered_Architecture.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.DataAccess.Abstract
{
    public interface ICommentDal: IGenericDal<Comment>
    {
        List<Comment> ListAllComment();
        void AddComment(Comment commnet);
        void UpdateComment(Comment commnet);
        void DeleteComment(Comment commnet);
        Comment GetComment(int id);


    }
}
