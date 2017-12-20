using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void logo_Click(object sender, EventArgs e)
        {

        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void transtion(object sender, EventArgs e)
        {
            if (buttonsPanel.Visible == false)
            {
                transitions.ShowSync(buttonsPanel);
            }
            else
            {
                transitions.HideSync(buttonsPanel);
            }
        }
        private void basePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void admin_Click(object sender, EventArgs e)
        {
            transtion(sender, e);
        }

        private void home_Click(object sender, EventArgs e)
        {

        }

        private void ops_Click(object sender, EventArgs e)
        {
            transtion(sender, e);
        }

        private void bm_Click(object sender, EventArgs e)
        {
            transtion(sender, e);
        }

        private void ps_Click(object sender, EventArgs e)
        {
            transtion(sender, e);
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (buttonsPanel.Visible == false)
            {
                transitions.ShowSync(buttonsPanel);
                transitions.ShowSync(loginPanel);
            }
            else
            {
                transitions.HideSync(buttonsPanel);
                transitions.ShowSync(loginPanel);
            }
        }
    }
}
