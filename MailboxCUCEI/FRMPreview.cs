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
            if (Ventana.User)
            {
                CBDowload.Enabled = false;
                CBFav.Enabled = false;
                CBFollow.Enabled = false;
            }
            CanDownload();
            ControlForCheck = false;
            if (!Ventana.User)
            {
            CBFav.Checked = CheckFF("Favoritos");
            CBFollow.Checked = CheckFF("Seguidores");
            }
                
            ControlForCheck = true;
            LBLTitle.Text = Story.GetName();
            LBLGenero.Text = Generos(Story.GetGender());
            lblraiting.Text = Story.GetRaiting();
            lblstatus.Text = Story.GetStatus();
            lblSummary.Text = Story.GetSummary();
            PBCover.Image = Image.FromFile(Story.GetCover());
            LBLAuthor.Text = Story.GetNameUser();
            AlreadyDownload();
        }
        void CanDownload()
        {
            MySqlConnection conexion = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
            MySqlCommand comando = new MySqlCommand("SELECT * FROM Usuarios WHERE Codigo = @ID", conexion);
            comando.Parameters.AddWithValue("@ID", Story.GetID_User());
            conexion.Open();
            MySqlDataReader registro = comando.ExecuteReader();
            string control="";
            if (registro.Read())
            {
                control = registro["Descargar"].ToString();
            }
            conexion.Close();
            if (control == "false")
            {
                CBDowload.Enabled = false;
                this.toolTip1.SetToolTip(this.CBDowload, "Este usuario tiene inhabilitado la descarga de sus obras");
            }
        }
        bool CheckFF (string Tabla)
        {
            MySqlConnection conectar = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
            conectar.Open();
            MySqlCommand checkin = new MySqlCommand();
            MySqlConnection conectarya = new MySqlConnection();
            checkin.Connection = conectar;
            checkin.CommandText = ("SELECT *From "+ Tabla +" WHERE ID_Usuario='" + Ventana.ActUser.GetID() + "'and ID_Historia ='" + Story.GetID() + "'");
            MySqlDataReader leer = checkin.ExecuteReader();
            if (leer.Read())
            {
                conectar.Close();
                return true;
            }
            else
            {
                conectar.Close();
                return false;
            }

        }
        void AlreadyDownload ()
        {
            if (File.Exists("DataDownload.ntf"))
            {
                string line;
                StreamReader sr = new StreamReader("DataDownload.ntf");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    string[] name = line.Split('?');
                    if (name[0]==Story.GetName())
                    {   
                        CBDowload.Enabled = false;
                        CBDowload.Checked = true;
                    }
                    line = sr.ReadLine();
                }
            //close the file
            sr.Close();
            }
            else
            {
                // Do Nothing...
            }
            
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string query = "SELECT *FROM Historias_Capitulos WHERE ID_Historia= " + Story.GetID() + "  ";
            string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
            MySqlConnection connetionBD = new MySqlConnection(conexion);
            MySqlCommand comando = new MySqlCommand(query, connetionBD);
            MySqlDataReader lector;
            connetionBD.Open();
            lector = comando.ExecuteReader();
            
            if (!lector.Read())
            {
                MessageBox.Show("Esta historia aún no tiene capitulos publicados.");
                connetionBD.Close();
            }
            else
            {
            connetionBD.Close();
            FRMReadZone Leer = new FRMReadZone();
            Leer.Ventana = Ventana;
            Leer.ActUser = Ventana.ActUser;
            Leer.MainStory = Story;
            this.Dispose();
            Leer.Show();
            }
        }

        private void CBDowload_CheckedChanged(object sender, EventArgs e)
        {
            if (CBDowload.Enabled==false)
            {
                //Do Nothing...
            }
            else
            {

                StreamWriter sw = new StreamWriter("DataDownload.ntf");
                string query = "SELECT C.Ubicacion FROM Historias_Capitulos as HC INNER JOIN Capitulo as C ON C.ID_Cap = HC.ID_Capitulo WHERE HC.ID_Historia = " + Story.GetID() + " ";
                string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
                MySqlConnection connetionBD = new MySqlConnection(conexion);
                MySqlCommand comando = new MySqlCommand(query, connetionBD);
                MySqlDataReader lector;
                connetionBD.Open();
                lector = comando.ExecuteReader();
                string line = "";
                line = Story.GetName() + "?";
                line = line + Story.GetCover() + "#";
                while (lector.Read())
                {
                    line = line + lector.GetString(0) + "|";
                }
                sw.WriteLine(line);
                connetionBD.Close();
                sw.Close();
            }
            
        }
        bool ControlForCheck;
        private void CBFav_CheckedChanged(object sender, EventArgs e)
        {
            if (ControlForCheck)
            {
                if (Story.GetID_User() == ActUser.GetID())
                {
                    MessageBox.Show("No puedes darle a favorito a tu propia historia");
                }
                else
                {
                    if (CBFav.Checked == false)
                    {
                        string query = "DELETE FROM Favoritoss WHERE ID_Usuario = " + Ventana.ActUser.GetID() + " AND ID_Historia = " + Story.GetID();
                        MySqlConnection conectar = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
                        conectar.Open();
                        MySqlCommand comando = new MySqlCommand(query);
                        comando.Connection = conectar;
                        comando.ExecuteNonQuery();
                        conectar.Close();
                        MessageBox.Show("Historia eliminada de tus favoritos");
                    }
                    else
                    {
                        String query = "INSERT INTO `Favoritos` (`ID_Usuario`, `ID_Historia`) VALUES ('" + Ventana.ActUser.GetID() + "', '" + Story.GetID() + "');";
                        MySqlConnection conectar = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
                        conectar.Open();
                        MySqlCommand comando = new MySqlCommand(query);
                        comando.Connection = conectar;
                        comando.ExecuteNonQuery();
                        conectar.Close();
                        MessageBox.Show("Historia agregada a tus favoritos");
                    }
                }
                
            }
            
        }

        private void CBFollow_CheckedChanged(object sender, EventArgs e)
        {
            if (ControlForCheck)
            {
                if(Story.GetID_User() == ActUser.GetID())
                {
                    MessageBox.Show("No puedes seguir tu propia historia");
                }
                else
                {
                    if (CBFollow.Checked == false)
                    {
                        string query = "DELETE FROM Seguidores WHERE ID_Usuario = " + Ventana.ActUser.GetID() + " AND ID_Historia = " + Story.GetID();
                        MySqlConnection conectar = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
                        conectar.Open();
                        MySqlCommand comando = new MySqlCommand(query);
                        comando.Connection = conectar;
                        comando.ExecuteNonQuery();
                        conectar.Close();
                        MessageBox.Show("Ya no sigues esta historia");
                    }
                    else
                    {
                        String query = "INSERT INTO `Seguidores` (`ID_Usuario`, `ID_Historia`) VALUES ('" + Ventana.ActUser.GetID() + "', '" + Story.GetID() + "');";
                        MySqlConnection conectar = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
                        conectar.Open();
                        MySqlCommand comando = new MySqlCommand(query);
                        comando.Connection = conectar;
                        comando.ExecuteNonQuery();
                        conectar.Close();
                        MessageBox.Show("Ahora sigues esta historia");
                    }
                }
                
            }
        }

        private void GBDetails_Enter(object sender, EventArgs e)
        {

        }
    }
}