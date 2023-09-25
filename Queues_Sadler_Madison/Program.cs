// See https://aka.ms/new-console-template for more information
// My collection of classes needed to use Console class
using Queues_Sadler_Madison;

// Creates a game object called myGame and sets max players to 50 and current players to 49
Game myGame = new Game(50, 49);

// Creates a queue of player objects
Queue<Player> waitingToJoinQ = new Queue<Player>();

// Creates 4 player objects with 100 health each called MMSix, IndigoWest, InigotheCat, and Oh No
Player p1 = new Player(100, "MMSix");
Player p2 = new Player(100, "IndigoWest");
Player p3 = new Player(100, "InigotheCat");
Player p4 = new Player(100, "Oh No");

// Calls JoinGame on each player object
p1.JoinGame(myGame, waitingToJoinQ);
p2.JoinGame(myGame, waitingToJoinQ);
p3.JoinGame(myGame, waitingToJoinQ);
p4.JoinGame(myGame, waitingToJoinQ);

// Prints "Players in Queue:" to console
Console.WriteLine("Players in Queue:");
// Creates a foreach loop to loop through the queue and prints all the players on a new line each
foreach(Player player in waitingToJoinQ)
{
    Console.WriteLine(player);
}

// Calls KickPlayer on myGame
myGame.KickPlayer();
// Calls CheckQueue on myGame
myGame.CheckQueue(waitingToJoinQ);

// Prints to console on a new line "Players in Queue:"
Console.WriteLine("\nPlayers in Queue:");
// Creates a foreach loop that loops through the queue and prints all the player objects on a new line each
foreach(Player player in waitingToJoinQ)
{
    Console.WriteLine(player);
}