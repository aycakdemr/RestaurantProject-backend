using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class MealManager : IMealService
    {
        IMealDal _mealDal;

        public MealManager(IMealDal mealDal)
        {
            _mealDal = mealDal;
        }
        [ValidationAspect(typeof(MealValidator))]
        public IResult Add(Meal meal)
        {
            ValidationTool.Validate(new MealValidator(), meal);
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
