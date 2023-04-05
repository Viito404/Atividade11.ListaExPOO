using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11.ListaEx10POO
{
     internal class MediaPonderada
     {
          public decimal nota1, peso1, nota2, peso2, media;

          public decimal CalcularMediaPonderada()
          {
               media = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);
               return media;
          }
     }
}
