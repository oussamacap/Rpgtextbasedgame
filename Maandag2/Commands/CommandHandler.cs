using System;
using System.Collections.Generic;
using System.Text;

namespace Maandag2.Commands
{
    public static class CommandHandler
    {
        public static void CommandInGame(){
            string TheCase = Console.ReadLine(); // userinput

            switch (TheCase)
            {
                case "Attack":
                    Console.WriteLine("Case 1");

                    break;
                case "Left":
                    Game.CreateMonster();
                    break;
                case "Right":
                    Console.WriteLine("Case 3");
                    break;
                case "suicide":
                case "stop":
                case "quit":
                    Game.End();
                    break;


                default:
                    Console.WriteLine("Default case");
                    break;
            }

            if (!TheCase.Equals("suicide") && !TheCase.Equals("stop") && !TheCase.Equals("quit"))
            {
                CommandInGame();
            }
           
        }
    }
}
