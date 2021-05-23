using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public IResult Add(About about)
        {
            _aboutDal.Add(about);
            return new SuccessResult();
        }

        public IResult Delete(int id)
        {
            var value = _aboutDal.Get(x => x.Id == id);
            _aboutDal.Delete(value);
            return new SuccessResult();
        }

        public IDataResult<List<About>> GetAll()
        {
            return new SuccessDataResult<List<About>>(_aboutDal.GetAll());
        }

        public IDataResult<List<About>> GetById(int id)
        {
            return new SuccessDataResult<List<About>>(_aboutDal.GetAll(x => x.Id == id));
        }

        public IResult Update(About about)
        {
            _aboutDal.Update(about);
            return new SuccessResult();
        }
    }
}
