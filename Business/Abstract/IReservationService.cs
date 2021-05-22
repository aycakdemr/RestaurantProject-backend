using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

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
