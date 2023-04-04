using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    public class TempF
    {
        private double tempC;

        public TempF(double tempC)
        {
            this.tempC = tempC;
        }

        public double calcularTempF()
        {
            return (tempC * 1.8) + 32.0;
        }
    }
}
