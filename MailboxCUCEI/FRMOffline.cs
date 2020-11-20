﻿using System;
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
    public partial class FRMOffline : Form
    {
        public FRMOffline()
        {
            InitializeComponent();
        }
        List<Historias> ListStories = new List<Historias>();
        List<Historias> ResultSearch;
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
            string query = "SELECT h.Nom_Historia,h.ID_Historia,h.Resumen,h.ID_Genero,h.Fo_Portada,h.Raiting,h.Estatus,Base.ID_Usuario,h.Seguidores,h.Favoritos,h.Vistas,u.Nombre From Usuarios_Historias AS Base INNER JOIN Usuarios AS u ON u.Codigo = Base.ID_Usuario INNER JOIN Historias AS h ON h.ID_Historia = Base.ID_Historia  ORDER BY h.Vistas DESC LIMIT 10 ";
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
        string ChaptersList;
        private void Principal_Load(object sender, EventArgs e)
        {
            if (File.Exists("DataDownload.ntf"))
            {
                string line;
                StreamReader sr = new StreamReader("DataDownload.ntf");
                //Read the first line of text
                line = sr.ReadLine();
                int LocalX = 0;
                //Continue to read until you reach end of file
                while (line != null)
                {
                    string nombre, cover;
                    string[] name = line.Split('?');
                    nombre = name[0];
                    string[] aux = name[1].Split('#');
                    cover = aux[0];
                    //Llenar Panel
                    PictureBox pbox = new PictureBox();
                    pbox.Size = new Size(194, 138);
                    pbox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbox.Location = new Point(LocalX, 0);
                    pbox.Image = Image.FromFile(cover);
                    //Crear Boton
                    Button lblPlateNOBAR = new Button();
                    lblPlateNOBAR.Text = nombre;
                    lblPlateNOBAR.FlatStyle = FlatStyle.Flat;
                    lblPlateNOBAR.Font = new Font("Arial Narrow", 12);
                    lblPlateNOBAR.Size = new Size(194, 30);
                    lblPlateNOBAR.ForeColor = Color.DodgerBlue;
                    lblPlateNOBAR.Location = new Point(LocalX, 140);
                    lblPlateNOBAR.Click += new EventHandler(handlerComun_Click);
                    PNResults.Controls.Add(pbox);
                    PNResults.Controls.Add(lblPlateNOBAR);
                    LocalX = LocalX + 209;
                    //Finalizar

                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
            }
        }
        private void handlerComun_Click (object sender, EventArgs e)
        {
            string line;
            StreamReader sr = new StreamReader("DataDownload.ntf");
            //Read the first line of text
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                string nombre, cover, chapters;
                string[] name = line.Split('?');
                nombre = name[0];
                if (nombre == ((Button)sender).Text)
                {
                    string[] aux = name[1].Split('#');
                    cover = aux[0];
                    chapters = aux[1];
                    FRMReadZone Leer = new FRMReadZone();
                    Leer.Offline = true;
                    Leer.ChaptersOffline = chapters;
                    Leer.StoryName = nombre;
                    this.Dispose();
                    Leer.Show();
                }
                line = sr.ReadLine();
            }
            sr.Close();
        }
        private void BTNVisualizar_Click(object sender, EventArgs e)
        {

        }

        private void BTNRefrescar_Click(object sender, EventArgs e)
        {
            
        }
        private void BTNRespaldo_Click(object sender, EventArgs e)
        {
            
        }
		void BTNEscribirClick(object sender, EventArgs e)
		{
			FRMPreWri Nueva = new FRMPreWri();
			this.Hide();
			Nueva.Show();
            Nueva.ActUser = ActUser;
		}

        private void BtnPerfil_Click(object sender, EventArgs e)
        {
            Administrador op = new Administrador();
            op.TxtCodigoPerfil.Text = manduser.Text;
            this.Hide();
            op.ActUser = ActUser;
            op.Show();
        }

        private void txtsearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {   
        }

        private void btnSB_Click(object sender, EventArgs e)
        {
            
            
        }

        private void CBSort_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
        void CreateResultsSort(IEnumerable<Historias> Temp)
        {
            int LocalX = 0;
            foreach (Historias elements in Temp)
            {
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
                PNResults.Controls.Add(pbox);
                PNResults.Controls.Add(lblPlateNOBAR);
                LocalX = LocalX + 209;
            }
        }
        private void CBSort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form regreso = new Login();
            regreso.Show();
            Hide();
        }
    }
}