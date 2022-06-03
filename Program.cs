using System;
using System.Collections.Generic;
using System.Text;

namespace JokemPowFiap
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int escolhadojogador;
            Console.WriteLine("*********");
            Console.WriteLine("**Jokem**");
            Console.WriteLine("*********");
           
            Console.WriteLine();
            Console.WriteLine("***Opções do Jogo***");
            Console.WriteLine();
            Console.WriteLine("***[1] Pedra***");
            Console.WriteLine("***[2] Papel***");
            Console.WriteLine("***[3] Tesoura***");
            Console.WriteLine();
            Console.WriteLine("Qual a sua escolha");
            escolhadojogador = Convert.ToInt32(Console.ReadLine());
            //Escolha do computador
            int escolhaComputador = new Random().Next(1,4);
            switch (escolhadojogador)
            {
                    case 1:
                    Console.WriteLine(" O Jogador escolheu pedra");
                    switch(escolhaComputador)
                    {
                        case 1:
                            Console.WriteLine("O computador escolheu pedra");
                            Console.WriteLine("Deu empate");
                            break;
                            
       
                        case 2:
                            Console.WriteLine("O computador escolheu papel");
                            Console.WriteLine("O computador ganhou");
                            break;
                        case 3:
                            Console.WriteLine("O computador escolheu Tesoura");
                            Console.WriteLine("O Jogador ganhou");
                            break;
                    }
                    break;

                
                    case 2:
                    Console.WriteLine("O jogador escolheu papel");
                    switch(escolhaComputador)
                    { case 1:
                            Console.WriteLine("O computador escolheu pedra");
                            Console.WriteLine("O jogador ganhou");
                            break;
                      case 2:
                            Console.WriteLine("O computador escolheu papel");
                            Console.WriteLine("Deu empate");
                            break;
                      case 3:
                            Console.WriteLine("O computador escolheu Tesoura");
                            Console.WriteLine("O jogador ganhou");
                            break;
                    }
                    break;


                    case 3:
                    Console.WriteLine("O jogador escolheu tesoura");
                    switch(escolhaComputador)
                    { case 1:
                            Console.WriteLine("O computador escolheu tesoura");
                            Console.WriteLine("Deu empate");
                            break;
                      case 2:
                            Console.WriteLine("O computador escolheu papel");
                            Console.WriteLine("O jogador ganhou");
                            break;
                      case 3:
                            Console.WriteLine("O computador escolheu Tesoura");
                            Console.WriteLine("Deu empate");
                            break;
                    
                    }
                    break;

                    default:
                    Console.WriteLine("Nenhuma da opções");
                    break;
            }
            Console.ReadKey();


        }
    }
}
