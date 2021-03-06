using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IContactService
    {
        IResult Add(Contact contact);
        IResult Delete(int id);
        IResult Update(Contact contact);
        IDataResult<List<Contact>> GetAll();
        IDataResult<List<Contact>> GetById(int id);
    }
}
