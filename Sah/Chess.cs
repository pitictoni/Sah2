using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Sah
{
    internal class Chess
    {
        Player player1;
        Player player2;

        Board board;
        MoveList moveList;

        public Chess()
        {
            Board = new Board();
        }
       public Chess(string url)
        {
            Board = new Board(url);
        }

        public Board Board { get => board; set => board = value; }
    }
}
