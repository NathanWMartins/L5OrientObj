namespace Ex3
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, altura;

            Console.WriteLine("Digite o raio do cilindro: ");
            raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do cilindro: ");
            altura = double.Parse(Console.ReadLine());

            Cilindro cilindro = new Cilindro(raio, altura);

            Console.WriteLine("O volume do cilindro é: " + cilindro.CalcularVolume());
        }
    }
}