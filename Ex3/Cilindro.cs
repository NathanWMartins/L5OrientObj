using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class Cilindro
    {
        private double raio;
        private double altura;

        public Cilindro(double r, double h)
        {
            raio = r;
            altura = h;
        }

        public double CalcularVolume()
        {
            return Math.PI * raio * raio * altura;
        }
    }
}
