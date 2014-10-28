using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Game
    {
        public Game()
        {
            //Testar 
        }
        public List<GamePiece> CreateAllGamePieces()
        {
            List<GamePiece> gamePieces = new List<GamePiece>();

            for (int i = 1; i <= 16; i++)
            {
                if (i <= 8)
                {
                    gamePieces.Add(new GamePiece(GamePieceType.Pawn, GamePieceColor.White));
                    gamePieces.Add(new GamePiece(GamePieceType.Pawn, GamePieceColor.Black));
                }

                if (i == 9 || i == 10)
                {
                    gamePieces.Add(new GamePiece(GamePieceType.Knight, GamePieceColor.White));
                    gamePieces.Add(new GamePiece(GamePieceType.Knight, GamePieceColor.Black));
                }

                if (i == 11 || i == 12)
                {
                    gamePieces.Add(new GamePiece(GamePieceType.Bishop, GamePieceColor.White));
                    gamePieces.Add(new GamePiece(GamePieceType.Bishop, GamePieceColor.Black));
                }

                if (i == 13 || i == 14)
                {
                    gamePieces.Add(new GamePiece(GamePieceType.Rook, GamePieceColor.White));
                    gamePieces.Add(new GamePiece(GamePieceType.Rook, GamePieceColor.Black));
                }

                if (i == 15)
                {
                    gamePieces.Add(new GamePiece(GamePieceType.Queen, GamePieceColor.White));
                    gamePieces.Add(new GamePiece(GamePieceType.Queen, GamePieceColor.Black));
                }

                if (i == 16)
                {
                    gamePieces.Add(new GamePiece(GamePieceType.King, GamePieceColor.White));
                    gamePieces.Add(new GamePiece(GamePieceType.King, GamePieceColor.Black));
                }
            }
            return gamePieces;
        }
    }
}
