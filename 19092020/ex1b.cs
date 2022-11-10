using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Apresentar o total da soma dos cem primeiros números inteiros, representados pela sequencia 1+2+3+4+5+6+7+...+97+98+99+100.
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int num = 0;
            while (i <= 100)
            {
                Console.WriteLine(num);
                i++;
                num = num + i;
            }
            
        }
    }
}
