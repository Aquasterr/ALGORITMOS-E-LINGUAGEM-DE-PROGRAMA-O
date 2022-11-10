using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Apresentar todos os valores numéricos inteiros impares situados na faixa de 0 a 20.
    class Program
    {
        static void Main(string[] args)
        {
            int i = -1;
            while (i < 19)
            {
                Console.WriteLine("Numero: {0}", i += 2);
            }
        }
    }
}
