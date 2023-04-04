namespace ex4
{    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quilometragem inicial: ");
            double kmI = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quilometragem final: ");
            double kmF = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o consumo de Combustível(L): ");
            double c = double.Parse(Console.ReadLine());

            Consumo cons = new Consumo(kmI, kmF, c);
            Console.WriteLine("O carro percorre " + cons.kmPercorrido() + "km por litro");
        }
    }
}