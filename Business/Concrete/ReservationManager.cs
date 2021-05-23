using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public IResult Add(Reservation reservation)
        {
            _reservationDal.Add(reservation);
            return new SuccessResult();
        }

        public IResult Delete(int id)
        {
            var value = _reservationDal.Get(x => x.Id == id);
            _reservationDal.Delete(value);
            return new SuccessResult();
        }

        public IDataResult<List<Reservation>> GetAll()
        {
            return new SuccessDataResult<List<Reservation>>();
        }

        public IDataResult<List<Reservation>> GetById(int id)
        {
            return new SuccessDataResult<List<Reservation>>(_reservationDal.GetAll(x => x.Id == id));
        }

        public IResult Update(Reservation reservation)
        {
            _reservationDal.Update(reservation);
            return new SuccessResult();
        }
    }
}
