namespace ex5
{    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio da esfera: ");
            double raio = double.Parse(Console.ReadLine());

            Volume v = new Volume(raio);

            Console.WriteLine("Volume do cilindro: " + v.calcularVolume);
        }
    }
}