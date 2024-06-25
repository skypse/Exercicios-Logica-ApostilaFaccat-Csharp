using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Escreva um algoritmo para ler o salário mensal atual de um funcionário e o 
percentual de reajuste. Calcular e escrever o valor do novo salário. */

namespace FaccatLogica_09
{
    class Exercicio_09
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o seu salário mensal: ");
            double salarioMensal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o percentual de reajuste: ");
            double percentualReajuste = Convert.ToDouble(Console.ReadLine());
            double novoSalario = salarioMensal * (1 + percentualReajuste / 100);

            Console.WriteLine($"O salário depois do reajuste é R${novoSalario:F2}");
        }
    }
}
