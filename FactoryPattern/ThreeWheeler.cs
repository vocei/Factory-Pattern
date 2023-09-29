﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ThreeWheeler : IVehicle
    {
        public void Drive()
        {
            ConsoleLogger.VehicleStartMessage();
            Console.WriteLine("Nice 3 wheeler! A bit exotic don't you think?");
            
        }
    }
}
