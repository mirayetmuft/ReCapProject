using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsById(int Id);
        IDataResult<List<Car>> GetCarsByColourId(int ColourId);
        IResult Add(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Delete(Car car);
        IResult Update(Car car);

    }
}