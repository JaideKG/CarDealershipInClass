using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealershipInClass.Models
{
    interface IDAO
    {
        Car GetCar(int id);
        
        List<Car> GetCarList();

        void AddCar(Car car);

        void DeleteCar(int id);
        
        void EditCar(Car car);

        void Dispose();
    }
}
