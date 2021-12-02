using System;

namespace rps
{
    class Program
    {
        static void Main(string[] args)
        {
            void rps(string player1, string player2){
                
                if(player1 == "Rock" && player2 == "Scissors"){
                    Console.WriteLine("Player 1 wins");
                }
                else if(player1 == "Scissors" && player2 == "Rock"){
                    Console.WriteLine("Player 2 wins");
                }
                else if(player1 == "Paper" && player2 == "Rock"){
                    Console.WriteLine("Player 1 wins");
                }
                else if(player1 == "Rock" && player2 == "Paper"){
                    Console.WriteLine("Player 2 wins");
                }
                else if(player1 == "Scissors" && player2 == "Paper"){
                    Console.WriteLine("Player 1 wins");
                }
                else if(player1 == "Paper" && player2 == "Scissors"){
                    Console.WriteLine("Player 2 wins");
                }
                else{
                    Console.WriteLine("TIE");
                }

            }

            bool state = true;
            Console.WriteLine("Type 1 to play or 0 to quit:");
            string value = Console.ReadLine();
            
            do{
                switch(value){
                    case "0":
                        state = false;
                        break;
                    default:
                        Console.WriteLine("Player 1 input: "); string player1 = Console.ReadLine();
                        Console.WriteLine("Player 2 input: "); string player2 = Console.ReadLine();
                        rps(player1, player2);
                        break;
                }

            }while(state);
        }
    }
}
