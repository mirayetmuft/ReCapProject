using Business.Concrete;
using DataAccess.Concrete.Entity_Framework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //CarManager carManager = new CarManager(new EfCarDal());
            //Car car = new Car();
            //car.CarName = "M";
            //car.DailyPrice = 0;
            //carManager.Add(car);
            //CarTest();
           BrandManager brandManager = new BrandManager(new EfBrandDal());

            //foreach (var brand1 in brandManager.GetAllById(2).Data)
            //{
            //    Console.WriteLine(brand1.BrandName);
            //}


            //Brand brand = new Brand();
            //brand.BrandId = 4;
            //brand.BrandName = "Volkswagen";
            //brandManager.Add(brand);
            //brandManager.Delete(brand);
            //brandManager.Update(brand);

            BrandTest(brandManager);

            

        }

        private static void BrandTest(BrandManager brandManager)
        {
            BrandManager brandManager1 = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager1.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
                   
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColourName + "/" + car.DailyPrice);
            }
        }
    }
}
