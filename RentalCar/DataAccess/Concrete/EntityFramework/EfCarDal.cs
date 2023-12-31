﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, NorthwindDBContext>, ICarDal
    {
        public List<CarDetailDto> CarDetailDtos()
        {
            using (NorthwindDBContext context = new NorthwindDBContext())
            {
                var result = from c in context.Cars
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             select new CarDetailDto {
                                 CarId = c.Id,      
                                 ColorId = co.Id,
                                 BrandId = b.Id,
                                 CarName = c.CarName, 
                                 ColorName = co.ColorName,
                                 BrandName = b.BrandName, 
                                 Descreption = c.Descreption,
                                 DailyPrice = c.DailyPrice
                                 
                             };

                return result.ToList();
                             
            }
        }

        public List<CarDetailDto> CarsDetailDtos(Expression<Func<Car, bool>> filter)
        {
            using (NorthwindDBContext context = new NorthwindDBContext())
            {
                var result = from c in filter == null ? context.Cars : context.Cars.Where(filter)
                             join b in context.Brands on c.BrandId equals b.Id
                             join co in context.Colors on c.ColorId equals co.Id
                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 ColorId = co.Id,
                                 BrandId = b.Id,
                                 CarName = c.CarName,
                                 ColorName = co.ColorName,
                                 BrandName = b.BrandName,
                                 Descreption = c.Descreption,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
