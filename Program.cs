﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleControl VC = new VehicleControl();
            VC.DoStuff();
        }
    }
}
