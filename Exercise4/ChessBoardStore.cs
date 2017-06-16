using System.IO;

namespace Chess {

    internal class ChessBoardStore {

        private string file = null;

        public ChessBoardStore(string file) {
            this.file = file;
        }

        public void Save(Board board) {
            using (Stream stream = File.Open(this.file, FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, board);
            }
        }

        public Board Load() {
            using (Stream stream = File.Open(this.file, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (Board)binaryFormatter.Deserialize(stream);
            }
        }
    }
}
