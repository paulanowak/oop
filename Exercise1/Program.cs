using System;

namespace Chess {

    public class Program {

        public static void Main(string[] args) {
            var pos = new Position("A3");
            Console.WriteLine(pos);

            var piece = new Knight(pos, Color.White);
            piece.moveTo(new Position("B5"));
            Console.WriteLine(piece);
        }
    }
}
