using System.Globalization;

namespace Ex2
{    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Fahrenheit: ");
            double tF = double.Parse(Console.ReadLine());

            TempC tempC = new TempC(tF);

            double t = tempC.calcularTempC(tF);

            Console.WriteLine("Temperatura em Celsisus: " +  t.ToString("F2", CultureInfo.InvariantCulture) + "°C");
        }
    }
}