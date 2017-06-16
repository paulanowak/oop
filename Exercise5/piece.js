// Piece
var WHITE = {};
var BLACK = {};

function Piece(pos, color) {
    this.color = color;
    this.pos = pos;
}

Piece.prototype.move = function (to) {

    if (to.x == this.pos.x && this.to.y == this.pos.y) {
        throw new Error("Can't move to the same position");
    }

    if (to.X < 0 || to.X >= 8 || to.y < 0 || to.y >= 8) {
        throw new Error(to.x + ", " + to.y + " is outside the board");
    }

    if (!this.legalMove(to)) {
        throw new Error("Illegal move");
    }

    var oldPos = this.pos;
    this.pos = to;
}

// Pawn

function Pawn(pos, color) {
    return Piece.call(this, pos, color);
}

Pawn.prototype = new Piece();

Pawn.prototype.legalMove = function (to) {
    var pos = this.pos;
    return pos.x == to.x && (to.y == pos.y + 1 || pos.y == 1 && to.y == 3);
};

// King

function King(pos, color) {
    return Piece.call(this, pos, color);
}

King.prototype = new Piece();

King.prototype.legalMove = function (to) {
    return Math.abs(this.pos.x - to.x) <= 1 && Math.abs(this.pos.y - to.y) <= 1;
};

// Castle

function Castle(pos, color) {
    return Piece.call(this, pos, color);
}

Castle.prototype = new Piece();

Castle.prototype.legalMove = function (to) {
    var pos = this.pos;
    return pos.x == to.x || pos.y == to.y;
};

// Knight

function Knight(pos, color) {
    return Piece.call(this, pos, color);
}

Knight.prototype = new Piece();

Knight.prototype.legalMove = function (to) {
    var pos = this.pos;
    return Math.Abs(pos.x - to.x) == 2 && Math.Abs(pos.y - to.y) == 1 ||
           Math.Abs(pos.y - to.y) == 2 && Math.Abs(pos.x - to.x) == 1;
};

//

if (module) module.exports = {
    Piece,
    Pawn: Pawn,
    King: King,
    Castle: Castle,
    Knight: Knight,
    WHITE: WHITE,
    BLACK: BLACK
};
