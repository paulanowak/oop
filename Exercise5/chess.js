
var Board = require('./board');
var Pieces = require('./piece');
var WHITE = Pieces.WHITE;
var BLACK = Pieces.BLACK;

var Position = require('./position');

var pawn = new Pieces.Pawn(new Position("A6"), WHITE)

var board = new Board();

board.set(pawn.pos, pawn);
console.log(board.get(pawn.pos));
