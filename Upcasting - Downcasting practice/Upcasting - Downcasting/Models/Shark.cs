﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting___Downcasting.Models
{
    public class Shark : Fish
    {
        public int Weight { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Shark is swimming");
        }
    }
}
