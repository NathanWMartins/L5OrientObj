namespace ex7
{    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o salario do vendedor: ");
            double s = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total em vendas: ");
            double v = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a porcentagem da comissão: ");
            double c = double.Parse(Console.ReadLine());

            SalarioTotal salarioT = new SalarioTotal(s, v, c);

            Console.WriteLine("Salario Final do vendedor: R$" + salarioT.calcularSalarioFinal());
        }
    }
}