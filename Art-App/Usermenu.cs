using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Usermenu : Form
    {
        public Usermenu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSearchArt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fitures not yet available");
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void buttonMakeRequest_Click(object sender, EventArgs e)
        {
            Requestmenu request = new Requestmenu();
            this.Hide();
            request.Show();
        }
    }
}
