using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete_InMemory
{
   public class MemoryCarDal
    {
        private List<Car> _cars;

        public MemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=3,ColorId=1453,DailyPrice=33,ModelYear= new DateTime(2015),Description="Opel Astra"},
                new Car{Id=2,BrandId=8,ColorId=2096,DailyPrice=17,ModelYear= new DateTime(2012),Description="Renault Laguna"},
                new Car{Id=3,BrandId=4,ColorId=3651,DailyPrice=15,ModelYear= new DateTime(2009),Description="Bmw 740i"},
                new Car{Id=4,BrandId=16,ColorId=6844,DailyPrice=26,ModelYear= new DateTime(2007),Description="Land Rover Range-RoverSport2021"},
                new Car{Id=5,BrandId=63,ColorId=1151,DailyPrice=42,ModelYear= new DateTime(2017),Description="Mercedes A180"},
                new Car{Id=6,BrandId=21,ColorId=4999,DailyPrice=11,ModelYear= new DateTime(2013),Description="WolksWagen Scirocco"},
                new Car{Id=7,BrandId=15,ColorId=5811,DailyPrice=4,ModelYear= new DateTime(2011),Description="WolksWagen Caddy1.6TDI Comfortline"}

            };
        }


        public List<Car> GetById(int id) // Linq Yapısı Kuruldu ICarDal İmzası Çağırıldı
        {
            return _cars.Where(p => p.Id == id).ToList();
        }


        public List<Car> GetAll() // _cars içindeki bütün elemanları döndürme işlemi
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car) // Güncelleme işlemi Id sabit kalır diğer özellikler car nesnesine göre değiştirilir
        {
            Car carUpdated = _cars.SingleOrDefault(p => p.Id == car.Id);

            carUpdated.BrandId = car.BrandId;
            carUpdated.ColorId = car.ColorId;
            carUpdated.ModelYear = car.ModelYear;
            carUpdated.DailyPrice = car.DailyPrice;
        }

        public void Delete(Car car)
        {
            Car carDeleted = _cars.SingleOrDefault(p => p.Id == car.Id);

            _cars.Remove(carDeleted);

        }

     }
      



    
}
