using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess1
{
    class GameBoard
    {
        public List<GamePiece> ListOfGamePieces{get; set;}
        
        int[,] gameBoard;
        public GameBoard(int x, int y)
        {
            gameBoard = new int[x, y];
        }

        public void GetPositions()
        {
            
        }

        public void SetPositions()
        {

        } 
    }
}
