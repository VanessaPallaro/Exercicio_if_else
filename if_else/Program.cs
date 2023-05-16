using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
             //Jogo de dados.//
             //Se dois dos dados que lançar obtiverem o mesmo valor, receberá dois pontos de bónus pelo lançamento duplo.//
             //Se os três dados que lançar obtiverem o mesmo valor, receberá seis pontos de bónus pelo lançamento triplo.//
             //Se a soma dos três dados, além de qualquer bónus, for igual a 15 ou superior, ganhará o jogo.Caso contrário, perderá//
         
            Random dado = new Random();

            int jogo1 = dado.Next(1, 7);
            int jogo2 = dado.Next(1, 7);
            int jogo3 = dado.Next(1, 7);


            int total = jogo1 + jogo2 + jogo3;
            Console.WriteLine($"Jogo de Dado: {jogo1} + {jogo2} + {jogo3} = {total}");

            //Parâmetros para ver se há dois dados iguais e acrescentar 2 pontos no total//
            if ((jogo1 == jogo2) || (jogo2 == jogo3) || (jogo1 == jogo3))
            {
                if ((jogo1 == jogo2) && (jogo2 == jogo3))
                {
                    Console.WriteLine("Você teve três dados iguais, que sorte! Ganhou mais 6 pontos!");
                    total += 6;
                    Console.WriteLine($"Total com bônus: {total}");
                }

                else
                {
                    Console.WriteLine("Você teve dois dados iguais e ganhou mais 2 pontos!");
                    total += 2;
                    Console.WriteLine($"Total com bônus: {total}");
                }
            }

            if (total >= 15)
            {
                Console.WriteLine("Você teve um total maior que 15 pontos e GANHOU!");
            }
            else if (total == 10)
            {
                Console.WriteLine("Você teve um total igual a 10 pontos e QUASE ganhou!");
            }
            else
            {
                Console.WriteLine("Você teve um total menor que 15 pontos e PERDEU!");
            }
            
        }
    }
}/*

        
