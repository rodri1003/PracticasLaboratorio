﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    internal class Calculadora
    {
        double num1, num2, resultado;

        public Calculadora(double _num1, double _num2)
        {
            this.num1 = _num1;
            this.num2 = _num2;
        }
        public double suma()
        {
            resultado = num1 + num2;
            return resultado;
        }

        public double resta()
        {
            resultado = num1 - num2;
            return resultado;
        }

        public double multiplicacion()
        {
            resultado = num1 * num2;
            return resultado;
        }

        public double division()
        {
            resultado = num1 / num2;
            return resultado;
        }
    }
}
