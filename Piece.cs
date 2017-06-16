using System;

namespace Chess {

    internal abstract class Piece {

        protected bool isWhite;
        protected Position pos;

        public Piece(Position pos, bool isWhite) {
            this.pos = pos;
            this.isWhite = isWhite;
        }

        public bool IsWhite {
            get {
                return isWhite;
            }
        }

        public abstract string name();

        public abstract bool canMoveTo(Position to, Board board);

        public void moveTo(Position destination, Board board) {
            var atDest = board.getPieceAt(destination);
            if (destination.equals(pos)) {
                throw new System.ArgumentException("Cannot move to the same position");
            }
            if (atDest != null && atDest.isWhite == this.isWhite) {
                throw new System.ArgumentException(destination.toString() + "is occupied by a piece of the same color");
            }
            if (destination.X < 0 || destination.X >= 8 || destination.Y < 0 || destination.Y >= 8) {
                throw new System.ArgumentException(destination.toString() + "is outside the board");
            }
            if (!this.canMoveTo(pos, destination, board)) {
                throw new System.ArgumentException("Cannot move " + this.name() + " to " + destination.toString());
            }
            this.pos = destination;
        }

        public string toString() {
            return this.name() + " at " + this.pos.toString();
        }
    }


    internal class Castle : Piece {

        public Castle(Position pos, bool isWhite) : base(pos, isWhite) {}

        public override string name() {
            return "Castle";
        }

        public override bool canMoveTo(Position to, Board board) {
            return pos.X == to.X || pos.Y == to.Y;
        }
    }

    internal class Pawn : Piece {

        public Pawn(Position pos, bool isWhite) : base(pos, isWhite) {}

        public override string name() {
            return "Pawn";
        }

        public override bool canMoveTo(Position to, Board board) {
            var atDest = board.getPieceAt(to);
            var moveNotCapture =
                from.X == to.X && atDest == null &&
                (from.Y == to.Y + 1 || from.Y == 0 && to.Y == 2);
            var moveCapture =
                Math.Abs(from.X - to.X) == 1 && atDest != null && atDest.IsWhite != this.isWhite && to.Y == from.Y + 1;
            return moveNotCapture || moveCapture;
        }
    }

    internal class King : Piece {

        public King(Position pos, bool isWhite) : base(pos, isWhite) {}

        public override string name() {
            return "King";
        }

        public override bool canMoveTo(Position to, Board board) {
            return Math.Abs(from.X - to.X) == 1 && Math.Abs(from.Y - to.Y) == 1;
        }
    }

    internal class Knight : Piece {

        public Knight(Position pos, bool isWhite) : base(pos, isWhite) {}

        public override string name() {
            return "Knight";
        }

        public override bool canMoveTo(Position to, Board board) {
            return Math.Abs(from.X - to.X) == 2 && Math.Abs(from.Y - to.Y) == 1 ||
                Math.Abs(from.Y - to.Y) == 2 && Math.Abs(from.X - to.X) == 1;
        }
    }
}
