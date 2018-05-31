using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarDealershipInClass.Models
{
    public class CarDAO : IDAO
    {
        private CarEntities db;

        public CarDAO ()
        {
            db = new CarEntities();
        }

        public Car GetCar (int id)
        {
            return db.Cars.Find(id);
        }

        public List<Car> GetCarList ()
        {
            return db.Cars.ToList();
        }

        public void AddCar(Car car)
        {
            db.Cars.Add(car);
            db.SaveChanges();
        }

        public void DeleteCar(int id)
        {
            Car car = db.Cars.Find(id);
            db.Cars.Remove(car);
            db.SaveChanges();
        }

        public void EditCar(Car car)
        {
            db.Entry(car).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}