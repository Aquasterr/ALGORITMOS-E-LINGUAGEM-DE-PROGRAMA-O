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
            Console.WriteLine("Digite a Primeira Nota: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Segunda Nota: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Terceira Nota: ");
            double n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Quarta Nota: ");
            double n4 = double.Parse(Console.ReadLine());

            double media = (n1 + n2 + n3 + n4) / 4;

            if (media >= 5)
            {
                Console.WriteLine("A Média do aluno é de: {0}", media);
                Console.WriteLine("O Aluno está aprovado!");
            }
            else
            {
                Console.WriteLine("A Média do aluno é de: {0}", media);
                Console.WriteLine("O Aluno está reprovado.");
            }
        }
    }
}
