using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Violacao
{
    public class CalculoArea
    {
        private static void ObterAreaRegangulo(Retangulo ret)
        {
            Console.Clear();
            Console.WriteLine("Cálculo da área do Retângulo");
            Console.WriteLine();
            Console.WriteLine(ret.Altura + " * " + ret.Largura);
            Console.WriteLine();
            Console.WriteLine(ret.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {
            var quad = new Quadrado()
            {
                Altura = 10,
                Largura = 5
            };

            ObterAreaRegangulo(quad);
        }
    }
}
