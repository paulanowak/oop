namespace Chess {

    internal class Board {

        private Piece[,] board;

        public Board() {
            this.board = new Piece[8, 8];
        }

        public Piece getPieceAt(Position pos) {
            return null;
        }

        public void setPieceAt(Piece piece, Position pos) {
            this.board[pos.X, pos.Y] = piece;
        }
    }
}
