﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public abstract class VehicleFactory
    {
        public abstract Truck CreateTruck();
        public abstract Car CreateCar();
    }
}