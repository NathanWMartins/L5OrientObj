using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    public class mediaPeso
    {
        private double nota1;
        private double nota2;
        private double peso1;
        private double peso2;

        public mediaPeso(double nota1, double nota2, double peso1, double peso2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.peso1 = peso1;
            this.peso2 = peso2;
        }

        public double calcularMedia()
        {
            return Math.Round(((nota1 * peso1) + (nota2 * peso2)) / (peso1 + peso2), 2);
        }
    }
}
