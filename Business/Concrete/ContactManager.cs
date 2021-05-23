using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public IResult Add(Contact contact)
        {
            _contactDal.Add(contact);
            return new SuccessResult();
        }

        public IResult Delete(int id)
        {
            var value = _contactDal.Get(x => x.Id == id);
            _contactDal.Delete(value);
            return new SuccessResult();
        }

        public IDataResult<List<Contact>> GetAll()
        {
            return new SuccessDataResult<List<Contact>>(_contactDal.GetAll());
        }

        public IDataResult<List<Contact>> GetById(int id)
        {
            return new SuccessDataResult<List<Contact>>(_contactDal.GetAll(x => x.Id == id));
        }

        public IResult Update(Contact contact)
        {
            _contactDal.Update(contact);
            return new SuccessResult();
        }
    }
}
