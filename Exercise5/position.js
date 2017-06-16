// Position

function Position(pole) {
    this.set(pole);
}

Position.prototype.set = function (field) {
    this.x = field.charCodeAt(0)-64;
    this.y = parseInt(field[1]);
    this.field = field;
};

if (module) module.exports = Position;
