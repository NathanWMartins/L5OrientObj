using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    public class Volume
    {
        private double raio;

        public Volume(double raio)
        {
            this.raio = raio;
        }

        public double calcularVolume()
        {
            return (4 / 3) * 3.14 * Math.Pow(raio, 3);
        }
    }
}
