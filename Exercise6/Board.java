class Board {

    private Piece[][] board;

    public Board() {
        this.board = new Piece[8][8];
    }

    public Piece get(Position p) {
        return board[p.getX()][p.getY()];
    }

    public void set(Position p, Piece piece) {
        board[p.getX()][p.getY()] = piece;
    }
}
