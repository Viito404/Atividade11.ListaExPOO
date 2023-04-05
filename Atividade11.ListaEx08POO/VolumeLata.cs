using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11.ListaEx08POO
{
     internal class VolumeLata
     {
          public double raio, altura, volume;

          public double CalcularVolumeLata()
          {
               volume = Math.PI * Math.Pow(raio, 2) * altura;
               return volume;
          }
     }
}
