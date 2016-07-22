using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6_7GuessingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int LblIndex = 0;
            for (int i = 1; i <= 10; i++) {

                
                for (int j = 1; j <= 10; j++)
                {
                    Label tmpLbl = new Label();
                    tmpLbl.Text = LblIndex.ToString();
                    ggTable.Controls.Add(tmpLbl, j, i);
                    LblIndex++;

                }
            }
        }
    }
}
