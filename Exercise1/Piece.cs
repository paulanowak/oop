using System;

namespace Chess {

    enum Color { White, Black };

    abstract class Piece {

        protected Color color;
        protected Position pos;

        public Piece(Position pos, Color color) {
            this.pos = pos;
            this.color = color;
        }

        public Color Color {
            get {
                return color;
            }
        }

        public Position Position {
            get {
                return pos;
            }
        }

        public abstract string name();

        public abstract bool canMoveTo(Position to);

        public virtual bool canCapture(Piece target) {
            if (target.color == this.color) {
                return false;
            }
            return this.canMoveTo(target.pos);
        }

        public void moveTo(Position to) {
            if (to.equals(pos)) {
                throw new System.ArgumentException("Cannot move to the same position");
            }
            if (to.X < 0 || to.X >= 8 || to.Y < 0 || to.Y >= 8) {
                throw new ArgumentException(to + "is outside the board");
            }
            if (!this.canMoveTo(to)) {
                throw new ArgumentException("Cannot move " + this.name() + " to " + to);
            }
            this.pos = to;
        }

        public override string ToString() {
            return this.Color + " " + this.name() + " at " + this.pos;
        }
    }


    internal class Castle : Piece {

        public Castle(Position pos, Color color) : base(pos, color) {}

        public override string name() {
            return "Castle";
        }

        public override bool canMoveTo(Position to) {
            return pos.X == to.X || pos.Y == to.Y;
        }
    }

    internal class Pawn : Piece {

        public Pawn(Position pos, Color color) : base(pos, color) {}

        public override string name() {
            return "Pawn";
        }

        public override bool canMoveTo(Position to) {
            return pos.X == to.X && (pos.Y == to.Y + 1 || pos.Y == 0 && to.Y == 2);
        }

        public override bool canCapture(Piece target) {
            var to = target.Position;
            return Math.Abs(pos.X - to.X) == 1 && to.Y == pos.Y + 1;
        }
    }

    internal class King : Piece {

        public King(Position pos, Color color) : base(pos, color) {}

        public override string name() {
            return "King";
        }

        public override bool canMoveTo(Position to) {
            return Math.Abs(pos.X - to.X) == 1 && Math.Abs(pos.Y - to.Y) == 1;
        }
    }

    internal class Knight : Piece {

        public Knight(Position pos, Color color) : base(pos, color) {}

        public override string name() {
            return "Knight";
        }

        public override bool canMoveTo(Position to) {
            return Math.Abs(pos.X - to.X) == 2 && Math.Abs(pos.Y - to.Y) == 1 ||
                Math.Abs(pos.Y - to.Y) == 2 && Math.Abs(pos.X - to.X) == 1;
        }
    }
}
