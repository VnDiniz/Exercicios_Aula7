namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totEleitores = 1000;
            double votosBrancos = 50;
            double votosNulos = 100;
            double votosValidos = totEleitores - (votosBrancos + votosNulos);

            Console.WriteLine($"Total de Eleitores: {totEleitores}");
            Console.WriteLine($"Total de votos em brancos (%): {(votosBrancos / totEleitores) * 100}%");
            Console.WriteLine($"Total de votos nulos (%): {(votosNulos / totEleitores) * 100}%");
            Console.WriteLine($"Total de votos válidos (%): {(votosValidos / totEleitores) * 100}%");
        }
    }
}