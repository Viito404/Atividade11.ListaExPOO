using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11.ListaEx09POO
{
     internal class MediaHarmonica
     {
          public decimal nota1, nota2, nota3, nota4, media;

          public decimal CalcularMediaHarmonica()
          {
               media = (nota1 + nota2 + nota3 + nota4) / 4;
               return media;
          }
     }
}
