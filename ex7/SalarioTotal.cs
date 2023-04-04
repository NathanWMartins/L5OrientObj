using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    internal class SalarioTotal
    {
        private double salario;
        private double vendas;
        private double comissao;

        public SalarioTotal(double salario, double vendas, double comissao)
        {
            this.salario = salario;
            this.vendas = vendas;
            this.comissao = comissao;
        }

        public double calcularSalarioFinal()
        {
            return salario + ((comissao / 100) * vendas);
        }
    }
}
