using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{
    internal class MediaHarmonica
    {
        private double nota1;
        private double nota2;
        private double nota3;

        public MediaHarmonica(double nota1, double nota2, double nota3)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

        public double calcularMedia()
        {
            return 3 / ((1 / nota1) + (1 / nota2) + (1 / nota3));
        }
    }
}
