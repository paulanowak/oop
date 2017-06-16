

class Main {

    public static void Main(String[] args) {

        Board board = new Board();
        Knight knight = new Knight(new Position(2, 3), false);

        knight.moveTo(new Position(3, 5));
        board.set(knight.getPosition(), knight);

        System.out.println(board.get(knight.getPosition()));

    }

}
