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
    public partial class Requestmenu : Form
    {
        
        public Requestmenu()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbVIP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        private void Requestmenu_Load(object sender, EventArgs e)
        {

        }
        
        private void buttonRequest_Click(object sender, EventArgs e)
        {
            double fee;
            string mastery = cbMastery.Text;
            int count = Convert.ToInt16(tbCount.Text);
            string vip = cbVIP.Text;
            Request request = new Request(mastery, count, vip);
            fee = request.calculate_fee();
            MessageBox.Show(string.Format("Please pay {0} rupiahs to continue", fee));
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Usermenu usermenu = new Usermenu();
            this.Hide();
            usermenu.Show();
        }
    }
}
