namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a idade da pessoa: ");
            int idade = int.Parse(Console.ReadLine());

            double meses = idade * 12;
            double dias = idade * 365;


            Console.WriteLine("Idade da pessoa expressa em:");
            Console.WriteLine($"Meses: {meses}");
            Console.WriteLine($"Dias: {dias}");
        }
    }
}