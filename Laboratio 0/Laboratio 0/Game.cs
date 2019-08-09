using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    public class Game
    {
        private List<Player>[] players;
        private Board boardGame;
        private Player activePlayer;
        private bool endGame;

        public List<Player>[] Players { get => players; set => players = value; }
        public Board BoardGame { get => boardGame; set => boardGame = value; }
        public Player ActivePlayer { get => activePlayer; set => activePlayer = value; }
        public bool EndGame { get => endGame; set => endGame = value; }

        public Game( List<Player>[] players, Board boardGame, Player activePlayer, bool endGame)
        {
            this.players = players;
            this.boardGame = boardGame;
            this.activePlayer = activePlayer;
            this.endGame = endGame;
        }

        public bool CheckIfEndGame()
        {
            return false; //Nota: Poner output correcto 
        }
        public int GetWinner()
        {
            return 0;  //Nota: Poner output correcto 
        }
        public void Play()
        {

        }
    }
}
