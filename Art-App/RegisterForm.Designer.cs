
namespace WindowsFormsApp1
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxEmailaddress = new System.Windows.Forms.TextBox();
            this.textboxFirstname = new System.Windows.Forms.TextBox();
            this.textboxLastname = new System.Windows.Forms.TextBox();
            this.textboxUsername = new System.Windows.Forms.TextBox();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.textboxConfirmpassword = new System.Windows.Forms.TextBox();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelGotologin = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.labelClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 103);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(333, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Make Account";
            // 
            // textboxEmailaddress
            // 
            this.textboxEmailaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxEmailaddress.ForeColor = System.Drawing.Color.Gray;
            this.textboxEmailaddress.Location = new System.Drawing.Point(64, 185);
            this.textboxEmailaddress.Name = "textboxEmailaddress";
            this.textboxEmailaddress.Size = new System.Drawing.Size(739, 47);
            this.textboxEmailaddress.TabIndex = 5;
            this.textboxEmailaddress.Text = "Email Address";
            this.textboxEmailaddress.Enter += new System.EventHandler(this.textboxEmailaddress_Enter);
            this.textboxEmailaddress.Leave += new System.EventHandler(this.textboxEmailaddress_Leave);
            // 
            // textboxFirstname
            // 
            this.textboxFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxFirstname.ForeColor = System.Drawing.Color.Gray;
            this.textboxFirstname.Location = new System.Drawing.Point(64, 129);
            this.textboxFirstname.Name = "textboxFirstname";
            this.textboxFirstname.Size = new System.Drawing.Size(225, 47);
            this.textboxFirstname.TabIndex = 6;
            this.textboxFirstname.Text = "First Name";
            this.textboxFirstname.Enter += new System.EventHandler(this.textboxFirstname_Enter);
            this.textboxFirstname.Leave += new System.EventHandler(this.textboxFirstname_Leave);
            // 
            // textboxLastname
            // 
            this.textboxLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxLastname.ForeColor = System.Drawing.Color.Gray;
            this.textboxLastname.Location = new System.Drawing.Point(295, 129);
            this.textboxLastname.Name = "textboxLastname";
            this.textboxLastname.Size = new System.Drawing.Size(508, 47);
            this.textboxLastname.TabIndex = 7;
            this.textboxLastname.Text = "Last Name";
            this.textboxLastname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textboxLastname.Enter += new System.EventHandler(this.textboxLastname_Enter);
            this.textboxLastname.Leave += new System.EventHandler(this.textboxLastname_Leave);
            // 
            // textboxUsername
            // 
            this.textboxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxUsername.ForeColor = System.Drawing.Color.Gray;
            this.textboxUsername.Location = new System.Drawing.Point(64, 241);
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.Size = new System.Drawing.Size(739, 47);
            this.textboxUsername.TabIndex = 8;
            this.textboxUsername.Text = "Username";
            this.textboxUsername.Enter += new System.EventHandler(this.textboxUsername_Enter);
            this.textboxUsername.Leave += new System.EventHandler(this.textboxUsername_Leave);
            // 
            // textboxPassword
            // 
            this.textboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPassword.ForeColor = System.Drawing.Color.Gray;
            this.textboxPassword.Location = new System.Drawing.Point(64, 297);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.Size = new System.Drawing.Size(739, 47);
            this.textboxPassword.TabIndex = 9;
            this.textboxPassword.Text = "Password";
            this.textboxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textboxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // textboxConfirmpassword
            // 
            this.textboxConfirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxConfirmpassword.ForeColor = System.Drawing.Color.Gray;
            this.textboxConfirmpassword.Location = new System.Drawing.Point(64, 353);
            this.textboxConfirmpassword.Name = "textboxConfirmpassword";
            this.textboxConfirmpassword.Size = new System.Drawing.Size(739, 47);
            this.textboxConfirmpassword.TabIndex = 10;
            this.textboxConfirmpassword.Text = "Confirm Password";
            this.textboxConfirmpassword.Enter += new System.EventHandler(this.textboxConfirmpassword_Enter);
            this.textboxConfirmpassword.Leave += new System.EventHandler(this.textboxConfirmpassword_Leave);
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateAccount.BackColor = System.Drawing.Color.Lime;
            this.buttonCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateAccount.ForeColor = System.Drawing.Color.Blue;
            this.buttonCreateAccount.Location = new System.Drawing.Point(64, 417);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(739, 49);
            this.buttonCreateAccount.TabIndex = 11;
            this.buttonCreateAccount.Text = "Register";
            this.buttonCreateAccount.UseVisualStyleBackColor = false;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Already have an account? ";
            // 
            // labelGotologin
            // 
            this.labelGotologin.AutoSize = true;
            this.labelGotologin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGotologin.ForeColor = System.Drawing.Color.Green;
            this.labelGotologin.Location = new System.Drawing.Point(202, 479);
            this.labelGotologin.Name = "labelGotologin";
            this.labelGotologin.Size = new System.Drawing.Size(59, 13);
            this.labelGotologin.TabIndex = 13;
            this.labelGotologin.Text = "Login Here";
            this.labelGotologin.Click += new System.EventHandler(this.labelGotologin_Click);
            this.labelGotologin.MouseEnter += new System.EventHandler(this.labelGotologin_MouseEnter);
            this.labelGotologin.MouseLeave += new System.EventHandler(this.labelGotologin_MouseLeave);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.Location = new System.Drawing.Point(835, 11);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(30, 29);
            this.labelClose.TabIndex = 4;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 525);
            this.Controls.Add(this.labelGotologin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.textboxConfirmpassword);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.textboxUsername);
            this.Controls.Add(this.textboxLastname);
            this.Controls.Add(this.textboxFirstname);
            this.Controls.Add(this.textboxEmailaddress);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxEmailaddress;
        private System.Windows.Forms.TextBox textboxFirstname;
        private System.Windows.Forms.TextBox textboxLastname;
        private System.Windows.Forms.TextBox textboxUsername;
        private System.Windows.Forms.TextBox textboxPassword;
        private System.Windows.Forms.TextBox textboxConfirmpassword;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelGotologin;
        private System.Windows.Forms.Label labelClose;
    }
}