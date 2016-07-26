using System;
using System.Windows.Forms;

namespace Assignment6_7GuessingGame
{
    class DoubleBufferedTableLayoutPanel : TableLayoutPanel
    {
        public DoubleBufferedTableLayoutPanel()
        {
            DoubleBuffered = true;
        }
    }
}
