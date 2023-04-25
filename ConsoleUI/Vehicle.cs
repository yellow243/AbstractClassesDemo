﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";

        public abstract void DriveAbstract(); //stubbed out method

        public virtual void DriveVirtual() 
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }
    }
}
