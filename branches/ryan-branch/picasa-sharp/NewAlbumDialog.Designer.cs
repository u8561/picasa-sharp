namespace picasa_sharp {
    partial class NewAlbumDialog {
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
            this.newAlbumTitleLabel = new System.Windows.Forms.Label();
            this.albumTitleLabel = new System.Windows.Forms.Label();
            this.albumDateLabel = new System.Windows.Forms.Label();
            this.albumDescriptionLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.placeTextBox = new System.Windows.Forms.TextBox();
            this.publicRadioButton = new System.Windows.Forms.RadioButton();
            this.privateRadioButton = new System.Windows.Forms.RadioButton();
            this.albumPlaceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.createAlbumButton = new System.Windows.Forms.Button();
            this.cancelAlbumButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // newAlbumTitleLabel
            // 
            this.newAlbumTitleLabel.AutoSize = true;
            this.newAlbumTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAlbumTitleLabel.ForeColor = System.Drawing.Color.Coral;
            this.newAlbumTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.newAlbumTitleLabel.Name = "newAlbumTitleLabel";
            this.newAlbumTitleLabel.Size = new System.Drawing.Size(178, 24);
            this.newAlbumTitleLabel.TabIndex = 0;
            this.newAlbumTitleLabel.Text = "Create a new album";
            // 
            // albumTitleLabel
            // 
            this.albumTitleLabel.AutoSize = true;
            this.albumTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumTitleLabel.Location = new System.Drawing.Point(13, 51);
            this.albumTitleLabel.Name = "albumTitleLabel";
            this.albumTitleLabel.Size = new System.Drawing.Size(34, 16);
            this.albumTitleLabel.TabIndex = 1;
            this.albumTitleLabel.Text = "Title";
            // 
            // albumDateLabel
            // 
            this.albumDateLabel.AutoSize = true;
            this.albumDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumDateLabel.Location = new System.Drawing.Point(12, 112);
            this.albumDateLabel.Name = "albumDateLabel";
            this.albumDateLabel.Size = new System.Drawing.Size(37, 16);
            this.albumDateLabel.TabIndex = 2;
            this.albumDateLabel.Text = "Date";
            // 
            // albumDescriptionLabel
            // 
            this.albumDescriptionLabel.AutoSize = true;
            this.albumDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumDescriptionLabel.Location = new System.Drawing.Point(13, 176);
            this.albumDescriptionLabel.Name = "albumDescriptionLabel";
            this.albumDescriptionLabel.Size = new System.Drawing.Size(76, 16);
            this.albumDescriptionLabel.TabIndex = 3;
            this.albumDescriptionLabel.Text = "Description";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(12, 70);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(409, 20);
            this.titleTextBox.TabIndex = 4;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 195);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(409, 78);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // placeTextBox
            // 
            this.placeTextBox.Location = new System.Drawing.Point(12, 312);
            this.placeTextBox.Name = "placeTextBox";
            this.placeTextBox.Size = new System.Drawing.Size(409, 20);
            this.placeTextBox.TabIndex = 7;
            // 
            // publicRadioButton
            // 
            this.publicRadioButton.AutoSize = true;
            this.publicRadioButton.Checked = true;
            this.publicRadioButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.publicRadioButton.Location = new System.Drawing.Point(12, 351);
            this.publicRadioButton.Name = "publicRadioButton";
            this.publicRadioButton.Size = new System.Drawing.Size(54, 17);
            this.publicRadioButton.TabIndex = 8;
            this.publicRadioButton.TabStop = true;
            this.publicRadioButton.Text = "Public";
            this.publicRadioButton.UseVisualStyleBackColor = true;
            this.publicRadioButton.CheckedChanged += new System.EventHandler(this.publicRadioButton_CheckedChanged);
            // 
            // privateRadioButton
            // 
            this.privateRadioButton.AutoSize = true;
            this.privateRadioButton.ForeColor = System.Drawing.Color.Coral;
            this.privateRadioButton.Location = new System.Drawing.Point(12, 374);
            this.privateRadioButton.Name = "privateRadioButton";
            this.privateRadioButton.Size = new System.Drawing.Size(63, 17);
            this.privateRadioButton.TabIndex = 9;
            this.privateRadioButton.Text = "Unlisted";
            this.privateRadioButton.UseVisualStyleBackColor = true;
            this.privateRadioButton.CheckedChanged += new System.EventHandler(this.privateRadioButton_CheckedChanged);
            // 
            // albumPlaceLabel
            // 
            this.albumPlaceLabel.AutoSize = true;
            this.albumPlaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumPlaceLabel.Location = new System.Drawing.Point(12, 293);
            this.albumPlaceLabel.Name = "albumPlaceLabel";
            this.albumPlaceLabel.Size = new System.Drawing.Size(85, 16);
            this.albumPlaceLabel.TabIndex = 10;
            this.albumPlaceLabel.Text = "Place Taken";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(95, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = " (optional)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(103, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = " (optional)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(72, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "(default)";
            // 
            // createAlbumButton
            // 
            this.createAlbumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAlbumButton.Location = new System.Drawing.Point(265, 368);
            this.createAlbumButton.Name = "createAlbumButton";
            this.createAlbumButton.Size = new System.Drawing.Size(75, 23);
            this.createAlbumButton.TabIndex = 16;
            this.createAlbumButton.Text = "Create";
            this.createAlbumButton.UseVisualStyleBackColor = true;
            this.createAlbumButton.Click += new System.EventHandler(this.createAlbumButton_Click);
            // 
            // cancelAlbumButton
            // 
            this.cancelAlbumButton.Location = new System.Drawing.Point(346, 368);
            this.cancelAlbumButton.Name = "cancelAlbumButton";
            this.cancelAlbumButton.Size = new System.Drawing.Size(75, 23);
            this.cancelAlbumButton.TabIndex = 17;
            this.cancelAlbumButton.Text = "Cancel";
            this.cancelAlbumButton.UseVisualStyleBackColor = true;
            this.cancelAlbumButton.Click += new System.EventHandler(this.cancelAlbumButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 132);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            
            // 
            // NewAlbumDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 402);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cancelAlbumButton);
            this.Controls.Add(this.createAlbumButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.albumPlaceLabel);
            this.Controls.Add(this.privateRadioButton);
            this.Controls.Add(this.publicRadioButton);
            this.Controls.Add(this.placeTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.albumDescriptionLabel);
            this.Controls.Add(this.albumDateLabel);
            this.Controls.Add(this.albumTitleLabel);
            this.Controls.Add(this.newAlbumTitleLabel);
            this.Name = "NewAlbumDialog";
            this.Text = "Add a new album.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newAlbumTitleLabel;
        private System.Windows.Forms.Label albumTitleLabel;
        private System.Windows.Forms.Label albumDateLabel;
        private System.Windows.Forms.Label albumDescriptionLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox placeTextBox;
        private System.Windows.Forms.RadioButton publicRadioButton;
        private System.Windows.Forms.RadioButton privateRadioButton;
        private System.Windows.Forms.Label albumPlaceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createAlbumButton;
        private System.Windows.Forms.Button cancelAlbumButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}