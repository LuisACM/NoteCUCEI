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
using System.IO;
using System.Drawing.Imaging;
using System.Net;

namespace MailboxCUCEI
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }
        public Usuario ActUser;
        private WebClient Cliente = new WebClient();
        public Dictionary<int, string> Genero = new Dictionary<int, string>();
        public Dictionary<string, int> IGenero = new Dictionary<string, int>();
        Historias ActStory;
        bool NewImage = false;
        string InPathImage, nameFile;
        public Principal Base;
        List<Historias> ListStories = new List<Historias>(); //Lista de las historias del usuario
        List<Historias> ListStoriesEX = new List<Historias>(); //Lista de las historias de seguidores del usuario
        List<Capitulos> capitulos = new List<Capitulos>(); //Lista de los capitulos
        string Descargar;
        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        public int NotifyNumber;
        public void Administrador_Load(object sender, EventArgs e)
        {
            string cover = "";
            if (NotifyNumber!=0)
            {
                BTNNot.Text = "Notificaciones("+NotifyNumber.ToString()+ ")";
            }
            //aqui se cargan los datos del usuario en su correspondiente textbox
            MySqlConnection conexion = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
            MySqlCommand comando = new MySqlCommand("SELECT * FROM Usuarios WHERE Codigo = @ID", conexion);
            comando.Parameters.AddWithValue("@ID", TxtCodigoPerfil.Text);
            conexion.Open();
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                TxtNombrePerfil.Text = registro["Nombre"].ToString();
                TxtCorreoPerfil.Text = registro["Correo"].ToString();
                TxtPassPerfil.Text = registro["Password"].ToString();
                FechaNac.Text = registro["F_Nacimiento"].ToString();
                Descargar = registro["Descargar"].ToString();
                cover = registro["Fo_Perfil"].ToString();
                if (Descargar == "True")
                {
                    RBYes.Checked = true;
                    RBNo.Checked = false;
                }
                else
                {
                    RBNo.Checked = true;
                    RBYes.Checked = false;
                }
            }
            conexion.Close();
            //Cargar Imagen
            DownloadImage("https://notecucei.000webhostapp.com/" + cover, cover);
            FotoPerfil.Image = Image.FromFile(cover);
            //carga del diccionario de datos
            Genero.Add(1, "Aventura");
            Genero.Add(2, "Romance");
            Genero.Add(3, "Ciencia Ficción");
            Genero.Add(4, "Drama");
            Genero.Add(5, "Fanfiction");
            Genero.Add(6, "Historica");
            Genero.Add(7, "Policia");
            Genero.Add(8, "Misterio");
            Genero.Add(9, "Fantasia");
            Genero.Add(11, "Suspenso");
            Genero.Add(12, "Tragedia");
            Genero.Add(13, "Terror");

            IGenero.Add("Aventura", 1);
            IGenero.Add("Romance", 2);
            IGenero.Add("Ciencia Ficción", 3);
            IGenero.Add("Drama", 4);
            IGenero.Add("Fanfiction", 5);
            IGenero.Add("Historica", 6);
            IGenero.Add("Policia", 7);
            IGenero.Add("Misterio", 8);
            IGenero.Add("Fantasia", 9);
            IGenero.Add("Suspenso", 11);
            IGenero.Add("Tragedia", 12);
            IGenero.Add("Terror", 13);
        }

        private void BTNEliminar_Click_1(object sender, EventArgs e)
        {
            //funcion de eliminar cuenta
            DialogResult result = MessageBox.Show("¿Seguro que quieres borrar tu cuenta? Si lo haces no la prodras recuperar nunca (y eso es mucho tiempo)", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                MySqlConnection conexion = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
                conexion.Open();
                string query = "DELETE FROM Usuarios WHERE Codigo='" + TxtCodigoPerfil.Text + "'";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado con exito");
                conexion.Close();
                this.Dispose();
                Login inicio = new Login();
                inicio.Show();
            }
            else if (result == DialogResult.No)
            {
                //... Do Nothing
            }
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            //funcion de modificar los datos

            MySqlConnection conexion = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
            conexion.Open();
            string Query = "UPDATE Usuarios SET Codigo='" + TxtCodigoPerfil.Text +
                "',Nombre='" + TxtNombrePerfil.Text +
                "',Correo='" + TxtCorreoPerfil.Text +
                "',Password='" + TxtPassPerfil.Text +
                "',F_Nacimiento='" + FechaNac.Text +
                "',Fo_Perfil ='" + namefile +
                "',Descargar='" + Descargar +
                "'WHERE Codigo='" + TxtCodigoPerfil.Text +
                "';";
            UploadImage();
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Datos guardados con éxito!");


        }

        private void BTNSalir_Click_1(object sender, EventArgs e)
        {
            Principal go = new Principal();
            go.User = Base.User;
            go.ActUser = Base.ActUser;
            go.manduser.Text = Base.manduser.Text;
            go.Show();
            this.Dispose();
        }
        string namefile;
        private void BTNFotoPerfil_Click(object sender, EventArgs e)
        {
            OpenFileDialog GetImage = new OpenFileDialog();
            GetImage.InitialDirectory = "c:\\";
            GetImage.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png*)|*.png*";
            if (GetImage.ShowDialog() == DialogResult.OK)
            {
                InPathImage = GetImage.FileName;
                namefile = GetImage.SafeFileName;
                FotoPerfil.ImageLocation = GetImage.FileName;
            }
            else
            {
                MessageBox.Show("No se selecciono imagen", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void handlerComun_Click(object sender, EventArgs e)
        {
            GBDetails.Visible = true;
            PBCover.Visible = true;
            BtnModi.Visible = true;
            BTNImage.Visible = true;
            foreach (Historias temp in ListStories)
            {

                if (((Button)sender).Text == temp.GetName())
                {
                    lblwarningchapters.Visible = false;
                    txtnombre.Text = temp.GetName();
                    CBRaiting.Text = temp.GetRaiting();
                    CBEstatus.Text = temp.GetStatus();
                    TXTSummary.Text = temp.GetSummary();
                    PBCover.Image = Image.FromFile(temp.GetCover());
                    Generos(temp.GetGender());
                    SelectedStoryID = temp.GetID();
                    LoadChapters(temp.GetID());
                    ActStory = temp;
                }

            }
        }
        int SelectedStoryID;
        void LoadChapters(int ID)
        {
            capitulos.Clear();
            panel1.Controls.Clear();
            panel1.Controls.Add(lblwarningchapters);
            string query = "SELECT * FROM Historias_Capitulos AS Base  INNER JOIN Capitulo AS C ON C.ID_Cap = Base.ID_Capitulo WHERE ID_Historia = " + ID;
            string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
            MySqlConnection connetionBD = new MySqlConnection(conexion);
            MySqlCommand comando = new MySqlCommand(query, connetionBD);
            MySqlDataReader lector;
            connetionBD.Open();
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Capitulos element = new Capitulos(lector.GetInt32(2), lector.GetString(3), lector.GetInt32(4), lector.GetString(5));
                capitulos.Add(element);
            }
            int LocalX = 3;
            foreach (Capitulos temp in capitulos)
            {
                lblwarningchapters.Visible = false;
                Button lblPlateNOBAR = new Button();
                lblPlateNOBAR.Tag = temp.GetID();
                lblPlateNOBAR.Text = temp.GetName();
                lblPlateNOBAR.FlatStyle = FlatStyle.Flat;
                lblPlateNOBAR.Font = new Font("Consolas", 9,FontStyle.Bold);
                lblPlateNOBAR.Size = new Size(464, 28);
                lblPlateNOBAR.ForeColor = Color.Black;
                lblPlateNOBAR.Location = new Point(0, LocalX);
                lblPlateNOBAR.Click += new EventHandler(NewhandlerComun_Click);
                panel1.Controls.Add(lblPlateNOBAR);
                LocalX = LocalX + 35;
            }
            connetionBD.Close();
        }
        private void NewhandlerComun_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres borrar este capitulo?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                string Query = "DELETE FROM `Capitulo` WHERE `Capitulo`.`ID_Cap` = " + ((Button)sender).Tag.ToString() + ";";
                MySqlConnection conexion = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(Query, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                panel1.Controls.Clear();
                LoadChapters(SelectedStoryID);
            }
            else if (result == DialogResult.No)
            {
                //... Do Nothing
            }
        }
        void LoadStories()
        {
            ListStories.Clear();
            string query = "SELECT * FROM Usuarios_Historias AS Base INNER JOIN Historias AS H ON H.ID_Historia = Base.ID_Historia WHERE ID_Usuario = " + ActUser.GetID();
            string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
            MySqlConnection connetionBD = new MySqlConnection(conexion);
            MySqlCommand comando = new MySqlCommand(query, connetionBD);
            MySqlDataReader lector;
            connetionBD.Open();
            lector = comando.ExecuteReader();
            while (lector.Read())
            {

                Historias element = new Historias(lector.GetString(2), lector.GetInt32(1), lector.GetString(4), lector.GetString(5), lector.GetString(6), lector.GetString(7), lector.GetString(8), ActUser.GetID(), lector.GetInt32(9), lector.GetInt32(10), lector.GetInt32(11), ActUser.GetNombre());
                DownloadImage("https://notecucei.000webhostapp.com/" + element.GetCover(), element.GetCover());
                ListStories.Add(element);
            }
            connetionBD.Close();
        }
        void DownloadImage(string URL, String Name)
        {
            if (File.Exists(Name))
            {
                return;
            }
            else
            {
                Cliente.DownloadFile(new Uri(URL), Name);
            }
        }
        private void Generos(string code)
        {
            /*
            Aventura
            Romance
            Ciencia Ficción
            Drama
            Fanfiction
            Historica
            Policia
            Misterio
            Fantasia
            Suspenso
            Tragedia
            Terror
             */
            string[] splited = code.Split('|');
            int aux = Int32.Parse(splited[0]);
            CBGender1.Text = Genero[aux];
            if (splited[1] != "NONE")
            {
                aux = Int32.Parse(splited[1]);
                CBGender2.Text = Genero[aux];

            }

        }

        void UploadImage()
        {
            try
            {
                WebClient client = new WebClient();
                client.Credentials = CredentialCache.DefaultCredentials;
                client.UploadFile(@"https://notecucei.000webhostapp.com/upload.php?namefile=" + namefile, "POST", InPathImage);
                client.Dispose();
                MessageBox.Show("Imagen Subida con Exito");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        string GenerateCode()
        {
            string Code = "";
            Code = Code + IGenero[CBGender1.Text].ToString();
            if (CBGender2.Text == "")
            {
                Code = Code + "|NONE";
            }
            else
            {
                Code = Code + "|" + IGenero[CBGender2.Text].ToString();
            }
            return Code;
        }

        private void BTNImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog WindownForCover = new OpenFileDialog();
            WindownForCover.InitialDirectory = "c:\\";
            WindownForCover.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png*)|*.png*";
            WindownForCover.FilterIndex = 2;
            WindownForCover.RestoreDirectory = true;
            if (WindownForCover.ShowDialog() == DialogResult.OK)
            {
                InPathImage = WindownForCover.FileName;
                PBCover.Image = Image.FromFile(InPathImage);
                nameFile = WindownForCover.SafeFileName;
                NewImage = true;
            }
        }

        private void BtnModi_Click(object sender, EventArgs e)
        {
            if (NewImage == false)
            {
                nameFile = ActStory.GetCover();
            }

            MySqlConnection conexion = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
            conexion.Open();
            string Query = "UPDATE `Historias` SET `Nom_Historia` = '" + txtnombre.Text + "', `Resumen` = '" + TXTSummary.Text + "', `ID_Genero` = '" + GenerateCode() + "', `Fo_Portada` = '" + nameFile + "', `Raiting` = '" + CBRaiting.Text + "', `Estatus` = '" + CBEstatus.Text + "' WHERE `Historias`.`ID_Historia` =" + ActStory.GetID() + ";";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            if (NewImage)
            {
                UploadImage();
            }
            MessageBox.Show("Historia actualizada con exito");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres borrar tu historia? (Una vez borrada, no podras volver a recuperarla y solo los lectores que hayan podido descargarla podran leerla)", "Confirmación", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                MySqlConnection conexion = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
                conexion.Open();
                string Query = "DELETE FROM `Historias` WHERE `Historias`.`ID_Historia` =" + ActStory.GetID() + ";";
                MySqlCommand comando = new MySqlCommand(Query, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                GBDetails.Visible = false;
                PBCover.Image = null;
                BTNMyStories_Click(sender, e);
            }
            else if (result == DialogResult.No)
            {
                //... Do Nothing
            }
        }

        private void BTNMyInfo_Click(object sender, EventArgs e)
        {
            GBNotify.Visible = false;
            GBFv.Visible = false;
            GBStories.Visible = false;
            BTNEliminar.Visible = true;
        }

        private void BTNMyStories_Click(object sender, EventArgs e)
        {
            GBNotify.Visible = false;
            GBStories.Visible = true;
            GBFv.Visible = false;
            BTNEliminar.Visible = false;
            WaitForm Wait = new WaitForm();
            Wait.Show();
            // Codigo para crear el GB
            //Cargar Historias del usuario
            LoadStories();
            if (ListStories == null)
            {

            }
            else
            {
                PNResults.Controls.Clear();
                int LocalX = 1;
                foreach (Historias elements in ListStories)
                {
                    lblWarningMyStory.Visible = false;
                    Historias tempelement = ListStories[0];
                    PictureBox pbox = new PictureBox();
                    pbox.Size = new Size(194, 138);
                    pbox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbox.Location = new Point(LocalX, 0);
                    pbox.Image = Image.FromFile(elements.GetCover());
                    //Crear Boton
                    Button lblPlateNOBAR = new Button();
                    lblPlateNOBAR.Text = elements.GetName();
                    lblPlateNOBAR.FlatStyle = FlatStyle.Flat;
                    lblPlateNOBAR.Font = new Font("Consolas", 9,FontStyle.Bold);
                    lblPlateNOBAR.Size = new Size(194, 30);
                    lblPlateNOBAR.ForeColor = Color.Black;
                    lblPlateNOBAR.Location = new Point(LocalX, 140);
                    lblPlateNOBAR.Click += new EventHandler(handlerComun_Click);
                    PNResults.Controls.Add(pbox);
                    PNResults.Controls.Add(lblPlateNOBAR);
                    LocalX = LocalX + 209;
                }
            }


            Wait.Dispose();
        }

        private void txtnombre_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "Nombre")
            {
                txtnombre.Text = "";
            }
        }

        private void TXTSummary_Click(object sender, EventArgs e)
        {
            if (TXTSummary.Text == "Escribe aqui una pequeña descripción de tu obra.")
            {
                TXTSummary.Text = "";
            }
        }

        private void RBYes_CheckedChanged(object sender, EventArgs e)
        {
            if (RBYes.Checked)
            {
                Descargar = "true";
                RBNo.Checked = false;
            }
        }

        private void RBNo_CheckedChanged(object sender, EventArgs e)
        {
            if (RBNo.Checked)
            {
                Descargar = "false";
                RBYes.Checked = false;
            }
        }

        private void BTNFF_Click(object sender, EventArgs e)
        {
            GBNotify.Visible = false;
            ListStories.Clear();
            GBFv.Visible = true;
            GBFollows.Visible = true;
            GBStories.Visible = false;
            BTNEliminar.Visible = false;
            LoadStoriesEX("Favoritos");
            //Llenar Panel de Favoritos
            PNFavs.Controls.Clear();
            PNFavs.Controls.Add(lblWarningFavs);
            int LocalX = 1;
            foreach (Historias elements in ListStories)
            {
                lblWarningFavs.Visible = false;
                Historias tempelement = ListStories[0];
                PictureBox pbox = new PictureBox();
                pbox.Size = new Size(194, 138);
                pbox.SizeMode = PictureBoxSizeMode.StretchImage;
                pbox.Location = new Point(LocalX, 0);
                pbox.Image = Image.FromFile(elements.GetCover());
                //Crear Boton
                Button lblPlateNOBAR = new Button();
                lblPlateNOBAR.Tag =elements.GetID();
                lblPlateNOBAR.Text = elements.GetName();
                lblPlateNOBAR.FlatStyle = FlatStyle.Flat;
                lblPlateNOBAR.Font = new Font("Consolas", 9, FontStyle.Bold);
                lblPlateNOBAR.Size = new Size(194, 30);
                lblPlateNOBAR.ForeColor = Color.Black;
                lblPlateNOBAR.Location = new Point(LocalX, 140);
                lblPlateNOBAR.Click += new EventHandler(NewhandlerComunEX_Click);
                PNFavs.Controls.Add(pbox);
                PNFavs.Controls.Add(lblPlateNOBAR);
                LocalX = LocalX + 209;
            }
            //Fin
            //
            ListStoriesEX.Clear();
            LoadStoriesEX("Seguidores");
            //Llenas Panel de Seguidores
            PNFollows.Controls.Clear();
            PNFollows.Controls.Add(LBLWarningStory);
            LocalX = 1;
            foreach (Historias elements in ListStoriesEX)
            {
                LBLWarningStory.Visible = false;
                Historias tempelement = ListStories[0];
                PictureBox pbox = new PictureBox();
                pbox.Size = new Size(194, 138);
                pbox.SizeMode = PictureBoxSizeMode.StretchImage;
                pbox.Location = new Point(LocalX, 0);
                pbox.Image = Image.FromFile(elements.GetCover());
                //Crear Boton
                Button lblPlateNOBAR = new Button();
                lblPlateNOBAR.Tag = elements.GetID();
                lblPlateNOBAR.Text = elements.GetName();
                lblPlateNOBAR.FlatStyle = FlatStyle.Flat;
                lblPlateNOBAR.Font = new Font("Consolas", 9,FontStyle.Bold);
                lblPlateNOBAR.Size = new Size(194, 30);
                lblPlateNOBAR.ForeColor = Color.Black;
                lblPlateNOBAR.Location = new Point(LocalX, 140);
                lblPlateNOBAR.Click += new EventHandler(NewhandlerComunEX_Click);
                PNFollows.Controls.Add(pbox);
                PNFollows.Controls.Add(lblPlateNOBAR);
                LocalX = LocalX + 209;
            }
            //Fin
        }
        private void NewhandlerComunEX_Click(object sender, EventArgs e)
        {
            bool Control = false;
            foreach (Historias temp in ListStories)
            {
                if (((Button)sender).Text == temp.GetName())
                {
                    MessageBox.Show("Iras a Favoritos");
                    FRMPreview Prev = new FRMPreview();
                    Prev.ActUser = ActUser;
                    Prev.Ventana = this.Base;
                    Prev.Story = temp;
                    Prev.Show();
                    Control = true;
                    this.Dispose();
                }
            }
            if (Control)
            {
                return;
            }
            else
            {
            foreach (Historias temp in ListStoriesEX)
                {
                    if (((Button)sender).Text == temp.GetName())
                    {
                        MessageBox.Show("Iras a Seguidores");
                        FRMPreview Prev = new FRMPreview();
                        Prev.ActUser = ActUser;
                        Prev.Ventana = this.Base;
                        Prev.Story = temp;
                        Prev.Show();
                        this.Dispose();
                    }
                }
            }
            
        }
        void LoadStoriesEX(string tabla)
        {
            if (tabla == "Favoritos")
            {
                string query = "SELECT * FROM "+tabla+" AS S INNER JOIN Historias AS H ON S.ID_Historia=H.ID_Historia WHERE S.ID_Usuario = " + Base.ActUser.GetID();
                string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
                MySqlConnection connetionBD = new MySqlConnection(conexion);
                MySqlCommand comando = new MySqlCommand(query, connetionBD);
                MySqlDataReader lector;
                connetionBD.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Historias element = new Historias(lector.GetString(3), lector.GetInt32(2), lector.GetString(5), lector.GetString(6), lector.GetString(7), lector.GetString(8), lector.GetString(9), ActUser.GetID(), lector.GetInt32(10), lector.GetInt32(11), lector.GetInt32(12), ActUser.GetNombre());
                    DownloadImage("https://notecucei.000webhostapp.com/" + element.GetCover(), element.GetCover());
                    ListStories.Add(element);
                }
                connetionBD.Close();
            }
            else
            {
                string query = "SELECT * FROM " + tabla + " AS S INNER JOIN Historias AS H ON S.ID_Historia=H.ID_Historia WHERE S.ID_Usuario = " + ActUser.GetID();
                string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
                MySqlConnection connetionBD = new MySqlConnection(conexion);
                MySqlCommand comando = new MySqlCommand(query, connetionBD);
                MySqlDataReader lector;
                connetionBD.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Historias element = new Historias(lector.GetString(2), lector.GetInt32(1), lector.GetString(4), lector.GetString(5), lector.GetString(6), lector.GetString(7), lector.GetString(8), ActUser.GetID(), lector.GetInt32(9), lector.GetInt32(10), lector.GetInt32(11), ActUser.GetNombre());
                    DownloadImage("https://notecucei.000webhostapp.com/" + element.GetCover(), element.GetCover());
                    ListStoriesEX.Add(element);
                }
                connetionBD.Close();
            }
        }

        private void BTNNot_Click(object sender, EventArgs e)
        {
            BTNEliminar.Visible = false;
            GBNotify.Visible = true;
            GBStories.Visible = false;
            GBFv.Visible = false;
            PNNotify.Controls.Clear();
            PNNotify.Controls.Add(lblwarningHurra);
            string query = "SELECT *From Notificaciones WHERE ID_Usuario = " + ActUser.GetID();
            string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
            MySqlConnection connetionBD = new MySqlConnection(conexion);
            MySqlCommand comando = new MySqlCommand(query, connetionBD);
            MySqlDataReader lector;
            connetionBD.Open();
            lector = comando.ExecuteReader();
            int LocalX = 4;
            while (lector.Read())
            {
                lblwarningHurra.Visible = false;
                Label lblPlateNOBAR = new Label();
                lblPlateNOBAR.Text = lector.GetString(1);
                lblPlateNOBAR.FlatStyle = FlatStyle.Flat;
                lblPlateNOBAR.BorderStyle = BorderStyle.FixedSingle;
                if (lector.GetInt32(2)== 0)
                {
                    lblPlateNOBAR.Font = new Font("Consolas", 9,FontStyle.Regular);
                }
                else
                {
                    lblPlateNOBAR.Font = new Font("Consolas", 9, FontStyle.Bold);
                }
                lblPlateNOBAR.Size = new Size(749, 45);
                lblPlateNOBAR.ForeColor = Color.Black;
                lblPlateNOBAR.MouseHover += new EventHandler(handlerComun_MouseHover);
                lblPlateNOBAR.Location = new Point(4,LocalX);
                LocalX = LocalX + 50;
                PNNotify.Controls.Add(lblPlateNOBAR);
            }
            connetionBD.Close();
            BTNNot.Text = "Notificaciones";
            query = "UPDATE Notificaciones SET Estatus = 0 WHERE ID_Usuario = " + ActUser.GetID();
            MySqlConnection conexion2 = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
            conexion2.Open();
            MySqlCommand comando2 = new MySqlCommand(query, conexion2);
            comando2.ExecuteNonQuery();
            conexion2.Close();

        }
        private void handlerComun_MouseHover(object sender, EventArgs e)
        {
            ((Label)sender).Font = new Font(((Label)sender).Font, FontStyle.Regular);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres borrar limpiar tu bandeja de notificaciones?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                MySqlConnection conexion = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
                conexion.Open();
                string query = "DELETE FROM Notificaciones WHERE ID_Usuario='" + ActUser.GetID() + "'";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                PNNotify.Controls.Clear();
                lblwarningHurra.Visible = true;
            }
            else if (result == DialogResult.No)
            {
                //... Do Nothing
            }
        }

        private void verCB_CheckedChanged(object sender, EventArgs e)
        {
            if (verCB.Checked == true)
            {
                if (TxtPassPerfil.PasswordChar == '*')
                {
                    TxtPassPerfil.PasswordChar = '\0';
                }
            }
            else
            {
                TxtPassPerfil.PasswordChar = '*';
            }
        }

        void Reload()
        {
            panel1.Controls.Clear();
            GBDetails.Visible = false;
        }
    }
}