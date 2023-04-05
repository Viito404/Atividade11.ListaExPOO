using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11.ListaEx05POO
{
     internal class VolumeEsfera
     {
         public double raio, volume;

          public double CalcularVolumeEsfera()
          {
               return volume = (4 * Math.PI * Math.Pow(raio, 3)) / 3;
          }
     }
}
