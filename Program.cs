﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class HumanPlayer
    {
        private int points;
        public HumanPlayer(int initial)
        {
            points = initial;
        }
        public int GetPoints()
        {
            return points;
        }
        public void WinRound()
        {
            points += 5;
        }
        public void LoseRound()
        {
            points -= 5;
        }
        public string HumanDecision()
        {
            string s = Console.ReadLine();
            while(!(s.Equals("rock")|| s.Equals("paper")|| s.Equals("scissors")))
            {
                Console.WriteLine("Invalid Input");
                s =Console.ReadLine();
            }
            return s;
        }
    }
    class ComputerPlayer
    {
        public string ComputerDecision()
        {
            Random rnd = new Random();
            int rnd_num = rnd.Next(0, 3);
            if (rnd_num == 0)
                return "rock";
            if (rnd_num == 1)
                return "paper";
            return "scissors";
        }
    }
    class RockPaperScissors
    {
        static void Main(string[] args)
        {
            HumanPlayer h = new HumanPlayer(5);
            ComputerPlayer c = new ComputerPlayer();

            while (true)
            {
                Console.WriteLine("****Rock Paper Scissors, Start!!****");
                Console.WriteLine("You have " + h.GetPoints() + " Points");
               
                Console.WriteLine("Please input your choice : rock, paper or scissors.");
                string hIn = h.HumanDecision();
                string cIn = c.ComputerDecision();
                Console.WriteLine("Your Decision : " + hIn);
                Console.WriteLine("Computer Decision : " + cIn);
                if (hIn.Equals(cIn))
                {
                    Console.WriteLine("It's a Tie");

                }
                else
                {
                    if ((hIn.ToLower().Equals("scissors") && cIn.ToLower().Equals("paper"))||(hIn.ToLower().Equals("paper") && cIn.ToLower().Equals("rock"))||(hIn.ToLower().Equals("rock") && cIn.ToLower().Equals("scissors")))
                    {
                        Console.WriteLine("You Win");
                        h.WinRound();
                    }
                    else
                    {
                        Console.WriteLine("You Lose!");
                        h.LoseRound();
                    }
                }
                if (h.GetPoints() <= 0)
                {
                    Console.WriteLine("Sorry, you don't have enough points, thanks for playing.\nThank you for playing!");
                    break;
                }
                Console.WriteLine("-->Play again? Input y to coninue, or n to exit");
                char t = Console.ReadLine()[0];
                if (t != 'y')
                    break;

            }
            Console.ReadKey();

        }
    }
}