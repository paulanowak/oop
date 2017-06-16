
function Board() {
    this.board = new Array(8);
    var i;
    for (i = 0; i < 8; i++) {
        this.board[i] = new Array(8);
    }
}

Board.prototype.get = function(pos) {
    return this.board[pos.x][pos.y];
};

Board.prototype.set = function(pos, piece) {
    this.board[pos.x][pos.y] = piece;
};

module.exports = Board;
