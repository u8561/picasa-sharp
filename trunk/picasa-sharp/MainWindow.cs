using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


using Mono.Google;
using Mono.Google.Picasa;

using System.Threading;
using System.IO;

namespace picasa_sharp {
    public partial class MainWindow : Form {

        private PicasaAlbumsManager pam;
        private PicasaAlbumCollection myAlbums;

        private Thread display_photos_thread=null;

        public MainWindow() {
            InitializeComponent();
        }

        private void createNewAlbumToolStripMenuItem_Click(object sender, EventArgs e) {
            NewAlbumDialog nad = new NewAlbumDialog();

            nad.ShowDialog();

            if (nad.DialogResult == DialogResult.OK) {
                PicasaWeb picasa = pam.getWeb();
                PicasaAlbum unique_id = picasa.CreateAlbum(nad.AlbumTitle);
                    //, nad.AlbumDescription, nad.AlbumAcessMode, nad.AlbumDate);
            //   PicasaAlbumCollection coll = picasa.GetAlbums();
            //    PicasaAlbum album = coll[unique_id];
            }

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e) {

            LoginDialog ld = new LoginDialog();
            ld.ShowDialog();

            if (ld.DialogResult == DialogResult.OK) {
                pam = new PicasaAlbumsManager(ld.Username, ld.Password);

                //How do we handle failures?
                pam.login();
                
                

                this.lblStatus.Text = "Connected as " + ld.Username;
                myAlbums = pam.getAllAlbums();

                albumList.DisplayMember = pam.DisplayMember;
                for (int i = 0; i < myAlbums.Count; i++)
                {
                    albumList.Items.Add(myAlbums[i]);
                }
            }
        }

        private void albumList_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (display_photos_thread != null) {

                display_photos_thread.Abort();
            }
            

            display_photos_thread = new Thread(get_album_thumbs);






            display_photos_thread.Start(myAlbums[albumList.SelectedIndex]);

            populateDetails(myAlbums[albumList.SelectedIndex]);
        }

        private void populateDetails(PicasaAlbum album)
        {
            this.lblName.Text = album.Title;
            this.txtBoxDescription.Text = album.Description;
            this.lblNumPictures.Text = album.PicturesCount.ToString();
            this.lblBytesUsed.Text = album.BytesUsed.ToString();
        }

        private void get_album_thumbs(Object data) {
            PicasaAlbum selected_album = (PicasaAlbum)data;
            PicasaPicture[] album_pics = selected_album.GetPictures().AllValues;
            string next_page = "";

            next_page += "<html><head><title>";
            next_page += selected_album.Title;
            next_page += "</title></head><body>";
            next_page += selected_album.Title;
            next_page += "</br>";


            foreach (PicasaPicture pic in album_pics) {
                next_page += "<img src=\"";
                next_page += pic.ThumbnailURL;
                next_page += "\"/>";
            }



            next_page += "</body></html>";
            albumPhotoBrowser.DocumentText = next_page;
        }
    }
}
