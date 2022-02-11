using System;

namespace Exercicio04
{
    /*
     * 4 - Desenvolver um algoritmo que leia 5 valores inteiros;
     * Calcule e escreva:
     *  A média aritmética dos valores lidos;
     *  A quantidade de valores positivos;
     *  A quantidade de valores negativos.
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            int valoresPositivos = 0, valoresNegativos = 0;
            int somaDosValores = 0;
            double mediaAritmetica;

            for (int i = 1; i <= 5; i++)
            {

                Console.Write("Por favor digite o {0}o valor: ", i);
                string strValorAtual = Console.ReadLine();
                int valorAtual = Convert.ToInt32(strValorAtual);

                if (valorAtual >= 0)
                    valoresPositivos++;
                else
                    valoresNegativos++;

                somaDosValores += valorAtual;
            }

            mediaAritmetica = somaDosValores / 5;

            Console.WriteLine();

            Console.WriteLine("A Média Aritmética é: " +  mediaAritmetica);
            Console.WriteLine("A quantidade de valores positivos é: " +  valoresPositivos);
            Console.WriteLine("A quantidade de valores negativos é: " +  valoresNegativos);

            Console.ReadKey();
        }
    }
}
