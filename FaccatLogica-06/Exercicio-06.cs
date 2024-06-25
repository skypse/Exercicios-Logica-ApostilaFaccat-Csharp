using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaccatLogica_06
{
    class Exercicio_06
    {
        public static void Main(string[]args)
        {
            Console.Write("Digite a base do retângulo: ");
            double baseRetangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura do retângulo: ");
            double alturaRetangulo = Convert.ToDouble(Console.ReadLine());


            double area = baseRetangulo * alturaRetangulo;
            Console.WriteLine($"A área do retângulo é: {area}");
        }
    }
}
