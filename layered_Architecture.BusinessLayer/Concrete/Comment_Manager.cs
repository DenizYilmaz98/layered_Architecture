using layered_Architecture.BusinessLayer.Abstract;
using layered_Architecture.DataAccess.Abstract;
using layered_Architecture.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layered_Architecture.BusinessLayer.Concrete
{
    public class Comment_Manager : IComment_Service
    {
        private readonly ICommentDal _commentDal;

        public Comment_Manager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public void CommentAdd(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public void CommentDelete(Comment comment)
        {
            _commentDal.Delete(comment);
        }

        public void CommentUpdate(Comment comment)
        {
            _commentDal.Update(comment);
        }

        public Comment GetById(int Id)
        {
            return _commentDal.GetById(Id);
        }

        public List<Comment> GetComments(int id)
        {
          return _commentDal.GetListAll(x=>x.blogId==id);
        }
    }
}
