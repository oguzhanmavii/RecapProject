using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete_InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class CarManager:ICarServices
    {

        private ICarDal _carDal;
        private MemoryCarDal memoryCarDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public CarManager(MemoryCarDal memoryCarDal)
        {
            this.memoryCarDal = memoryCarDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
    }
}
