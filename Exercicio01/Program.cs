using System;

namespace Exercicio01
{
    public class Program
    {
        /*
       * 1 - Desenhe um retângulo com asteriscos;
       * Considere que o primeiro input é a largura do retângulo,
       * e o segundo input é a altura.
       */
        public static void Main(string[] args)
        {
            Console.Write("Digite a largura do retângulo: ");
            string strLargura = Console.ReadLine();
            int largura = Convert.ToInt32(strLargura);

            Console.Write("Digite a altura do retângulo: ");
            string strAltura = Console.ReadLine();
            int altura = Convert.ToInt32(strAltura);

            Console.WriteLine();

            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < largura; j++)
                    Console.Write("*");

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
