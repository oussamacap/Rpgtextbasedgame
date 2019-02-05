using System;
using System.Collections.Generic;
using System.Text;

namespace Maandag2.Model
{
    public class Player
    {
      public string FirstName { get; private set; }
      public string LastName  { get; private set; }
        public int LevelPoints { get; set; } = 20;

        public Player(string firstName, string  lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
    }
    }
}
