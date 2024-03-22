using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chess chess = new Chess("startingBoard.json");
            chess.Board.Show(this);
            //  chess.Board.Save("startingBoard.json");

            chess.Board.Move(6, 4, 4, 4);
            chess.Board.Show();

        }
    }
}
