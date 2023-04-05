using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11.ListaEx06POO
{
     internal class Celsius
     {
          public double fahrenheit, celsius;

          public double ConverterCelsius()
          {
               fahrenheit = (celsius * 9 / 5) + 32;
               return fahrenheit;
          }
     }
}
