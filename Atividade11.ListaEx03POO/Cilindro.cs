using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11.ListaEx03POO
{
     internal class Cilindro
     {
          public double altura, raio, volume;

          public double GerarVolumeCilindro()
          {
               return volume = Math.PI * Math.Pow(raio, 2) * altura; 
          }


     }
}
