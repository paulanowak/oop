using System;

namespace Chess {

    public class Program {

        public static void Main(string[] args) {

            var knight = new Knight(new Position("A3"), Color.White);

            knight.OnMove = (piece) => {
                Console.WriteLine(piece);
            };

            knight.moveTo(new Position("B5"));
            knight.moveTo(new Position("C3"));
            knight.moveTo(new Position("E2"));

            var king = new King(new Position("A4"), Color.Black);
            var pawn = new Pawn(new Position("C5"), Color.White);
            var board = new Board();

            board[knight.Position] = knight;
            board[king.Position] = king;
            board[pawn.Position] = pawn;

            Console.WriteLine(board.NumberOfPieces()); // 3
        }
    }
}
