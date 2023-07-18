using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IResult TransactionalOperation(Car car);
        IDataResult<List<Car>> GetByBrand(int brandId);
        
        IDataResult<List<CarDetailDto>> CarDetailDtos();
        IDataResult<List<CarDetailDto>> CarsDetailDtos(int brandId);
        IDataResult<List<CarDetailDto>> CarsDetailDtosColor(int colorId);
        
        
    }
}
