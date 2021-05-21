using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMenuService
    {
        IResult Add(Menu menu);
        IResult Delete(int id);
        IResult Update(Menu menu);
        IDataResult<List<Menu>> GetAll();
        IDataResult<List<Menu>> GetById(int id);
    }
}
