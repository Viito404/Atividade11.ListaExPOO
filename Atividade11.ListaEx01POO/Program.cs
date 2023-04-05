namespace Atividade11.ListaEx01POO
{
     internal class Program
     {
          static void Main(string[] args)
          {
               Console.WriteLine("=====< Volume Caixa >=====");

               Caixa caixa1 = new Caixa();

               Console.Write("\nEntre com o valor da Altura:\n> ");
               caixa1.altura = Convert.ToDecimal(Console.ReadLine());

               Console.Write("\nEntre com o valor da Largura:\n> ");
               caixa1.largura = Convert.ToDecimal(Console.ReadLine());

               Console.Write("\nEntre com o valor do Comprimento:\n> ");
               caixa1.comprimento = Convert.ToDecimal(Console.ReadLine());

               Console.WriteLine($"\n\nO volume da caixa é: {caixa1.ObterVolumeCaixa()} ");
          }
     }

}