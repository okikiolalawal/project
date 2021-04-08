using System;
using Dice;

namespace Operator
{
    class DiceOperation
    {
        public static void TheGame()
        {

            Random calm = new Random();

            int rollTime = 7;

             int counts =0;

            bool fly = true;

            while (fly && !(rollTime < 1))
            {

                int dice1 = calm.Next(1, 7);

                int dice2 = calm.Next(1, 7);

                int dice3 = calm.Next(1, 7);

                int total = dice1 + dice2 + dice3;
                Console.WriteLine(total);

                if (dice1 == dice2 && dice2 == dice3)
                {
                    Console.WriteLine("you have triple");
                    total += 6;
                }
                else if (dice1 == 2 || dice2 == dice3 || dice3 == dice1)
                {

                    Console.WriteLine("you have double");
                    total += 4;

                }
                Console.WriteLine(total);

                Console.WriteLine($"score :{total}= {dice1} + {dice2} + {dice3}");
                string finalMessage = (total >= 15) ? "you won" : "you lose";
                Console.WriteLine(finalMessage);

                if (rollTime >1)
                {
                    Console.WriteLine($"you have played {++counts}");

                    Console.WriteLine($"You have {--rollTime} more");
                    string question ="do you want to continue ?";
                    Console.WriteLine(question);
                    string continueOption =string.Empty;
                    do
                    {
                        Console.WriteLine(question);
                         continueOption = Console.ReadLine();
                    }while(!continueOption.Equals(Const.yesOption,StringComparison.OrdinalIgnoreCase)&&!continueOption.Equals(Const.noOption,StringComparison.OrdinalIgnoreCase));

                    fly = continueOption.Equals(Const.yesOption,StringComparison.OrdinalIgnoreCase);

                    if(!fly)
                    {
                        Console.WriteLine(Const.gameEndMessage);
                    }
                }
                        else
                     {
                Console.WriteLine(Const.gameOverMessage);
                fly = false ;
            }       }


        }
    }
} 
