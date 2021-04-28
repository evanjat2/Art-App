using MySql.Data.MySqlClient;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {

            MySqlConnection connection = new MySqlConnection("server=localhost; port=3306; username=root; password=; database=art-app;");
            InitializeComponent();
            this.textboxPassword.AutoSize = false;
            this.textboxPassword.Size = new Size(this.textboxPassword.Size.Width, 50);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            String username = textboxUsername.Text;
            String password = textboxPassword.Text;
            var account = new member(username, password);

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn and `password` = @pass" , db.GetConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            //Mengecek bahwa user ada dalam database atau tidak.
            if(table.Rows.Count > 0)
            {
                MessageBox.Show(string.Format("Hello, {0}" , username));
                Usermenu usermenu = new Usermenu();
                this.Hide();
                usermenu.Show();
            }
            else
            {
                if(username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Username.");
                }
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Password.");
                }
                else
                {
                    MessageBox.Show("Wrong username or password.");
                }
                
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void labelGotoregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerform = new RegisterForm();
            registerform.Show();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelGotoregister_MouseEnter(object sender, EventArgs e)
        {
            labelGotoregister.ForeColor = Color.Red;
        }

        private void labelGotoregister_MouseLeave(object sender, EventArgs e)
        {
            labelGotoregister.ForeColor = Color.Green;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
