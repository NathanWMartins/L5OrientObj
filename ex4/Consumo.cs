using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    public class Consumo
    {
        private double kmInicial;
        private double kmFinal;
        private double consumoCombustivel;

        public Consumo(double kmInicial, double kmFinal, double consumoCombustivel)
        {
            this.kmInicial = kmInicial;
            this.kmFinal = kmFinal;
            this.consumoCombustivel = consumoCombustivel;
        }

        public double kmPercorrido()
        {
            return (kmFinal - kmInicial) / consumoCombustivel;
        }
    }
}
