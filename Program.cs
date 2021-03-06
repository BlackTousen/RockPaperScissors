﻿using System;

namespace RockPaperScissors
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int player = 0;
            int cpu = 0;
            RPS(player, cpu);
        }
        static void RPS(int player, int cpu)
        {
            if (player >= 3) { Console.WriteLine("Player Wins!"); }
            else if (cpu >= 3) { Console.WriteLine("Computer Wins!"); }
            else
            {
                Console.WriteLine($@"
----------------------
| Player: {player} | CPU: {cpu} |
----------------------
What would you like to throw?
1) Rock
2) Paper
3) Scissors
First to 3 wins!
            ");
                string answer = Console.ReadLine();
                Throw(answer, player, cpu);
            }


        }
        static void Throw(string answer, int player, int cpu)
        {
            if (answer != "1" && answer != "2" && answer != "3")
            {
                Console.WriteLine("Not a valid option...");
                RPS(player, cpu);

            }
            string cpuAnswer = cpuThrow();

            if (answer == "1" && cpuAnswer == "2") { Console.WriteLine("Rock vs Paper"); pointCPU(player, cpu); }
            else if (answer == "2" && cpuAnswer == "3") { Console.WriteLine("Paper vs Scissors"); pointCPU(player, cpu); }
            else if (answer == "3" && cpuAnswer == "1") { Console.WriteLine("Scissors vs Rock"); pointCPU(player, cpu); }
            else if (cpuAnswer == "1" && answer == "2") { Console.WriteLine("Paper vs Rock"); pointPlayer(player, cpu); }
            else if (cpuAnswer == "2" && answer == "3") { Console.WriteLine("Scissors vs Paper"); pointPlayer(player, cpu); }
            else if (cpuAnswer == "3" && answer == "1") { Console.WriteLine("Rock vs Scissors"); pointPlayer(player, cpu); }
            else { Console.WriteLine("Tie!"); Tie(player, cpu); }
        }
        static string cpuThrow()
        {
            Random r = new Random();
            string choice = $"{r.Next(1, 3)}";
            return choice;
        }
        static void Tie(int player, int cpu)
        {
            RPS(player, cpu);
        }
        static void pointPlayer(int player, int cpu)
        {
            player++;
            RPS(player, cpu);
        }
        static void pointCPU(int player, int cpu)
        {
            cpu++;
            RPS(player, cpu);
        }
    }
}
