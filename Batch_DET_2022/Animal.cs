﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Animals
    {
        public abstract class Animal
        {
            public int age { get; set; }
            public string name { get; set; }
            public string gender { get; set; }
            public abstract string ToString();
        }
    }
}
