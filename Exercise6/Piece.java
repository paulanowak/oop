abstract class Piece {

    protected boolean isWhite;
    protected Position pos;

    public Piece(Position pos, boolean isWhite) {
        this.pos = pos;
        this.isWhite = isWhite;
    }

    public boolean IsWhite() {
        return this.isWhite;
    }

    public Position Position() {
        return this.pos;
    }

    protected abstract boolean canMoveTo(Position to);
}

class Pawn extends Piece {

    public Pawn(Position pos, boolean isWhite) {
        super(pos, isWhite);
    }

    public boolean canMoveTo(Position to) {
        Position pos = this.pos;
        return pos.getX() == to.getX() && (to.getY() == pos.getY() + 1 || pos.getY() == 1 && to.getY() == 3);
    }
}

class King extends Piece {

    public King(Position pos, boolean isWhite) {
        super(pos, isWhite);
    }

    public boolean canMoveTo(Position to) {
        Position pos = this.pos;
        return Math.abs(pos.getX() - to.getX()) <= 1 && Math.abs(pos.getY() - to.getY()) <= 1;
    }
}

class Castle extends Piece {

    public Castle(Position pos, boolean isWhite) {
        super(pos, isWhite);
    }

    public boolean canMoveTo(Position to) {
        Position pos = this.pos;
        return pos.getX() == to.getX() || pos.getY() == to.getY();
    }
}

class Knight extends Piece {

    public Knight(Position pos, boolean isWhite) {
        super(pos, isWhite);
    }

    public boolean canMoveTo(Position to) {
        Position pos = this.pos;
        return Math.abs(pos.getX() - to.getX()) == 2 && Math.abs(pos.getY() - to.getY()) == 1 ||
            Math.abs(pos.getY() - to.getY()) == 2 && Math.abs(pos.getX() - to.getX()) == 1;

    }
}
