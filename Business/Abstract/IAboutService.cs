using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAboutService
    {
        IResult Add(About about);
        IResult Delete(int id);
        IResult Update(About about);
        IDataResult<List<About>> GetAll();
        IDataResult<List<About>> GetById(int id);

    }
}
