using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class GalleryManager : IGalleryService
    {
        IGalleryDal _galleryDal;

        public GalleryManager(IGalleryDal galleryDal)
        {
            _galleryDal = galleryDal;
        }

        public IResult Add(Gallery gallery)
        {
            _galleryDal.Add(gallery);
            return new SuccessResult();
        }

        public IResult Delete(int id)
        {
            var value = _galleryDal.Get(x => x.Id == id);
            _galleryDal.Delete(value);
            return new SuccessResult();
        }

        public IDataResult<List<Gallery>> GetAll()
        {
            return new SuccessDataResult<List<Gallery>>(_galleryDal.GetAll());
        }

        public IDataResult<List<Gallery>> GetById(int id)
        {
            return new SuccessDataResult<List<Gallery>>(_galleryDal.GetAll(x => x.Id == id));
        }

        public IResult Update(Gallery gallery)
        {
            _galleryDal.Update(gallery);
            return new SuccessResult();
        }
    }
}
