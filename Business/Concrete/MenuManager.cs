using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class MenuManager : MenuService
    {
        IMenuDal menuDal;

        public MenuManager(IMenuDal menuDal)
        {
            this.menuDal = menuDal;
        }

        public IDataResult<List<Menu>> getall()
        {
            return new SuccessDataResult<List<Menu>>(menuDal.GetAll());
        }
    }
}
