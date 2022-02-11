using System;

namespace Exercicio05
{
    public class Program
    { 
       /*
       * 5 - Criar um jogo simplificado onde dois jogadores podem jogar dados;
       * 
       * Regras:
       *    O jogo deverá solicitar o nome dos dois jogadores;
       *    O jogo terá 3 rodadas; o jogador que tirar o maior número nos dados nessas 3 rodadas vence.
       *    Em caso de empate (onde os dois tiram o mesmo número), nenhum jogador pontuará.
       *    Os números permitidos vão de 0 à 6;
       *    
       * A aplicação informará qual dos jogadores tirou o maior número.
       */
        public static void Main(string[] args)
        {
            Console.Write("Digite o nome do primeiro jogador: ");
            string jogador1 = Console.ReadLine();
            
            Console.Write("Digite o nome do segundo jogador: ");
            string jogador2 = Console.ReadLine();

            int pontuacaoJogador1 = 0, pontuacaoJogador2 = 0;

            for (int i = 1; i <= 3; i++)
            {
                Console.Clear();

                Console.Write("{0}, por favor faça a {1}a jogada: ", jogador1, i);
                string strNumeroDado1 = Console.ReadLine();
                int numeroDado1 = Convert.ToInt32(strNumeroDado1);

                Console.WriteLine();

                Console.Write("{0}, por favor faça a {1}a jogada: ", jogador2, i);
                string strNumeroDado2 = Console.ReadLine();
                int numeroDado2 = Convert.ToInt32(strNumeroDado2);

                Console.WriteLine();

                if (numeroDado1 > numeroDado2)
                {
                    Console.WriteLine("O jogador {0} jogou {1} e venceu a {2}ª rodada!", jogador1, numeroDado1, i);
                    pontuacaoJogador1++;
                }
                else if (numeroDado2 > numeroDado1)
                {
                    Console.WriteLine("O jogador {0} jogou {1} e venceu a {2}ª rodada!", jogador2, numeroDado2, i);
                    pontuacaoJogador2++;
                }
                else if (numeroDado1 == numeroDado2)
                    Console.WriteLine("Essa rodada foi um empate!");

                Console.ReadKey();
            }

            Console.WriteLine();

            if (pontuacaoJogador1 > pontuacaoJogador2)
                Console.WriteLine("Parabéns {0}! Você ganhou o jogo!", jogador1);
            else if (pontuacaoJogador2 > pontuacaoJogador1)
                Console.WriteLine("Parabéns {0}! Você ganhou o jogo!", jogador2);
            else
                Console.WriteLine("Houve um empate definitivo, tentem novamente!");

            Console.ReadKey();
        }
    }
}
