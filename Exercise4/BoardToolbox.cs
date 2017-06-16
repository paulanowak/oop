namespace Chess {

    internal class BoardToolbox {

        private static ChessBoardStore store = new ChessBoardStore("./board");

        private BoardToolbox() {}

        static BoardToolbox() {}

        public static ChessBoardStore Store {
            get {
                return store;
            }
        }
    }
}
