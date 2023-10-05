﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryLibrary.Model
{
    public interface ICarFactory
    {
        ITesla CreateTesla();
        IBMW CreateBMW();
        IAudi CreateAudi();
    }
}
