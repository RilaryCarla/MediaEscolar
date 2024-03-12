using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaEscolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a média do aluno: ");
            double media = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a porcentagem de presença do aluno: ");
            double presenca = double.Parse(Console.ReadLine());

            if (media >= 7 && presenca >= 75 )
            {
                Console.WriteLine("Você foi Aprovado!");
            }
            else if ( media >= 4 && presenca >= 75 )
            {
                Console.WriteLine("Você está em Recuperação!");
            }
            else if ( media >= 7 && presenca < 75 )
            {
                Console.WriteLine("Você está em Recuperação!");
            }
            else if ( media >=4 && presenca < 75 )
            {
                Console.WriteLine("Você está Retido!");
            }
            else
            {
                Console.WriteLine("Você está Retido!");
            }

            Console.ReadKey();

            // && || 

            if ( media >= 7 && presenca >= 75 || media >= 4 && presenca >= 75)
            {
                Console.WriteLine("O aluno está aprovado!");
            }
            else if ( media >= 7 && presenca < 75 || media >= 4 && presenca < 75)
            {
                Console.WriteLine("O aluno está reprovado!");
            }
            else
            {
                Console.WriteLine("O aluno está Retido");
            }
            Console.ReadKey();
        }
    }
}
