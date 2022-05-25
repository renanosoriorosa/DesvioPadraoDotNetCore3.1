using System;
using System.Collections.Generic;

namespace DesvioPadrao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de desvio padrão:");

            List<double> n = new List<double>();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Informa o valor "+i+":");
                double valor = Double.Parse(Console.ReadLine());
                n.Add(valor);
            }
            Console.WriteLine("aguarde, estamos calculando o desvio padrão.");
            // calcula media
            double media = 0;
            double nSomatorio = 0;
            for (int i = 0; i < n.Count; i++)
            {
                nSomatorio += n[i];
            }
            media = nSomatorio / n.Count;

            // calcula distancia
            List<double> distancias = new List<double>();

            for (int i = 0; i < n.Count; i++)
            {
                double valor = Math.Pow((n[i] - media),2);
                if (valor < 0)
                {
                    valor = valor * - 1;
                }
                distancias.Add(valor);
            }

            // soma valor das distancias
            double distanciaSomatorio = 0;
            for (int i = 0; i < n.Count; i++)
            {
                distanciaSomatorio += distancias[i];
            }

            // divisão
            double numeroDados = ((double)distanciaSomatorio / n.Count);

            //calcula desvio
            double desvioPadrao = Math.Round(Math.Sqrt(numeroDados), 2);

            Console.WriteLine("Seu desvio padrao é: "+ desvioPadrao);

        }
    }
}
