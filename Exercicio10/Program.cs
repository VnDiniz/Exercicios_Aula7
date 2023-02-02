namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o custo de fábrica do carro: R$ ");
            double custoFabrica = double.Parse(Console.ReadLine());

            Console.Write("Digite a porcentagem do distribuidor (%): ");
            double percentDistr = double.Parse(Console.ReadLine());

            Console.Write("Digite a porcentagem de impostos (%): ");
            double percentImposto = double.Parse(Console.ReadLine());

            double custoCliente = custoFabrica + (custoFabrica * (percentDistr + percentImposto) / 100);

            Console.WriteLine($"Custo final do carro ao consumidor: R$ {custoCliente:N2}");

        }
    }
}