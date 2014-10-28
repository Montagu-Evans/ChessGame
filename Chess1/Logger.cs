using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGame
{
    class Logger
    {
        List<string> listOfActions;
        public Logger()
        {
            listOfActions = new List<string>();
        }

        public void LogActions(string text)
        {
            listOfActions.Add(text);
        }

        public void ShowActions()
        {
            
        }
    }
}
