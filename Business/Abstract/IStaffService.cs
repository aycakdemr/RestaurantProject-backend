﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStaffService
    {
        IResult Add(Staff staff);
        IResult Delete(int id);
        IResult Update(Staff staff);
        IDataResult<List<Staff>> GetAll();
        IDataResult<List<Staff>> GetById(int id);
    }
}
