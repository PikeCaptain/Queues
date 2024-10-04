using System;
using System.Collections.Generic;
using System.Text;

namespace Queues
{
    internal class Player
    {

        // Property to get and set the player's health
        public int Health { get; set; }

        //Read-only property for the player's game tag
        public string GamerTag { get; }

        //Constructor for the Player class, intializes health and gamer tag
        public Player(int healthParam, string nameParam) 
        {
            //Sets player's haelth based on the provided parameter
            Health = healthParam;
            //Sets player's gamer tag
            GamerTag = nameParam;
        }

        //Method for a player to join a game
        public void joinGame(Game game, Queue<Player> queue)
        {
            //Check if the game is full 
            if(game.CurrentPlayers == game.MaxPlayers)
            {
                //If full, add the player to the waiting queue
                queue.Enqueue(this);
            }
            else
            {
                //if there is space, allow the player to join the game
                Console.WriteLine("Joining Game!");
                //Increment the current player count
                game.CurrentPlayers++;
            }
        }

        //Ovveride the ToString method to return the player's gamer tag
        public override string ToString()
        {

            //Return the gamer tag when the player is converted to a string 
            return GamerTag;
        }
    }
}
