using System.Drawing;

namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9) Escreva um algoritmo para ler o salário mensal atual de um funcionário e o percentual de reajuste.
            // Calcular e escrever o valor do novo salário. 

            Console.Write("Digite o salário do funcionário: R$");
            double salario = double.Parse(Console.ReadLine());
            Console.Write("Digite o reajuste do salário (%): ");
            double reajuste = double.Parse(Console.ReadLine());

            salario = salario + (salario * reajuste / 100);

            Console.WriteLine($"Novo salário após o resjuste de {reajuste:N1}%: R${salario:N2}");
        }
    }
}