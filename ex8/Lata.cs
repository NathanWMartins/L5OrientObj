using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    internal class Lata
    {
        private double raio;
        private double h;

        public Lata(double raio, double h)
        {
            this.raio = raio;
            this.h = h;
        }

        public double calcularVolume()
        {
            return (Math.Pow(raio, 2) * 3.14 * h);
        }
    }
}
