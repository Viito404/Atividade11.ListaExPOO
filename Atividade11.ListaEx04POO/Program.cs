namespace Atividade11.ListaEx04POO
{
     internal class Program
     {
          static void Main(string[] args)
          {
               ConsumoCombustivel consumo1 = new ConsumoCombustivel();

               Console.WriteLine("=====< Consumo Combustível >=====");

               Console.Write("\nEntre com a quilometragem inicial:\n> ");
               consumo1.quilometragemInicial = Convert.ToDouble(Console.ReadLine());

               Console.Write("\nEntre com a quilometragem final:\n> ");
               consumo1.quilometragemFinal = Convert.ToDouble(Console.ReadLine());

               Console.WriteLine("\nEntre com a quantidade de litros gasta para encher o tanque:\n> ");
               consumo1.ConsumoLitro = Convert.ToDouble(Console.ReadLine());

               Console.WriteLine($"\nO consumo médio de combustível é: {consumo1.CalcularConsumo()}km/l");
               Console.ReadLine();
          }
     }
}