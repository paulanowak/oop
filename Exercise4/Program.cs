using System;

namespace Chess {

    public class Program {

        public static void Main(string[] args) {

            var board = new Board();
            var pieceFactory = new PieceFactory(board);

            var knight = pieceFactory.MakePiece("knight", "A3", Color.White);
            var king = pieceFactory.MakePiece("king", "E3", Color.Black);
            var pawn = pieceFactory.MakePiece("pawn", "C1", Color.White);

            knight.moveTo(new Position("B5"));
            king.moveTo(new Position("E4"));
            pawn.moveTo(new Position("C2"));

            foreach (Piece p in board) {
                Console.WriteLine(p);
            }
        }
    }
}
