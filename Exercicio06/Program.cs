namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double base1;
            double altura;

            Console.Write("Digite a base: ");
            base1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            double total = base1 * altura; 

            Console.WriteLine($"Área total do retângulo: {total:N2}");
        }
    }
}