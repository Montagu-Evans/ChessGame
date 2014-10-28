using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class GameBoard
    {
        public List<GamePiece> ListOfGamePieces{get; set;}
        
        int[,] gameBoard;
        public GameBoard(int x, int y)
        {
            gameBoard = new int[x, y];
            ListOfGamePieces = new List<GamePiece>();
        }

        public void GetPositions()
        {
            //return GetPositions;
        }

        public int SetPositions()
        {
            return 0;
        } 
    }
}
