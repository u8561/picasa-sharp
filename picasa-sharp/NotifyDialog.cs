using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace picasa_sharp {
    public partial class NotifyDialog : Form {
        public NotifyDialog() {
            InitializeComponent();
        }

        public string NotificationMessage {
            set {
                notification_message.Text = value;
            }
        }

        private void OKButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}