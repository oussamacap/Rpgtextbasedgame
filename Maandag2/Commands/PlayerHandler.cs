using Maandag2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maandag2.Commands
{
    // een class gemaakt 
    public class PlayerHandler
    {
        //het soort van final object waar je altijd toegang van kan opvragen  
        private static PlayerHandler instance;
        private Player player;

        // gwn een consturor  
        private PlayerHandler() {  }

        public static PlayerHandler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PlayerHandler();
                }
                return instance;
            }

        }

        //
        public Player CreatePlayer(string firstname, string lastname)
        {
            player = new Player(firstname, lastname);
            return player;
        }

        public Player GetPlayer
        {
            get{
                return player;
            }
        }



    }
}

