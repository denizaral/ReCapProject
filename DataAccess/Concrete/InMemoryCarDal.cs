using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=5, ColorId=9, ModelYear=2010, DailyPrice=100, Description="Temizdir."},
                new Car{Id=2, BrandId=6, ColorId=10, ModelYear=2011, DailyPrice=200, Description="KM'si düşük."},
                new Car{Id=3, BrandId =7, ColorId=11, ModelYear=2012, DailyPrice=300, Description = "Hasarlıdır." },
                new Car{Id=4, BrandId =8, ColorId=12, ModelYear=2013, DailyPrice=400, Description = "Hasarı yoktur." }
            };
        }
        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

    }
    
}
