namespace picasa_sharp {
    partial class NotifyDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.notification_message = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notification_message
            // 
            this.notification_message.AutoSize = true;
            this.notification_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification_message.Location = new System.Drawing.Point(12, 9);
            this.notification_message.Name = "notification_message";
            this.notification_message.Size = new System.Drawing.Size(152, 16);
            this.notification_message.TabIndex = 0;
            this.notification_message.Text = "You, um did something...";
            this.notification_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 28);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(277, 40);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // NotifyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 80);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.notification_message);
            this.Name = "NotifyDialog";
            this.Text = "Notification...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label notification_message;
        private System.Windows.Forms.Button OKButton;
    }
}