using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacTieWithUI
{
    public partial class RulesForTicTacToe : Form
    {
        public RulesForTicTacToe()
        {
            InitializeComponent();
            nextButton.BackColor = Color.OrangeRed;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
