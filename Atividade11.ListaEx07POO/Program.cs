namespace Atividade11.ListaEx07POO
{
     internal class Program
     {
          static void Main(string[] args)
          {
               SalarioVendedor salario1 = new SalarioVendedor();

               Console.WriteLine("=====< Salario Vendedor >=====");

               Console.Write("\nEntre com o valor do salário base:\n> ");
               salario1.salarioBase = Convert.ToDouble(Console.ReadLine());

               Console.Write("\nEntre com o valor das vendas:\n> ");
               salario1.vendas = Convert.ToDouble(Console.ReadLine());

               Console.Write("\nEntre com a porcentagem da comissão:\n> ");
               salario1.comissao = Convert.ToDouble(Console.ReadLine());

               Console.Write($"\nO valor final do salário é:{salario1.CalcularSalarioVendedor()}");

          }
     }
}