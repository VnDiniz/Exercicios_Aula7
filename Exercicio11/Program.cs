namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite a quantidade carros vendidos pelo funcionário: ");
            int qntdVendas = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor total das vendas: R$ ");
            double valorVendas = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do sálario fixo do funcionário(a): R$ ");
            double salarioFixo = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da comissão por carro vendido: R$ ");
            double comissao = double.Parse(Console.ReadLine());

            double salarioFinal = salarioFixo + (comissao * qntdVendas) + (valorVendas * 0.05);

            Console.WriteLine(new String('-', 70));
            Console.WriteLine($"O salário final do vendedor é: R$ {salarioFinal:N2}");

        }
    }
}