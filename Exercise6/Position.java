
class Position {

    private int x;
    private int y;

    public Position(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public String toString() {
        return ('A' + this.x - 1) + "" + this.y;
    }

    public int getX() {
        return x;
    }

    public int getY() {
        return y;
    }

    @Override
    public boolean equals(Object other) {
        if (other == null) {
            return false;
        }
        if (!(other instanceof Position)) {
            return false;
        }
        Position op = (Position)other;
        return this.x == op.x && this.y == op.y;
    }
}
