﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFormsPractice
{
    internal class Class
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Class( string name, int age)
        {
            Name = name;

            Age = age;

        }

        
        
        public override string ToString()
        {
            return Name + Age;

        }

    }
}
