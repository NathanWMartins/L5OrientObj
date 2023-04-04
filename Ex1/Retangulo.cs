using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Retangulo
    {
        private double altura;
        private double largura;
        private double comprimento;

        public Retangulo(double altura, double largura, double comprimento)
        {
            this.altura = altura;
            this.largura = largura;
            this.comprimento = altura;
        }
        public double CalcularVolume()
        {
            return altura * largura * comprimento;
        }
    }
}
