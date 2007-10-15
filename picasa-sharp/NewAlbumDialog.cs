using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace picasa_sharp {
    public partial class NewAlbumDialog : Form {

        private Mono.Google.Picasa.AlbumAccess album_access_mode = Mono.Google.Picasa.AlbumAccess.Public;
        private string album_title;
        private string album_description;
        private string album_place;
        private DateTime album_date;

        public string AlbumTitle {
            get {
                return this.album_title;
            }
        }

        public string AlbumDescription {
            get {
                return this.album_description;
            }
        }

        public string AlbumPlace {
            get {
                return this.album_place;
            }
        }

        public DateTime AlbumDate {
            get {
                return this.album_date;
            }
        }

        public Mono.Google.Picasa.AlbumAccess AlbumAcessMode {
            get {

                return this.album_access_mode;
            }
        }


        public NewAlbumDialog() {
            InitializeComponent();
        }

        private void publicRadioButton_CheckedChanged(object sender, EventArgs e) {
            this.album_access_mode = Mono.Google.Picasa.AlbumAccess.Public;
        }

        private void privateRadioButton_CheckedChanged(object sender, EventArgs e) {
            this.album_access_mode = Mono.Google.Picasa.AlbumAccess.Private;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {

        }

        private void createAlbumButton_Click(object sender, EventArgs e) {
            this.album_title = titleTextBox.Text;
            this.album_description = descriptionTextBox.Text;
            this.album_place = placeTextBox.Text;
            this.album_date = dateTimePicker1.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelAlbumButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }









    }
}