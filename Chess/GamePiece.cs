using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class GamePiece
    {
        public GamePieceType GamePieceType { get; private set; }
        public GamePieceColor GamePieceColor { get; private set; }

        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public GamePiece(GamePieceType gamePieceType, GamePieceColor gamePieceColor)
        {
            GamePieceType = gamePieceType;
            GamePieceColor = gamePieceColor;
        }
    }
}
