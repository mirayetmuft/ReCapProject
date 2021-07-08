using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        //public InMemoryCarDal()
        //{
        //    _cars = new List<Car> { 
        //        new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2021,DailyPrice=22.500,Description ="Otomatik Vites"},
        //        new Car{Id=2,BrandId=2,ColorId=2,ModelYear=2021,DailyPrice=20.500,Description ="Otomatik Vites"},
        //        new Car{Id=3,BrandId=3,ColorId=1,ModelYear=2021,DailyPrice=23.000,Description ="Otomatik Vites"},
        //        new Car{Id=4,BrandId=4,ColorId=3,ModelYear=2021,DailyPrice=21.500,Description ="Otomatik Vites"},
        //        new Car{Id=5,BrandId=5,ColorId=4,ModelYear=2021,DailyPrice=27.500,Description ="Otomatik Vites"},

        //    };
        //}

        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public List<Car> Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

       

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllById(int Id)
        {
            return _cars.Where(c => c.CarId == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            

        }

        Car IEntityRepository<Car>.Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
