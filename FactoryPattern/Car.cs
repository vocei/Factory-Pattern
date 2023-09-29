using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public Car()
        {
        }


        public void Drive()
        {
            ConsoleLogger.VehicleStartMessage();
            Console.WriteLine("The car is currently driving at the speed limit!");
            
        }
    }
}



