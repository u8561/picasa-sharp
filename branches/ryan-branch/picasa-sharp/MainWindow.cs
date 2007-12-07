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

            if (null == pam || false == pam.LoggedIn) {
                NotifyDialog please_login = new NotifyDialog();
                please_login.NotificationMessage = "Please login, then proceed to create new albums.";
                please_login.ShowDialog();
            } else {

                NewAlbumDialog nad = new NewAlbumDialog();

                nad.ShowDialog();

                if (nad.DialogResult == DialogResult.OK) {
                    PicasaWeb picasa = pam.getWeb();
                    PicasaAlbum unique_id = picasa.CreateAlbum(nad.AlbumTitle, nad.AlbumDescription, nad.AlbumAcessMode, nad.AlbumDate);
           
                }

            }

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e) {

            LoginDialog ld = new LoginDialog();
            ld.ShowDialog();

            if (ld.DialogResult == DialogResult.OK) {
                pam = new PicasaAlbumsManager(ld.Username, ld.Password);

                //How do we handle failures?
               // pam.login();
                // We done, yet :-/ ...... Well, I wrote some code for it 
                // using exception handling, but I thought it was crap, and deleted it.
                
                // This is how:

                try {
                    pam.login();

                    this.lblStatus.Text = "Connected as " + ld.Username;
                    myAlbums = pam.getAllAlbums();

                    albumList.DisplayMember = pam.DisplayMember;
                    for (int i = 0; i < myAlbums.Count; i++) {
                        albumList.Items.Add(myAlbums[i]);
                    }

                } catch (UnauthorizedAccessException) {
                    NotifyDialog bad_login = new NotifyDialog();
                    bad_login.NotificationMessage = "Wrong password. Try again.";
                    bad_login.ShowDialog();
                }
            }
        }

        private void albumList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (display_photos_thread != null) {
                display_photos_thread.Abort();
            }
            display_photos_thread = new Thread(get_album_thumbs_from_picasa);
            display_photos_thread.Start(myAlbums[albumList.SelectedIndex]);
            populateDetails(myAlbums[albumList.SelectedIndex]);
        }

        private void populateDetails(PicasaAlbum album)
        {
            this.lblName.Text = album.Title;
            this.txtBoxDescription.Text = album.Description;
            this.lblNumPictures.Text = album.PicturesCount.ToString();

            if (AlbumAccess.Public == album.Access) {
                this.permissionData.Text = "Public";
            } else {
                this.permissionData.Text = "Private";
            }

        
        }

        private void get_album_thumbs_from_picasa(Object data) {
            PicasaAlbum selected_album = (PicasaAlbum)data;
            PicasaPicture[] album_pics = selected_album.GetPictures().AllValues;
            string next_page = "";
            next_page += "<html><head><title>";
            next_page += selected_album.Title;
            next_page += "</title></head><body>";
            next_page += selected_album.Title;
            next_page += "</br>";
            foreach (PicasaPicture pic in album_pics) {
                next_page += "<a href=\"";
                next_page += pic.ImageURL;
                next_page += "\">";
                next_page += "<img src=\"";
                next_page += pic.ThumbnailURL;
                next_page += "\"/>";
                next_page += "</a>";
            }
            next_page += "</body></html>";
            albumPhotoBrowser.DocumentText = next_page;
        }

        private void get_album_thumbs_from_local(Object data) {
            StupidContainer stupid = (StupidContainer)data;
            PicasaAlbum album_to_upload_to = stupid.album;
            string[] filenames = stupid.filenames;
            /*string next_page = "";
            next_page += "<html><head><title>";
            next_page += "Photos to Upload";
            next_page += "</title></head><body>";
            next_page += "Photos to Upload"; ;
            next_page += "</br>";*/
            foreach (string filename in filenames) {

                album_to_upload_to.UploadPicture(filename);

                //next_page += "<img width=\"100px\" src=\"";
                //next_page += filename;
                //next_page += "\"/>";
            }
            
            //albumPhotoBrowser.DocumentText = next_page;
            System.Console.WriteLine("Done uploading");

            string next_page = "";
            next_page += "<html><head><title>";
            next_page += "Upload results";
            next_page += "</title></head><body>";
            next_page += "Finished Uploading.";
            next_page += "</br>";
            next_page += "Album Name: " + album_to_upload_to.Title;
            next_page += "</br>";
            next_page += "Photos: ";
            next_page += "</br>";
            foreach (PicasaPicture pic in album_to_upload_to.GetPictures().AllValues) {
                next_page += "<img src=\"";
                next_page += pic.ThumbnailURL;
                next_page += "\"/>";
            }


            next_page += "</body></html>";

            albumPhotoBrowser.DocumentText = next_page;
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e) {

            if (null == pam || null == pam.LoggedIn) {
                NotifyDialog please_login = new NotifyDialog();
                please_login.NotificationMessage = "Please login, then proceed to upload.";
                please_login.ShowDialog();
            } else {

                OpenFileDialog get_filenames_to_upload = new OpenFileDialog();
                get_filenames_to_upload.Multiselect = true;
                if (get_filenames_to_upload.ShowDialog() == DialogResult.OK) {

                    string next_page = "";
                    next_page += "<html><head><title>";
                    next_page += "Photo Upload";
                    next_page += "</title></head><body>";
                    next_page += "Uploading " + get_filenames_to_upload.FileNames.Length;

                    if (get_filenames_to_upload.FileNames.Length > 1) {
                        next_page += " photos ";
                    } else if (get_filenames_to_upload.FileNames.Length == 1) {
                        next_page += " photo ";
                    } else {
                        throw new Exception("Must select 1 or more photos for upload!");
                    }

                    next_page += "to " + myAlbums[albumList.SelectedIndex].Title + " ...";

                    next_page += "</br>";
                    next_page += "</body></html>";

                    albumPhotoBrowser.DocumentText = next_page;

                    StupidContainer stupid = new StupidContainer();
                    stupid.album = myAlbums[albumList.SelectedIndex];
                    stupid.filenames = get_filenames_to_upload.FileNames;

                    if (display_photos_thread != null) {
                        display_photos_thread.Abort();
                    }
                    display_photos_thread = new Thread(get_album_thumbs_from_local);
                    display_photos_thread.Start(stupid);

                }
            }
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e) {
            System.Console.WriteLine("Close!");
            if (display_photos_thread != null) {
                display_photos_thread.Abort();
            }
            albumPhotoBrowser.Stop();
            albumPhotoBrowser.SuspendLayout();
        }

 

    }
}
