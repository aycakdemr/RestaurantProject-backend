using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICommentService
    {
        IResult Add(Comment comment);
        IResult Delete(int id);
        IResult Update(Comment comment);
        IDataResult<List<Comment>> GetAll();
        IDataResult<List<Comment>> GetById(int id);
    }
}
