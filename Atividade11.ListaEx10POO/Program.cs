namespace Atividade11.ListaEx10POO
{
     internal class Program
     {
          static void Main(string[] args)
          {
               MediaPonderada mediap1 = new MediaPonderada();

               Console.WriteLine("===== < Média Ponderada >=====");

               Console.Write("\nEntre com a primeira nota:\n> ");
               mediap1.nota1 = Convert.ToDecimal(Console.ReadLine());

               Console.Write("\nEntre com o primeiro peso:\n> ");
               mediap1.peso1 = Convert.ToDecimal(Console.ReadLine());

               Console.Write("\nEntre com a segunda nota:\n> ");
               mediap1.nota2 = Convert.ToDecimal(Console.ReadLine());

               Console.Write("\nEntre com segundo peso:\n> ");
               mediap1.peso2 = Convert.ToDecimal(Console.ReadLine());

               Console.WriteLine($"\nA média ponderada das notas é:{mediap1.CalcularMediaPonderada()}");
          }
     }
}