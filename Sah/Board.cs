using Newtonsoft.Json;
using System;
using System.IO;

namespace Sah
{
    internal class Board
    {
        Piece[,] squares = new Piece[8, 8];

        public Piece[,] Squares { get => squares; set => squares = value; }

        #region constructors
        public Board()
        {
            EmptyBoard();

            Squares[0, 0] = new Piece(Colors.black, PieceType.Rook, 'R');
            Squares[0, 7] = new Piece(Colors.black, PieceType.Rook, 'R');
            Squares[7, 0] = new Piece(Colors.white, PieceType.Rook, 'r');
            Squares[7, 7] = new Piece(Colors.white, PieceType.Rook, 'r');

            Squares[0, 1] = new Piece(Colors.black, PieceType.Knight, 'N');
            Squares[0, 6] = new Piece(Colors.black, PieceType.Knight, 'N');
            Squares[7, 1] = new Piece(Colors.white, PieceType.Knight, 'n');
            Squares[7, 6] = new Piece(Colors.white, PieceType.Knight, 'n');

            Squares[0, 2] = new Piece(Colors.black, PieceType.Bishop, 'B');
            Squares[0, 5] = new Piece(Colors.black, PieceType.Bishop, 'B');
            Squares[7, 2] = new Piece(Colors.white, PieceType.Bishop, 'b');
            Squares[7, 5] = new Piece(Colors.white, PieceType.Bishop, 'b');

            Squares[0, 3] = new Piece(Colors.black, PieceType.Queen, 'Q');
            Squares[7, 3] = new Piece(Colors.white, PieceType.Queen, 'q');
            Squares[0, 4] = new Piece(Colors.black, PieceType.King, 'K');
            Squares[7, 4] = new Piece(Colors.white, PieceType.King, 'k');


            for (int j = 0; j < 8; j++)
                Squares[6, j] = new Piece(Colors.white, PieceType.Pawn, 'p');

            for (int j = 0; j < 8; j++)
                Squares[1, j] = new Piece(Colors.black, PieceType.Pawn, 'P');

        }       
        public Board(string startingBoard)
        {
            EmptyBoard();
            var t = File.ReadAllText(startingBoard);
            squares = JsonConvert.DeserializeObject<Board>(t).Squares;
        }

        #endregion constructors
        public void Show()
        {
            Console.WriteLine("-----------------------");
            for (int i = 0; i < 8; i++)
            {
                string row = "";
                for (int j = 0; j < 8; j++)
                {
                    row += Squares[i, j].Letter;
                }
                Console.WriteLine(row);
            }
        }
        private void EmptyBoard()
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    Squares[i, j] = new Piece(Colors.white, PieceType.None, '.');
        }

        internal void Save(string url)
        {
            var obiectSerializat = JsonConvert.SerializeObject(this);
            File.WriteAllText(url, obiectSerializat);
        }

        internal void Move(int x1, int y1, int x2, int y2)
        {
            if (Valid(x1,y1,x2,y2))
            {
                squares[x2,y2] = squares[x1,y1];
                squares[x1, y1] = new Piece(Colors.white, PieceType.None, '.');
            }
        }

        private bool Valid(int x1, int y1, int x2, int y2)
        {
            return true;
        }

        internal void Show(Form1 ui)
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                   // ui.ShowPiece(i,j,squares[i, j]);
                }
        }
    }
}