using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //
            GameBoard gameBoard = new GameBoard(8,8);
            Logger logger = new Logger();
            Game game = new Game();
            
            gameBoard.ListOfGamePieces = game.CreateAllGamePieces();
            
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            Rules rules = new Rules();
            rules.ShowRules();
        }
    }
}
