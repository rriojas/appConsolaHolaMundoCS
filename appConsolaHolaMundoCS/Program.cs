using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appConsolaHolaMundoCS
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hola Mundo!!");
      //Dividir
      int a = 10;
      int b = 3;
      double c = a / (b * 1.0);
      Console.WriteLine(a + "/" + b + "=" + c);

      Console.ReadKey();
    }
  }
}
