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

namespace MailboxCUCEI
{
    public partial class FRMSelectStory : Form
    {
    	public Principal NueaVentana;
        public FRMSelectStory()
        {
            InitializeComponent();
        }
        private void FRMSelectStory_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM `Historias` WHERE `ID_Usuario` = " +NueaVentana.ActUser.GetID()+" ";
            string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
            MySqlConnection connetionBD = new MySqlConnection(conexion);
            MySqlCommand comando = new MySqlCommand(query, connetionBD);
            MySqlDataReader lector;
            connetionBD.Open();
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                CBStory.Items.Add(lector.GetString(0));
            }
            connetionBD.Close();
        }
        int ConvertInt (string Word)
        {
            return Int32.Parse(Word) ;
        }
        string DefineGender (string codes)
        {
            string Generos="";
            bool b = codes.Contains("NONE");
            if (b)
            {
                string[] generos = codes.Split('|');
                string query = "SELECT * FROM `Generos` WHERE `ID_Genero` ='" + generos[0] +"'";
                string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
                MySqlConnection connetionBD = new MySqlConnection(conexion);
                MySqlCommand comando = new MySqlCommand(query, connetionBD);
                MySqlDataReader lector;
                connetionBD.Open();
                lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    Generos = lector.GetString(1);
                }
                connetionBD.Close();
            }
            else
            {
                //SELECT * FROM `Generos` WHERE `Nombre` = 'Policiaca' OR `Nombre`='Aventura' 
                string[] generos = codes.Split('|');
                string query = "SELECT * FROM `Generos` WHERE `ID_Genero` = " + generos [0]+ " OR `ID_Genero`=" + generos[1]+"";
                string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
                MySqlConnection connetionBD = new MySqlConnection(conexion);
                MySqlCommand comando = new MySqlCommand(query, connetionBD);
                MySqlDataReader lector;
                connetionBD.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Generos = Generos +lector.GetString(1) + "";
                }
                connetionBD.Close();
            }
            return Generos;
        }
        private void BTNOk_Click(object sender, EventArgs e)
        {
            FRMWrite NewWindows = new FRMWrite();
            NewWindows.Ventana = NueaVentana;
            NewWindows.lblStoryName.Text = CBStory.Text;

            string query = "SELECT * FROM `Historias` WHERE `Nom_Historia` ='" + CBStory.Text + "'";
            string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
            MySqlConnection connetionBD = new MySqlConnection(conexion);
            MySqlCommand comando = new MySqlCommand(query, connetionBD);
            MySqlDataReader lector;
            connetionBD.Open();
            lector = comando.ExecuteReader();
            if (lector.Read())
            {
                NewWindows.ID_Historia = lector.GetInt32(1);
                NewWindows.lblraiting.Text = lector.GetString(5);
                NewWindows.LBLGenero.Text = DefineGender(lector.GetString(3));
                NewWindows.lblstatus.Text = lector.GetString(6);
            }
            connetionBD.Close();
            NewWindows.Show();
            this.Hide();
        }
    }
}
