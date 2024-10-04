using System;
using System.Collections.Generic;
using System.Text;

namespace Queues
{
    class Game
    {

        //Property to get the maximum number of players allowed in the game 
        public int MaxPlayers { get; }
        
        //Property to get or set the curren tnumber of player in the game
        public int CurrentPlayers { get; set; }

        //Constructor for the game class, intializes max and current player counts
        public Game(int maxP, int currentP)
        {
            //Sets the maximum number of players
            MaxPlayers = maxP;
            //Sets the current number of players
            CurrentPlayers = currentP; 
        }

        //methods to kick a player from the game
        public void KickPlayer()
        {
            //Decrement the current player count
            CurrentPlayers--;
        }

        //Method to check the queue for players waiting to join the game 
        public void CheckQueue(Queue<Player> playerQueue)
        {
            //Checks if there is room for more players
            if (CurrentPlayers < MaxPlayers)
            {
                //If there are players in the queue, dequeue one
                if (playerQueue.Count > 0)
                {
                    //remove the first player from the queue
                    playerQueue.Dequeue();
                    //Increment the current player count
                    CurrentPlayers++;
                }
                else
                {
                    //if the queue is empty, inform that no players are waiting
                    Console.WriteLine("No players in the queue!");
                }
            }
        }        
    }
}
