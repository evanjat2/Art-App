using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxFirstname_Enter(object sender, EventArgs e)
        {
            String fname = textboxFirstname.Text;
            if(fname.Equals("First Name"))
            {
                textboxFirstname.Text = "";
                textboxFirstname.ForeColor = Color.Black;
            }
        }
        private void textboxFirstname_Leave(object sender, EventArgs e)
        {
            String fname = textboxFirstname.Text;
            if(fname.Trim().Equals(""))
            {
                textboxFirstname.Text = "First Name";
                textboxFirstname.ForeColor = Color.Gray;
            }
        }

        private void textboxLastname_Enter(object sender, EventArgs e)
        {
            String lname = textboxLastname.Text;
            if (lname.Equals("Last Name"))
            {
                textboxLastname.Text = "";
                textboxLastname.ForeColor = Color.Black;
            }
        }

        private void textboxLastname_Leave(object sender, EventArgs e)
        {
            String lname = textboxLastname.Text;
            if (lname.Trim().Equals(""))
            {
                textboxLastname.Text = "Last Name";
                textboxLastname.ForeColor = Color.Gray;
            }
        }
        private void textboxEmailaddress_Enter(object sender, EventArgs e)
        {
            String email = textboxEmailaddress.Text;
            if (email.Equals("Email Address"))
            {
                textboxEmailaddress.Text = "";
                textboxEmailaddress.ForeColor = Color.Black;
            }
        }

        private void textboxEmailaddress_Leave(object sender, EventArgs e)
        {
            String email = textboxEmailaddress.Text;
            if (email.Trim().Equals(""))
            {
                textboxEmailaddress.Text = "Email Address";
                textboxEmailaddress.ForeColor = Color.Gray;
            }
        }

        private void textboxUsername_Enter(object sender, EventArgs e)
        {
            String username = textboxUsername.Text;
            if (username.Equals("Username"))
            {
                textboxUsername.Text = "";
                textboxUsername.ForeColor = Color.Black;
            }
        }

        private void textboxUsername_Leave(object sender, EventArgs e)
        {
            String username = textboxUsername.Text;
            if (username.Trim().Equals(""))
            {
                textboxUsername.Text = "Username";
                textboxUsername.ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            String password = textboxPassword.Text;
            if (password.Equals("Password"))
            {
                textboxPassword.Text = "";
                textboxPassword.ForeColor = Color.Black;
                textboxPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            String password = textboxPassword.Text;
            if (password.Trim().Equals(""))
            {
                textboxPassword.Text = "Password";
                textboxPassword.ForeColor = Color.Gray;
                textboxPassword.UseSystemPasswordChar = false;
            }
        }

        private void textboxConfirmpassword_Enter(object sender, EventArgs e)
        {
            String confirmpassword = textboxConfirmpassword.Text;
            if (confirmpassword.Equals("Confirm Password"))
            {
                textboxConfirmpassword.Text = "";
                textboxConfirmpassword.ForeColor = Color.Black;
                textboxConfirmpassword.UseSystemPasswordChar = true;
            }
        }

        private void textboxConfirmpassword_Leave(object sender, EventArgs e)
        {
            String confirmpassword = textboxConfirmpassword.Text;
            if (confirmpassword.Trim().Equals(""))
            {
                textboxConfirmpassword.Text = "Confirm Password";
                textboxConfirmpassword.ForeColor = Color.Gray;
                textboxConfirmpassword.UseSystemPasswordChar = false;
            }
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`firstname`, `lastname`, `emailaddress`, `username`, `password`) VALUES (@fn, @ln, @email, @usn, @pass)", db.GetConnection());
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = textboxFirstname.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = textboxLastname.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textboxEmailaddress.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textboxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textboxPassword.Text;
            db.openConnection();

            if (!checktbvalues())
            {
                if (textboxPassword.Text == textboxConfirmpassword.Text)
                {
                    if (checkUsername())
                    {
                        MessageBox.Show("This username has already taken");
                    }
                    else
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Account Created Successfully");
                            LoginForm loginform = new LoginForm();
                            this.Hide();
                            loginform.Show();
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }                    
                }
                else
                {
                    MessageBox.Show("Confirm Password wrong!");
                }
            }
            else
            {
                MessageBox.Show("Form can't be blank!");
            }
            
            
                   
            db.closeConnection();
        }
        public Boolean checkUsername()
        {
            DB db = new DB();
            String username = textboxUsername.Text;
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn ", db.GetConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            //Mengecek bahwa user sudah ada dalam database atau belum
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean checktbvalues()
        {
            String fname = textboxFirstname.Text;
            String lname = textboxLastname.Text;
            String email = textboxEmailaddress.Text;
            String username = textboxUsername.Text;
            String password = textboxPassword.Text;
            if(fname.Equals("First Name") || lname.Equals("Last Name") || email.Equals("Email Address") || username.Equals("Username") ||
                password.Equals("Password"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void labelGotologin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelGotologin_MouseEnter(object sender, EventArgs e)
        {
            labelGotologin.ForeColor = Color.Red;
        }

        private void labelGotologin_MouseLeave(object sender, EventArgs e)
        {
            labelGotologin.ForeColor = Color.Green;
        }
    }
}
