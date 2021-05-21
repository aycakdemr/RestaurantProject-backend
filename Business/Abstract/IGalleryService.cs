using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGalleryService
    {
        IResult Add(Gallery gallery);
        IResult Delete(int id);
        IResult Update(Gallery gallery);
        IDataResult<List<Gallery>> GetAll();
        IDataResult<List<Gallery>> GetById(int id);
    }
}
