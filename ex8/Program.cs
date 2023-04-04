namespace ex8
{    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio da lata: ");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura da lata: ");
            double altura = double.Parse(Console.ReadLine());

            Lata l = new Lata(r, altura);

            Console.WriteLine("Volume da lata: " + l.calcularVolume());
        }
    }
}