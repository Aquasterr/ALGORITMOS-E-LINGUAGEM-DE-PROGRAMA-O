using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Exercicio1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A: ");
            double A = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C: ");
            double C = double.Parse(Console.ReadLine());

            Console.WriteLine("Os numeros em ordem crescente são: ");
            
            if (A > B && A > C)
            {
                Console.WriteLine(A);
                if (C > B) Console.WriteLine("{0} \n{1}", C, B);
                    else Console.WriteLine("{0} \n{1}", B, C);
            }

            if (B > A && B > C)
            {
                Console.WriteLine(B);
                if (A > C) Console.WriteLine("{0} \n{1}", A, C);
                    else Console.WriteLine("{0} \n{1}", C, A);
            }

            if (C > A && C > B)
            {
                Console.WriteLine(C);
                if (A > B) Console.WriteLine("{0} \n{1}", A, B);
                    else Console.WriteLine("{0} \n{1}", B, A);
            }

        }
    }
}
