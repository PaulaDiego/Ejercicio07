﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    public class Calculadora : ICalculadora
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }
    }
}
