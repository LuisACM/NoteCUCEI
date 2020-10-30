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
using System.Net;
using System.Runtime.CompilerServices;

namespace MailboxCUCEI
{
    public partial class FRMPreview : Form
    {
		public Usuario ActUser;
    	public Principal Ventana;
		public Historias Story;
        public FRMPreview()
        {
            InitializeComponent();
        }

		public int ID_Historia = 0;
        public void BTNSalir_Click(object sender, EventArgs e)
        {
            Ventana.Show();
            this.Dispose();

        }
		void Label5Click(object sender, EventArgs e)
		{
	
		}
		
		void TxtCodigoModificarTextChanged(object sender, EventArgs e)
		{
	
		}
        public String Generos (String bases)
        {
            String temp="";
            if(!bases.Contains("NONE"))
            {
                string[] temporal = bases.Split('|');
                string query = "SELECT Generos.Nombre FROM `Generos` WHERE Generos.ID_Genero = "+temporal[0]+" UNION SELECT Generos.Nombre FROM `Generos` WHERE Generos.ID_Genero = "+temporal[1]+"  ";
                string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
                MySqlConnection connetionBD = new MySqlConnection(conexion);
                MySqlCommand comando = new MySqlCommand(query, connetionBD);
                MySqlDataReader lector;
                connetionBD.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    temp = lector.GetString(0) + " ";
                }
                connetionBD.Close();
            }
            else
            {
                string[] temporal = bases.Split('|');
                string query = "SELECT Generos.Nombre FROM `Generos` WHERE Generos.ID_Genero = " + temporal[0] +  "  ";
                string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
                MySqlConnection connetionBD = new MySqlConnection(conexion);
                MySqlCommand comando = new MySqlCommand(query, connetionBD);
                MySqlDataReader lector;
                connetionBD.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    temp = lector.GetString(0) + " ";
                }
                connetionBD.Close();
            }
            return temp; 
         }
        private void FRMWrite_Load(object sender, EventArgs e)
        {
            MessageBox.Show(ActUser.GetID().ToString());
            LBLTitle.Text = Story.GetName();
            LBLGenero.Text = Generos(Story.GetGender());
            lblraiting.Text = Story.GetRaiting();
            lblstatus.Text = Story.GetStatus();
            lblSummary.Text = Story.GetSummary();
            PBCover.Image = Image.FromFile(Story.GetCover());
            LBLAuthor.Text = Story.GetNameUser();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FRMReadZone Leer = new FRMReadZone();
            Leer.Ventana = Ventana;
            Leer.ActUser = Ventana.ActUser;
            Leer.MainStory = Story;
            this.Dispose();
            Leer.Show();
        }
    }
}
