namespace Atividade11.ListaEx05POO
{
     internal class Program
     {
          static void Main(string[] args)
          {
               VolumeEsfera esfera1 = new VolumeEsfera();

               Console.WriteLine("=====< Volume Esfera >=====");

               Console.Write("\nEntre com o valor do raio:\n> ");
               esfera1.raio = Convert.ToDouble(Console.ReadLine());

               Console.WriteLine($"\nO volume da esfera é:{esfera1.CalcularVolumeEsfera()}");
          }
     }
}