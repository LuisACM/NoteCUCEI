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
using System.Data.SqlClient;
using System.Net;
using System.IO;

namespace MailboxCUCEI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        List<Historias> ListStories = new List<Historias>();
        private WebClient Cliente = new WebClient();

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
        private void BTNAdministracion_Click(object sender, EventArgs e)
        {
            Form acceso = new FRMPreWri();
            acceso.Show();
        }

        private void BTNCerrarSesion_Click(object sender, EventArgs e)
        {
            Form regreso = new Login();
            regreso.Show();
            Hide();
        }
        bool TopStoriesAlready = false;
        public bool User;
        public Usuario ActUser; //Variable de los datos del usuario
        
        void CreateStoryList ()
        {
            string query = "SELECT Historias.*, Usuarios.Nombre From Historias INNER JOIN Usuarios ON Historias.ID_Usuario = Usuarios.Codigo";
            string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
            MySqlConnection connetionBD = new MySqlConnection(conexion);
            MySqlCommand comando = new MySqlCommand(query, connetionBD);
            MySqlDataReader lector;
            connetionBD.Open();
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Historias element = new Historias(lector.GetString(0), lector.GetInt32(1), lector.GetString(2), lector.GetString(3), lector.GetString(4), lector.GetString(5), lector.GetString(6), lector.GetInt32(7), lector.GetInt32(8), lector.GetInt32(8), lector.GetInt32(10),lector.GetString(11));
                DownloadImage("https://notecucei.000webhostapp.com/"+element.GetCover(),element.GetCover());
                ListStories.Add(element);
            }
            connetionBD.Close();
        }
        private void Principal_Load(object sender, EventArgs e)
        {

            if (User)
            {
                BTNEscribir.Enabled = false;
            }
            CreateStoryList();
            CreateTopStorie();

        }
        void CreateTopStorie ()
        {
            if (TopStoriesAlready==false)
            {
                int LocalX = 0;
                foreach (Historias elements in ListStories)
                {
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
                    lblPlateNOBAR.Font = new Font("Arial Narrow", 12);
                    lblPlateNOBAR.Size = new Size(194, 30);
                    lblPlateNOBAR.ForeColor = Color.DodgerBlue;
                    lblPlateNOBAR.Location = new Point(LocalX, 140);
                    this.toolTip1.SetToolTip(lblPlateNOBAR, elements.GetSummary());
                    lblPlateNOBAR.Click += new EventHandler(handlerComun_Click);
                    PanelTopStories.Controls.Add(pbox);
                    PanelTopStories.Controls.Add(lblPlateNOBAR);
                    LocalX = LocalX + 209;
                    TopStoriesAlready = true;
                 }
            }
            
        }
        private void handlerComun_Click (object sender, EventArgs e)
        {
            foreach (Historias temp in ListStories)
            {
                
                if (((Button)sender).Text== temp.GetName())
                {
                    FRMPreview Prev = new FRMPreview();
                    Prev.Ventana = this;
                    Prev.Story = temp;
                    Prev.Show();
                    this.Hide();
                }
               
            }
        }
        private void BTNAprobar_Click(object sender, EventArgs e)
        {
            
        }

        

        private void BTNVisualizar_Click(object sender, EventArgs e)
        {

        }

        private void BTNRefrescar_Click(object sender, EventArgs e)
        {
            
        }

        private void BTNRefrescar_Click_1(object sender, EventArgs e)
        {
           
            
        }

        private void BTNLeer_Click(object sender, EventArgs e)
        {
            
        }

        private void BTNRespaldo_Click(object sender, EventArgs e)
        {
            
        }
		void BTNEscribirClick(object sender, EventArgs e)
		{
			FRMPreWri Nueva = new FRMPreWri();
			Nueva.NueaVentana=this;
			this.Hide();
			Nueva.Show();
            Nueva.ActUser = ActUser;
		}
    }
}
