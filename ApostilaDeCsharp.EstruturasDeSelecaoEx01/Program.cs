using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostilaDeCsharp.EstruturasDeSelecaoEx01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numero = 5.3;
            if (numero.GetType() == typeof(double))

                Console.WriteLine("Número é fraciónário/real");
               
            Console.ReadKey();
        }
    }
}
