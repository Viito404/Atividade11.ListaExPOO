namespace Atividade11.ListaEx08POO
{
     internal class Program
     {
          static void Main(string[] args)
          {
               static void Main(string[] args)
               {
                    VolumeLata lata1 = new VolumeLata();

                    Console.WriteLine("=====< Volume Lata >=====");

                    Console.Write("\nEntre com a altura da lata:\n> ");
                    lata1.altura = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nEntre com o raio da lata:\n> ");
                    lata1.raio = Convert.ToDouble(Console.ReadLine());

                    Console.Write($"\nO volume a lata é:{lata1.CalcularVolumeLata()}");
               }
          }
     }
}