using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class TempC
    {
        private double tempF;

        public TempC(double tempF)
        {
            this.tempF = tempF;
        }

        public double calcularTempC(double tempF)
        {
            return (tempF - 32) / 1.8;
        }
    }
}
