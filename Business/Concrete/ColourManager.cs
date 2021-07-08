using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColourManager : IColourService
    {
        IColourDal _colourDal;

        public ColourManager(IColourDal colourDal)
        {
            _colourDal = colourDal;
        }

        public IResult Add(Colour colour)
        {
            _colourDal.Add(colour);
            return new SuccessResult(Messages.ColourAdded);
        }

        public IResult Delete(Colour colour)
        {
            _colourDal.Delete(colour);
            return new SuccessResult();
        }

        public IDataResult<List<Colour>> GetAll()
        {
            return new SuccessDataResult<List<Colour>>(_colourDal.GetAll(),Messages.CarsListed);
        }

        public IDataResult<List<Colour>> GetAllById(int Id)
        {
            return new SuccessDataResult<List<Colour>>(_colourDal.GetAll(c=>c.ColourId==Id),Messages.ColoursListed);

        }

        public IResult Update(Colour colour)
        {
            _colourDal.Update(colour);
            return new SuccessResult();

        }
    }
}
