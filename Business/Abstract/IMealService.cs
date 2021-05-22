using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMealService
    {
        IResult Add(Meal meal);
        IResult Delete(int id);
        IResult Update(Meal meal);
        IDataResult<List<Meal>> GetAll();
        IDataResult<List<Meal>> GetById(int id);
    }
}
