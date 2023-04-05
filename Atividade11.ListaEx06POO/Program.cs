namespace Atividade11.ListaEx06POO
{
     internal class Program
     {
          static void Main(string[] args)
          {
               Celsius converter1 = new Celsius();

               Console.WriteLine("===== < Conversão Celsius >=====");

               Console.Write("\nEntre com o valor em Celsius:\n> ");
               converter1.celsius = Convert.ToDouble(Console.ReadLine());

               Console.WriteLine(converter1.ConverterCelsius());
               Console.ReadLine();
          }
     }
}