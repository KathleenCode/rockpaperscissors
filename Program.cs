// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Math;

namespace ROCKPAPERSCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer;, 
            string inputCpu;
            int randint;

            Console.WriteLine("Choose between ROCK, PAPER and SCISSORS: ");
            inputPlayer = Console.ReadLine();

            Random rnd = new Random();
            randint = rnd.Next(1, 4);

            bool playagain = true;

            while (playagain) {
                int  scorePlayer = 0;
                int  scoreCpu = 0; ;

                while (scoreCpu < 3 && scorePlayer < 3)
                {
                    switch (randint)
                    {
                        case 1:
                            inputCpu = "ROCK";
                            Console.WriteLine("Computer chose Rock");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Draw \n\n");
                            } else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine('PLAYER WINS \n\n');
                                scorePlayer++;
                            } else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU wins");
                                scoreCpu++;
                            }
                            break;
                        case 2:
                            inputCpu = "PAPER";
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Draw \n\n");
                            } else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine('PLAYER WINS \n\n');
                                scorePlayer++;
                            } else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU wins");
                                scoreCpu++;
                            }
                            break;
                        case 3:
                            inputCpu = "SCISSORS";
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("Draw \n\n");
                            } else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine('PLAYER WINS \n\n');
                                scorePlayer++;
                            } else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU wins");
                                scoreCpu++;
                            }
                            break ;
                        default:
                            Console.WriteLine("Invalid Entry");
                            break ;
                    }
                    Console.Writeline("\n\n SCORES: \tPLAYER: \t{0} \tCPU:\t{1}", scorePlayer, scoreCpu);
                }
                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player Won");
                } else if (scoreCpu == 3)
                {
                    Console.WriteLine("Cpu WON");
                } else {}
                Console.WriteLine("Do you want to play again (y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playagain = true;
                    Console.Clear();
                } else if (loop == "n")
                {
                    playagain = false;
                } else {

                }
            }
        }
    }
}



// {
//             string inputPlayer, inputCPU;
//             int randomInt;
            
//             bool playAgain = true;
 
//             while (playAgain)
//             {
 
//                 int scorePlayer = 0;
//                 int scoreCPU = 0;
 
//                 while (scorePlayer < 3 && scoreCPU < 3)
//                 {
                    
 
//                     Console.Write("Choose between ROCK, PAPER and SCISSORS:    ");
//                     inputPlayer = Console.ReadLine();
//                     inputPlayer = inputPlayer.ToUpper();
 
//                     Random rnd = new Random();
 
//                     randomInt = rnd.Next(1, 4);
 
//                     switch (randomInt)
//                     {
//                         case 1:
//                             inputCPU = "ROCK";
//                             Console.WriteLine("Computer chose ROCK");
//                             if (inputPlayer == "ROCK")
//                             {
//                                 Console.WriteLine("DRAW!!\n\n");
//                             }
//                             else if (inputPlayer == "PAPER")
//                             {
//                                 Console.WriteLine("PLAYER WINS!!\n\n");
//                                 scorePlayer++;
//                             }
//                             else if (inputPlayer == "SCISSORS")
//                             {
//                                 Console.WriteLine("CPU WINS!!\n\n");
//                                 scoreCPU++;
//                             }
//                             break;
//                         case 2:
//                             inputCPU = "PAPER";
//                             Console.WriteLine("Computer chose PAPER");
//                             if (inputPlayer == "PAPER")
//                             {
//                                 Console.WriteLine("DRAW!!\n\n");
//                             }
//                             else if (inputPlayer == "ROCK")
//                             {
//                                 Console.WriteLine("CPU WINS!!\n\n");
//                                 scoreCPU++;
//                             }
//                             else if (inputPlayer == "SCISSORS")
//                             {
//                                 Console.WriteLine("PLAYER WINS!!\n\n");
//                                 scorePlayer++;
//                             }
//                             break;
//                         case 3:
//                             inputCPU = "SCISSORS";
//                             Console.WriteLine("Computer chose SCISSORS");
//                             if (inputPlayer == "SCISSORS")
//                             {
//                                 Console.WriteLine("DRAW!!\n\n");
//                             }
//                             else if (inputPlayer == "ROCK")
//                             {
//                                 Console.WriteLine("PLAYER WINS!!\n\n");
//                                 scorePlayer++;
//                             }
//                             else if (inputPlayer == "PAPER")
//                             {
//                                 Console.WriteLine("CPU WINS!!\n\n");
//                                 scoreCPU++;
//                             }
//                             break;
//                         default:
//                             Console.WriteLine("Invalid entry!");
//                             break;
//                     }
 
//                     Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}",scorePlayer, scoreCPU);
 
//                 }
 
//                 if (scorePlayer == 3)
//                 {
//                     Console.WriteLine("Player WON!");
//                 }
//                 else if (scoreCPU == 3)
//                 {
//                     Console.WriteLine("CPU WON!");
//                 }
//                 else
//                 {
 
//                 }
 
//                 Console.WriteLine("Do you want to play again?(y/n)");
//                 string loop = Console.ReadLine();
//                 if (loop == "y")
//                 {
//                     playAgain = true;
//                     Console.Clear();
//                 }
//                 else if (loop == "n")
//                 {
//                     playAgain = false;
//                 }
//                 else
//                 { 
                
//                 }
 
//             }
//         }
 