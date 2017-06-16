using System;
using System.Linq;
using System.Collections.Generic;

namespace Chess {

    [Serializable]
    internal class Board : IEnumerable<Piece> {

        private Piece[,] board;

        public Board() : this(new Piece[8, 8]) {}
        public Board(Piece[,] board) {
            this.board = board;
        }

        public Piece this[Position pos]
        {
            get {
                return board[pos.X, pos.Y];
            }

            set {
                board[pos.X, pos.Y] = value;
            }
        }

        public IEnumerator<Piece> GetEnumerator() {
            return board.Cast<Piece>().Where(x => x != null).GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            return board.Cast<Piece>().Where(x => x != null).GetEnumerator();
        }


        public int NumberOfPieces() {
            return this.Count();
        }
    }
}
