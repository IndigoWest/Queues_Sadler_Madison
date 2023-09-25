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
    // Creates a class called Game
    internal class Game
    {
        // Creates a public integer property called MaxPlayers with an automatic getter
        public int MaxPlayers { get; }

        // Creates a public integer property called CurrentPlayers with an automatic getter and setter
        public int CurrentPlayers { get; set; }

        // Creates a constructor called Game that takes integer parameters maxP and currentP
        public Game(int maxP, int currentP) 
        {
            // Assigns MaxPlayers to maxP
            MaxPlayers = maxP;
            // Assigns CurrentPlayers to currentP
            CurrentPlayers = currentP;
        }   

        // Creates public void method called KickPlayer
        public void KickPlayer()
        {
            // Decrements CurrentPlayers by 1
            CurrentPlayers--;
        }

        // Creates a public void method called CheckQueue that takes Queue<Player> as a parameter
        public void CheckQueue(Queue<Player> playerQueue)
        {
            // Creates an if statement where if CurrentPlayers is less than MaxPlayers, then it will check if the queue has elements in it
            if(CurrentPlayers < MaxPlayers)
            {
                // Creates an if else statement where if the number in playerQueue is greater than 0 then Dequeue will be called on the queue and CurrentPlayers is incremented by one
                if(playerQueue.Count > 0)
                {
                    playerQueue.Dequeue();
                    CurrentPlayers++;
                }
                // If the previous statement is not true, then it will print to the console that there are no players in the queue
                else
                {
                    Console.WriteLine("No players in the queue.");
                }
            }
        }
    }
}
