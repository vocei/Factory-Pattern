using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public void Drive()
        {
            ConsoleLogger.VehicleStartMessage();
            Console.WriteLine("The Motorcycle is revving up!");
            Console.WriteLine("Vroom!");
            
        }
    }
}
