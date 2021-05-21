using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MenuManager : IMenuService
    {
        IMenuDal _menuDal;

        public MenuManager(IMenuDal menuDal)
        {
            _menuDal = menuDal;
        }

        public IResult Add(Menu menu)
        {
            _menuDal.Add(menu);
            return new SuccessResult();
        }

        public IResult Delete(int id)
        {
            var value = _menuDal.Get(x => x.Id == id);
            _menuDal.Add(value);
            return new SuccessResult();
        }

        public IDataResult<List<Menu>> GetAll()
        {
            return new SuccessDataResult<List<Menu>>(_menuDal.GetAll());
        }

        public IDataResult<List<Menu>> GetById(int id)
        {
            return new SuccessDataResult<List<Menu>>(_menuDal.Get(x => x.Id == id).ToString());
        }

        public IResult Update(Menu menu)
        {
            _menuDal.Update(menu);
            return new SuccessResult();
        }
    }
}
