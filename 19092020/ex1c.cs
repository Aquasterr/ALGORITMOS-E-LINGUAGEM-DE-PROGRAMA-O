using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Apresentar todos os números divisíveis por 4 que sejam menores que 30. Iniciar a contagem com o valor 1 (um).
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 30)
            {
                i++;
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
