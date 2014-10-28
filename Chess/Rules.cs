using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGame
{
    class Rules
    {
        public Rules()
        {
            
        }

        public void ShowRules()
        {
            string pathToFile = @"..\..\GameContent\Chess Rules.txt";
            string text = "";
            using(StreamReader reader = new StreamReader(pathToFile))
            {
                foreach (var item in pathToFile)
                {
                    text += reader.ReadLine() + "\r\n";

                }

                MessageBox.Show(text);
            }

            
            
            
        }
    }
}
