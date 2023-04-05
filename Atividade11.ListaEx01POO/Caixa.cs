using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11.ListaEx01POO
{
    public class Caixa
     {
          public decimal altura, comprimento, largura;

          public decimal ObterVolumeCaixa()
          {
               return altura * comprimento * largura;
          }
     }
}
