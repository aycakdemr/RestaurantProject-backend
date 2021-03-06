using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class StaffManager : IStaffService
    {
        IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public IResult Add(Staff staff)
        {
            _staffDal.Add(staff);
            return new SuccessResult();
        }

        public IResult Delete(int id)
        {
            var value = _staffDal.Get(x => x.Id == id);
            _staffDal.Delete(value);
            return new SuccessResult();
        }

        public IDataResult<List<Staff>> GetAll()
        {
            return new SuccessDataResult<List<Staff>>();
        }

        public IDataResult<List<Staff>> GetById(int id)
        {
            return new SuccessDataResult<List<Staff>>(_staffDal.GetAll(x => x.Id == id));
        }

        public IResult Update(Staff staff)
        {
            _staffDal.Update(staff);
            return new SuccessResult();
        }
    }
}
