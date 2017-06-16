using System;

namespace Chess {

    public class Program {

        public static void Main(string[] args) {

            var knight = new Knight(new Position("A3"), Color.White);
            var pawn = new Pawn(new Position("A4"), Color.Black);
            var board = new Board();

            Console.WriteLine(knight); // "White Knight at A3" (override)
            Console.WriteLine(pawn); // "Black *Piece* at A4" (new)

            board[knight.Position] = knight;
            board[pawn.Position] = pawn;

            foreach (var piece in board) {
                Console.WriteLine(piece);
            }
        }
    }
}
