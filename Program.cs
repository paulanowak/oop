using System;

namespace Chess {

    public class Program {

        public static void Main(string[] args) {
            var pos = new Position("A3");
            Console.WriteLine(pos.toString());

            var piece = new Knight(pos, true);
            piece.moveTo(new Position("B5"), new Board());
            Console.WriteLine(piece.toString());
        }
    }
}
