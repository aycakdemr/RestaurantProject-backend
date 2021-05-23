using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public IResult Add(Comment comment)
        {
            _commentDal.Add(comment);
            return new SuccessResult();
        }

        public IResult Delete(int id)
        {
            var value = _commentDal.Get(x => x.Id == id);
            _commentDal.Delete(value);
            return new SuccessResult();
        }

        public IDataResult<List<Comment>> GetAll()
        {
            return new SuccessDataResult<List<Comment>>(_commentDal.GetAll());
        }

        public IDataResult<List<Comment>> GetById(int id)
        {
            return new SuccessDataResult<List<Comment>>(_commentDal.GetAll(x => x.Id == id));
        }

        public IResult Update(Comment comment)
        {
            _commentDal.Update(comment);
            return new SuccessResult();
        }
    }
}
