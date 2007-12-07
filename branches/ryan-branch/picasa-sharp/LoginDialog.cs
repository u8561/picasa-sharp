using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace picasa_sharp {
    public partial class LoginDialog : Form {

        private string username;
        private string password;

        public LoginDialog() {
            InitializeComponent();
        }


        public string Username {
            get {
                return this.username;
            }
        }

        public string Password {
            get {
                return this.password;
            }
        }

        private void OKButton_Click(object sender, EventArgs e) {

            this.username = usernameTextBox.Text;
            this.password = passwordTextBox.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void usernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' 
                && usernameTextBox.Text!=""
                && passwordTextBox.Text!="")
            {
                this.username = usernameTextBox.Text;
                this.password = passwordTextBox.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r'
                && usernameTextBox.Text != ""
                && passwordTextBox.Text != "")
            {
                this.username = usernameTextBox.Text;
                this.password = passwordTextBox.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }




    }
}