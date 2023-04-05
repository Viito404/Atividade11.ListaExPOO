using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11.ListaEx04POO
{
     internal class ConsumoCombustivel
     {
          public double quilometragemInicial, quilometragemFinal, ConsumoLitro;

          public double CalcularConsumo()
          {
               return (quilometragemFinal - quilometragemInicial) / ConsumoLitro;
          }

     }
}
