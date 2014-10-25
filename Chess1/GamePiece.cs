using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess1
{
    class GamePiece
    {
        GamePieceType gamePieceType;
        GamePieceColor gamePieceColor;
        public GamePiece(GamePieceType gamePieceType, GamePieceColor gamePieceColor)
        {
            this.gamePieceType = gamePieceType;
            this.gamePieceColor = gamePieceColor;
        }
    }
}
