using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11.ListaEx07POO
{
     internal class SalarioVendedor
     {
          public double salarioBase, vendas, comissao, salarioFinal;

          public double CalcularSalarioVendedor()
          {
               salarioFinal = salarioBase + vendas * (comissao / 100);
               return salarioFinal;
          }

     }
}
