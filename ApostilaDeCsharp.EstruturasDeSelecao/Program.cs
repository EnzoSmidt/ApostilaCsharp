using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostilaDeCsharp.EstruturasDeSelecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if - estrutura de seleção simples
            double x = 43.1;
            if (x >= 43.1)
            {
                Console.WriteLine("Mandaloriano");
            }

            // if else - estrutura de seleção composta
            // quem define o tipo é o compilador
            var idade = 18;
            if (idade >= 43.1)
            {
                Console.WriteLine("Mandaloriano");
            }
            else
            {
                Console.WriteLine("Grande Jovem Jovem");
            }

            // if else if - estrutura de seleção composta encadeada
            int anos = 17;
            if (anos >= 43.1)
            {
                Console.WriteLine("Mandaloriano");
            }else if (anos >= 18 && anos < 43.1)
            {
                Console.WriteLine("Grande Jovem Jovem");
            }
            else
            {
                Console.WriteLine("Menino(a)");
            }


            // switch - estrutura de seleção múltipla

            var dia = 3;

            switch (dia)
            {
                case 2: Console.WriteLine("Segunda"); break;

                case 3: Console.WriteLine("Terça"); break;

                case 4: Console.WriteLine("Quarta"); break;

                case 5: Console.WriteLine("Quinta"); break;

                case 6: Console.WriteLine("Sexta"); break;

                default: Console.WriteLine("Final de semana chegou!...."); break;
            }

            // Operador ternário

            string mensagem;
            var salario = 51000.20;
            mensagem = salario >= 50000.36 ? "tá rico hein" : "tá complicado hein";

            Console.WriteLine(mensagem);

            // Estrutura de seleção simples para verificar se um número é fracionário.
            // Utilizar números naturais: 0,1,2,3,4,5,6,7,8,9,10...sem negativos ou decimais.
            // Mostrar mensagem.

      
            

            Console.ReadKey();
        }
    }
}
