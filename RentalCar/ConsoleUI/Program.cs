using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
           
            carManager.Add(new Entities.Concrete.Car { BrandId = 4, CarName = "Corolla ", ColorId = 4, ModelYear = 2015, DailyPrice = 450, Descreption = "Dizel" });
            carManager.Add(new Entities.Concrete.Car { BrandId = 5, CarName = "301 ", ColorId = 6, ModelYear = 2016, DailyPrice = 600, Descreption = "1.6 HDİ ACCESS" });
            carManager.Add(new Entities.Concrete.Car { BrandId = 6, CarName = "Passat ", ColorId = 3, ModelYear = 2017, DailyPrice = 500, Descreption = "Dizel" });
            carManager.Add(new Entities.Concrete.Car { BrandId = 7, CarName = "Benz C-Serisi ", ColorId = 3, ModelYear = 2018, DailyPrice = 650, Descreption = "Benzin" });
            carManager.Add(new Entities.Concrete.Car { BrandId = 8, CarName = "S90 ", ColorId = 2, ModelYear = 2020, DailyPrice = 650, Descreption = "Benzin" });
            








        }
    }
}
