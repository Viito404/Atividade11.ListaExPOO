namespace Atividade11.ListaEx03POO
{
     internal class Program
     {
          static void Main(string[] args)
          {
               Cilindro cilindro1 = new Cilindro();

               Console.WriteLine("=====< Volume Cilindro >=====");

               Console.Write("\nEntre com o valor da altura:\n> ");
               cilindro1.altura = Convert.ToDouble(Console.ReadLine());

               Console.Write("\nEntre com o valor do raio:\n> ");
               cilindro1.raio = Convert.ToDouble(Console.ReadLine());

               Console.WriteLine(cilindro1.GerarVolumeCilindro());
               Console.ReadLine();
          }
     }
}