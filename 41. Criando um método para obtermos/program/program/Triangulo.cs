using System;
using System.Collections.Generic;
using System.Text;

namespace program {
    class Triangulo {

        public double A;
        public double B;
        public double C;

        public double Area() { // metodo é uma função dentro da classe.
            double p = (A + B + C) / 2;
            double areaTotal = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return areaTotal;
        }
    }
}
