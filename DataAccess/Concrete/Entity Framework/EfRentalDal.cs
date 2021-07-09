using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        //public List<RentDetailDto> GetRentDetail()
        //{
        //    using (RentACarContext context = new RentACarContext())
        //    {
        //        var result = from c in context.Cars
        //                     join r in context.Rentals
        //                     on c.Id equals r.CarId
        //                     join cu in context.Customers
        //                     on r.CustomerId equals cu.UserId
        //                     select new RentDetailDto
        //                     {
        //                         CarName = c.CarName,
        //                         CarDetail = c.Description,
        //                         CompanyName = cu.CompanyName,
        //                         RentDate = r.RentDate,
        //                         ReturnDate = r.ReturnDate
        //                     };



        //        //from c in context.Cars
        //        //join cl in context.Colours
        //        //on c.ColourId equals cl.ColourId
        //        //join b in context.Brands
        //        //on c.BrandId equals b.BrandId
        //        //select new CarDetailDto
        //        //{
        //        //    CarName = c.CarName,
        //        //    BrandName = b.BrandName,
        //        //    ColourName = cl.ColoursName,
        //        //    DailyPrice = c.DailyPrice
        //        //};




        //        return result.ToList();
        //    }
        //}
    }
}
