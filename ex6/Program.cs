using System.Globalization;

namespace ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Celsius: ");
            double tC = double.Parse(Console.ReadLine());

            TempF tempF = new TempF(tC);

            double tf = tempF.calcularTempF();
            Console.WriteLine("Temperatura em Fahrenheit: " + (tf.ToString("F2", CultureInfo.InvariantCulture)));
        }
    }
}