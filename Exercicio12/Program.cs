namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a temperatura em Fahrenheit: ");
            double tempFahrenheit = double.Parse(Console.ReadLine());

            double tempCelcius = (5 * (tempFahrenheit - 32.0)) / 9;

            Console.WriteLine($"Valor correspondente em graus Celsius: {tempCelcius:N1} °C");
        }
    }
}