namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Digite o número: ");
            numero = int.Parse(Console.ReadLine());
            int antecessor = numero - 1;
            Console.WriteLine($"O antencessor de {numero} é {antecessor}");
        }
    }
}