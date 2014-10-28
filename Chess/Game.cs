using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    class Game
    {
        private GameBoard gameBoard;
        public Game()
        {
            gameBoard = new GameBoard(8, 8);
        }
        public void CreateAllGamePieces()
        {
            

            for (var i = 1; i <= 16; i++)
            {
                if (i <= 8)
                {
                    gameBoard.ListOfGamePieces.Add(new GamePiece(GamePieceType.Pawn, GamePieceColor.White));
                    gameBoard.ListOfGamePieces.Add(new GamePiece(GamePieceType.Pawn, GamePieceColor.Black));
                }

                if (i == 9 || i == 10)
                {
                    gameBoard.ListOfGamePieces.Add(new GamePiece(GamePieceType.Knight, GamePieceColor.White));
                    gameBoard.ListOfGamePieces.Add(new GamePiece(GamePieceType.Knight, GamePieceColor.Black));
                }

                if (i == 11 || i == 12)
                {
                    gameBoard.ListOfGamePieces.Add(new GamePiece(GamePieceType.Bishop, GamePieceColor.White));
                    gameBoard.ListOfGamePieces.Add(new GamePiece(GamePieceType.Bishop, GamePieceColor.Black));
                }

                if (i == 13 || i == 14)
                {
                    gameBoard.ListOfGamePieces.Add(new GamePiece(GamePieceType.Rook, GamePieceColor.White));
                    gameBoard.ListOfGamePieces.Add(new GamePiece(GamePieceType.Rook, GamePieceColor.Black));
                }

                if (i == 15)
                {
                    gameBoard.ListOfGamePieces.Add(new GamePiece(GamePieceType.Queen, GamePieceColor.White));
                    gameBoard.ListOfGamePieces.Add(new GamePiece(GamePieceType.Queen, GamePieceColor.Black));
                }

                if (i == 16)
                {
                    gameBoard.ListOfGamePieces.Add(new GamePiece(GamePieceType.King, GamePieceColor.White));
                    gameBoard.ListOfGamePieces.Add(new GamePiece(GamePieceType.King, GamePieceColor.Black));
                }
            }
        }

        public void SetStartPositions()
        {
            foreach (var gamePiece in gameBoard.ListOfGamePieces)
            {
                for (var y = 0; y <= 7; y++)
                {
                    for (var x = 0; x <= 7; x++)
                    {
                        if (gamePiece.GamePieceType == GamePieceType.Pawn && gamePiece.GamePieceColor == GamePieceColor.Black && y == 1)
                        {
                            gamePiece.PositionX = x;
                            gamePiece.PositionY = y;
                        }
                    }
                }
            }
        }
    }
}
