namespace ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota 1: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 2: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 3: ");
            double n3 = double.Parse(Console.ReadLine());

            MediaHarmonica mh = new MediaHarmonica(n1, n2, n3);

            Console.WriteLine("A media harmonica das notas é: " + mh.calcularMedia());
        }
    }
}