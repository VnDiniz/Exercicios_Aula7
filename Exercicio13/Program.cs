namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as notas do aluno:");

            Console.Write("Nota 1: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.Write("Nota 3: ");
            double nota3 = double.Parse(Console.ReadLine());

            double mediaFinal = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5)) / 10;

            Console.WriteLine(new String('-', 40));
            Console.WriteLine($"A média final do aluno(a) é: {mediaFinal:N1}");
        }
    }
}