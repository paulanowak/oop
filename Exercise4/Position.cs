using System;

namespace Chess {

    [Serializable]
    internal class Position {

        int x;
        int y;
        string field;

        public string Field {

            get {
                return field;
            }

            set {
                field = value;
                x = value[0] - 'A' + 1;
                y = Int32.Parse(value.Substring(1));
            }

        }

        public int X {
            get {
                return x;
            }
        }

        public int Y {
            get {
                return y;
            }
        }

        public override string ToString() {
            return (char)(x - 1 + 'A') + "" + y;
        }

        public bool equals(Position other) {
            return x == other.x && y == other.y;
        }

        public Position(string field) {
            this.Field = field;
        }

    }
}
