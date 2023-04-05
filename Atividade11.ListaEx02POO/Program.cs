namespace Atividade11.ListaEx02POO
{
     internal class Program
     {
          static void Main(string[] args)
          {
               Fahrenheit converter1 = new Fahrenheit();

               Console.WriteLine("=====< Conversão Fahrenheit >=====");

               Console.Write("\nEntre com o valor em Fahrenheit:\n> ");
               converter1.fahrenheit = Convert.ToDouble(Console.ReadLine());

               Console.WriteLine(converter1.ConverterFahrenheit());
               Console.ReadLine();
          }
     }
}