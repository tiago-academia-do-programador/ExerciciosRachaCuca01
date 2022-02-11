using System;

namespace Exercicio03
{
    public class Program
    {
        /*
        * 3 - Escreva um programa que contenha uma variável: horaAtual;
        * Essa variável deverá conter a hora do dia e três mensagens deverão ser impressas na tela de acordo com a hora:
        * “Bom dia”, “Boa tarde ou “Boa noite”.
        */
        public static void Main(string[] args)
        {
            Console.Write("Por favor digite a hora atual: ");
            string strHoraAtual = Console.ReadLine();
            int horaAtual = Convert.ToInt32(strHoraAtual);
             
            Console.WriteLine();

            if (horaAtual >= 0 && horaAtual < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (horaAtual >= 12 && horaAtual < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else if (horaAtual >= 18 && horaAtual < 24)
            {
                Console.WriteLine("Boa noite!");
            }
            else
                Console.WriteLine("O nosso sistema está offline! Tente novamente mais tarde :(");

            Console.ReadKey();
        }
    }
}
