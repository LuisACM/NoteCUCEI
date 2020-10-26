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

        void DownloadImage(string URL)
        {
            Cliente.DownloadFile(new Uri(URL), @"\Images\ImagenDePrueba.jpg");
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
        public bool User;
        public void Cargar_data_grid()
        {
            MySqlConnection con = new MySqlConnection("server=127.0.0.1; database=mailbox; Uid=root; pdw=;");
            MySqlCommand comando = new MySqlCommand("Select *FROM reportes", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);

        }


        public Usuario ActUser; //Variable de los datos del usuario
        private void Principal_Load(object sender, EventArgs e)
        {
            // Cargar_data_grid();
            if (User)
            {
                BTNEscribir.Enabled = false;
            }
            string query = "SELECT * FROM Historias";
            string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
            MySqlConnection connetionBD = new MySqlConnection(conexion);
            MySqlCommand comando = new MySqlCommand(query, connetionBD);
            MySqlDataReader lector;
            connetionBD.Open();
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Historias element = new Historias(lector.GetString(0), lector.GetInt32(1), lector.GetString(2), lector.GetString(3), lector.GetString(4), lector.GetString(5), lector.GetString(6), lector.GetInt32(7), lector.GetInt32(8), lector.GetInt32(8), lector.GetInt32(10));
                ListStories.Add(element);
            }

            int right = 50;

            // Create Image + Text
            Historias tempelement = ListStories[0];
            PictureBox pbox = new PictureBox();
            pbox.Size = new Size(194, 138);
            pbox.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox.Location = new Point(0, 0);
            pbox.Image = Image.FromFile(@"ImagenDePrueba.jpg");

            
            Button lblPlateNOBAR = new Button();
            lblPlateNOBAR.Text = "Holita";
            lblPlateNOBAR.Font = new Font("Arial Narrow",12);
            lblPlateNOBAR.Size = new Size(100,100);
            lblPlateNOBAR.ForeColor = Color.DodgerBlue;
            lblPlateNOBAR.Location = new Point(225, 119);
            lblPlateNOBAR.AutoSize = true;
            lblPlateNOBAR.Visible = true;
            PanelTopStories.Controls.Add(pbox);
            PanelTopStories.Controls.Add(lblPlateNOBAR);


        }

        private void BTNAprobar_Click(object sender, EventArgs e)
        {
            
        }

        

        private void BTNVisualizar_Click(object sender, EventArgs e)
        {

        }

        private void BTNRefrescar_Click(object sender, EventArgs e)
        {
            Cargar_data_grid();
        }

        private void BTNRefrescar_Click_1(object sender, EventArgs e)
        {
            Cargar_data_grid();
            
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
