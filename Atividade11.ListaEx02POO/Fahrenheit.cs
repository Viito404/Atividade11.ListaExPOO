using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11.ListaEx02POO
{
     internal class Fahrenheit
     {
          public double fahrenheit, celsius;

          public double ConverterFahrenheit()
          {
               celsius = (fahrenheit - 32) * 5 / 9;
               return celsius;
          }

     }
}
