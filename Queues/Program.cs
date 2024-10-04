namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates a new game instance with a specified width and height
            Game myGame = new Game(50, 49);

            // Intializes a queue to hold players waiting to join the game
            Queue<Player> waitingToJoinQ = new Queue<Player>();

            //Creates new player instances with an intial score and name
            Player p1 = new Player(100, "MMSix");
            Player p2 = new Player(100, "xXAwesomenessXx");
            Player p3 = new Player(100, "Get Good");
            Player p4 = new Player(100, "ZombieSlaya");

            //Have each player attempt to join the game and add them to the waiting queue
            p1.joinGame(myGame, waitingToJoinQ);
            p2.joinGame(myGame, waitingToJoinQ);
            p3.joinGame(myGame, waitingToJoinQ);
            p4.joinGame(myGame, waitingToJoinQ);

            // Output the current players in the waiting queue
            Console.WriteLine("Players in da Q:");
            foreach (Player player in waitingToJoinQ)
            {
                //prints each player's details
                Console.WriteLine(player);
            }

            // Calls the game's method to kick a player
            myGame.KickPlayer();
            //Checks the queue after a player has been kicked to ensure it's updated
            myGame.CheckQueue(waitingToJoinQ);

            //Outputs the updated list of players in the waiting room
            Console.WriteLine("\nPlayers in da Q:");
            foreach (Player player in waitingToJoinQ)
            {
                //Prints eachj player's details again
                Console.WriteLine(player);
            }
        }
    }
}
