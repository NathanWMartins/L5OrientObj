namespace Ex1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Comprimento: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura: ");
            double l = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura: ");
            double h = double.Parse(Console.ReadLine());

            Retangulo r = new Retangulo(h, l, c);
            double volume = r.CalcularVolume();

            Console.WriteLine("Volume do retangulo: " + volume);
        }
    }
}