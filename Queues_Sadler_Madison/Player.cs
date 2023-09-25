// System namespace needed to use Console class
using System;
// System.Collections.Generic namespace needed to use Console class
using System.Collections.Generic;
// System.Linq namespace needed to use Console class
using System.Linq;
// System.Text namespace needed to use Console class
using System.Text;
// System.Threading.Tasks namespace needed to use Console class
using System.Threading.Tasks;

// My collection of classes for this project
namespace Queues_Sadler_Madison
{
    // Creates a class called Player
    internal class Player
    {
        // Creates a public integer property called Health with an automatic getter and setter
        public int Health { get; set; }

        // Creates a public string property called GamerTag with an automatic getter
        public string GamerTag { get; }

        // Creates a constructor called Player that takes integer parameter healthParam and string parameter nameParam
        public Player(int healthParam, string nameParam) 
        {
            // Assigns Health to healthParam
            Health = healthParam;
            // Assigns GamerTag to nameParam
            GamerTag = nameParam;
        }

        // Creates a public method called JoinGame that takes Game parameter game and Queue<Player> parameter queue
        public void JoinGame(Game game, Queue<Player> queue)
        {
            // Creates an if else statement where if CurrentPlayers is equal to MaxPlayers then add this player to queue
            if(game.CurrentPlayers == game.MaxPlayers)
            {
                queue.Enqueue(this);
            }
            // Else, it will print to console "Joining Game..." and it will increase CurrentPlayers by 1
            else
            {
                Console.WriteLine("Joining Game...");
                game.CurrentPlayers++;
            }
        }

        // Overrides the ToString method and returns GamerTag
        public override string ToString()
        {
            return GamerTag;
        }
    }
}
