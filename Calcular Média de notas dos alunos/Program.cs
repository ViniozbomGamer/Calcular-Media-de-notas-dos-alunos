using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Média_de_notas_dos_alunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, resultado;

            Console.WriteLine("Digite a nota do 1º bimestre");
            nota1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a nota do 2º bimestre");
            nota2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a nota do 3º bimestre");
            nota3 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a nota do 4º bimestre");
            nota4 = double.Parse(Console.ReadLine());

            resultado = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("Média do aluno = " + resultado);

            Console.ReadKey();

        }
    }
}
