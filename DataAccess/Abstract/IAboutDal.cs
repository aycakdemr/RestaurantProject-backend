using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Core.DataAccess;

namespace DataAccess.Abstract
{
    public interface IAboutDal :IEntityRepository<About>
    {
    }
}
