using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IReservationService
    {
        IResult Add(Reservation reservation);
        IResult Delete(int id);
        IResult Update(Reservation reservation);
        IDataResult<List<Reservation>> GetAll();
        IDataResult<List<Reservation>> GetById(int id);
    }
}
