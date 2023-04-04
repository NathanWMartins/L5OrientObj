namespace ex10
{    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota 1: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso 1: ");
            double p1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 2: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso 2: ");
            double p2 = double.Parse(Console.ReadLine());

            mediaPeso mP = new mediaPeso(n1, n2, p1, p2);

            Console.WriteLine("A média ponderada das notas é: " + mP.calcularMedia());
        }
    }
}