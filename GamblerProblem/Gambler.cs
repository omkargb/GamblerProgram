using System;
using System.Collections.Generic;
using System.Text;

namespace GamblerProblem
{
    class Gambler
    {
        public void Gambling()
        {
            const int gameStake = 100;
            const int gameBet = 1;

            void WinOrLoss()
            {
                Random random = new Random();
                int check = random.Next(0, 2);  // 0 or 1

                if (check == 0)
                {
                    Console.WriteLine(" Gambler lost $1.");
                }
                else
                {
                    Console.WriteLine(" Gambler won $1 .");
                }
            }

            Console.WriteLine("\n Initial values : \t Stake = ${0} \t Bet per game = {1}", gameStake,gameBet);
            Console.WriteLine("\n Making a bet .. Checking Gambler win $1 or not : ");
            WinOrLoss();

        }
    }
}
