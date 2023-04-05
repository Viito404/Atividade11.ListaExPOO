namespace Atividade11.ListaEx09POO
{
     internal class Program
     {
          static void Main(string[] args)
          {
               MediaHarmonica mediah1 = new MediaHarmonica();
               Console.WriteLine("===== < Média Harmônica >=====");

               Console.Write("\nEntre com a primeira nota:\n> ");
               mediah1.nota1 = Convert.ToDecimal(Console.ReadLine());

               Console.Write("\nEntre com a segunda nota:\n> ");
               mediah1.nota2 = Convert.ToDecimal(Console.ReadLine());

               Console.Write("\nEntre com a terceira nota:\n> ");
               mediah1.nota3 = Convert.ToDecimal(Console.ReadLine());

               Console.Write("\nEntre com a quarta nota:\n> ");
               mediah1.nota4 = Convert.ToDecimal(Console.ReadLine());

               Console.Write($"\nA média harmônica das notas é:{mediah1.CalcularMediaHarmonica()}");
          }
     }
}