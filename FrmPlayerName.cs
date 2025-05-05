using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeperGUI
{
    public partial class FrmPlayerName : Form
    {
        //Properties
        public string InputText = string.Empty;

        // Constructor
        public FrmPlayerName(string title, string prompt, int score)
        {
            InitializeComponent();
            this.Text = title;
            lblPrompt.Text = prompt;
            // Set the score label to the score passed in
            lblScore.Text = "Score: " + score;
        }
        // Method to handle the OK button click event
        private void btnOK_Click(object sender, EventArgs e)
        {
            InputText = txtboxName.Text;
            this.DialogResult = DialogResult.OK;
        }

        

    }
}
