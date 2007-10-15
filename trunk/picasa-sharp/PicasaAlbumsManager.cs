using System;
using System.Collections.Generic;
using System.Text;
using Mono.Google;
using Mono.Google.Picasa;

namespace picasa_sharp {
    class PicasaAlbumsManager {
        private string username;
        private string password;
        private GoogleConnection connection;
        private PicasaWeb web;
        private string display_member = "Title";
        private bool loggedIn = false;

        public bool LoggedIn {
            get {
                return this.loggedIn;
            }
        }

        public string DisplayMember {
            get {
                return this.display_member;
            }
        }

        public string Username {
            get {
                return this.username;
            }
            set {
                this.username = value;
            }
        }

        public string Password {
            get {
                return this.password;
            }
            set {
                this.password = value;
            }
        }

        public GoogleConnection Connection
        {
            get { return this.connection; }
        }


        public PicasaAlbumsManager(string username, string password) {
            this.username = username;
            this.password = password;
        }

        public void login() {
            try {
                connection = new GoogleConnection(GoogleService.Picasa);
                //ServicePointManager.CertificatePolicy = new NoCheckCertificatePolicy();
                connection.Authenticate(this.username, this.password);
                web = new PicasaWeb(connection);
                this.loggedIn = true;
            } catch (Exception) {
                this.loggedIn = false;
            }
        }

        public PicasaAlbumCollection getAllAlbums() {
            return web.GetAlbums();
        }

        public PicasaWeb getWeb() {
            return this.web;
        }
    }
}
