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
            string nome;
            double n1, n2, n3;
            Console.WriteLine("Digite o Nome do Aluno: ");
            nome = (Console.ReadLine());

            Console.WriteLine("Digite a nota da primeira prova: ");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da segunda prova: ");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da terceira prova: ");
            n3 = double.Parse(Console.ReadLine());

            n1 = n1 * 2;
            n2 = n2 * 4;
            n3 = n3 * 6;
            double media = (n1 + n2 + n3) / 12;


            Console.WriteLine("Nome do Aluno: {0}", nome);
            Console.WriteLine("Media Final: {0}", media);
        }
    }
}
