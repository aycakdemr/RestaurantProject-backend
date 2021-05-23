using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class MealService : IMealService
    {
        IMealDal _mealDal;

        public MealService(IMealDal mealDal)
        {
            _mealDal = mealDal;
        }

        public IResult Add(Meal meal)
        {
            _mealDal.Add(meal);
            return new SuccessResult();
        }

        public IResult Delete(int id)
        {
            var value = _mealDal.Get(x => x.Id == id);
            _mealDal.Delete(value);
            return new SuccessResult();
        }

        public IDataResult<List<Meal>> GetAll()
        {
            return new SuccessDataResult<List<Meal>>(_mealDal.GetAll());
        }

        public IDataResult<List<Meal>> GetById(int id)
        {
            return new SuccessDataResult<List<Meal>>(_mealDal.GetAll(x => x.Id == id));
        }

        public IResult Update(Meal meal)
        {
            _mealDal.Update(meal);
            return new SuccessResult();
        }
    }
}
