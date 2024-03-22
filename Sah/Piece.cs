namespace Sah
{
    internal class Piece
    {
        Colors pieceColor;
        PieceType pieceType;
        char letter;

        public Piece(Colors pieceColor, PieceType pieceType, char letter)
        {
            this.pieceColor = pieceColor;
            this.pieceType = pieceType;
            this.Letter = letter;
        }

        public char Letter { get => letter; set => letter = value; }
        public Colors PieceColor { get => pieceColor; set => pieceColor = value; }
        public PieceType PieceType { get => pieceType; set => pieceType = value; }
    }
}