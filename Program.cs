﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioGetSet
{
   class Program
    {
        static void Main(string[] args)
        {
            Data Data = new Data();
            Data.SetMes(2);
            Data.ApresentarMes();
        }
    }
}
