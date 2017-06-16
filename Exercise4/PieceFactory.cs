using System;

namespace Chess {

    [Serializable]
    internal class PieceFactory {

        private Board board;

        public PieceFactory(Board board) {
            this.board = board;
        }

        private Piece Make(string name, string field, Color color) {
            var pos = new Position(field);
            switch (name.ToLower()) {
                case "castle":
                    return new Castle(pos, color);
                case "pawn":
                    return new Pawn(pos, color);
                case "king":
                    return new King(pos, color);
                case "knight":
                    return new Knight(pos, color);
                default:
                    throw new System.NotSupportedException("The piece is not supported");
            }
        }

        public Piece MakePiece(string name, string field, Color color) {

            var piece = Make(name, field, color);
            piece.OnMove = (oldPos, p) => {
                board[oldPos] = null;
                board[p.Position] = p;
            };
            return piece;
        }
    }
}
