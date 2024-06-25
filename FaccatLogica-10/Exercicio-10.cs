using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*O custo de um carro novo ao consumidor é a soma do custo de fábrica com a porcentagem do 
distribuidor e dos impostos (aplicados ao custo de fábrica). Supondo que o percentual 
do distribuidor seja de 28% e os impostos de 45%, escrever um algoritmo 
para ler o custo de fábrica de um carro, calcular e escrever o custo final ao consumidor.*/

namespace FaccatLogica_10
{
    class Exercicio_10
    {
        public static void Main(string[] args)
        {
            Console.Write("Escreva o custo de fábrica: ");
            double custoDeFabrica = Convert.ToDouble(Console.ReadLine());
            double percentualDistribuidor = 28.0 / 100.0;
            double percentualImpostos = 45.0 / 100.0;
            double custoConsumidor = custoDeFabrica * (1 + percentualDistribuidor + percentualImpostos);

            Console.WriteLine($"O custo final ao consumidor é R${custoConsumidor:F2}");
        }
    }
}
