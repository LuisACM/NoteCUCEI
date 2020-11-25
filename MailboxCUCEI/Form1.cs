using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.Threading;
using System.Security.Cryptography;

namespace MailboxCUCEI
{
    public partial class Login : Form
    {


        public static string Llave = "jwey89e09ewhfo24";
        public Login()
        {
            InitializeComponent();
        }
        bool Offline = false;

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if(TxtUsuario.Text=="Código")
            {
                TxtUsuario.Text = "";
                TxtUsuario.ForeColor = Color.Black;
            }
        }

        Usuario ActUser;
        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if(TxtUsuario.Text=="")
            {
                TxtUsuario.Text = "Código";
                TxtUsuario.ForeColor = Color.Black;
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "Contraseña")
            {
                TxtPassword.Text = "";
                TxtPassword.ForeColor = Color.Black;
                TxtPassword.UseSystemPasswordChar = true;
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "")
            {
                TxtPassword.Text = "Contraseña";
                TxtPassword.ForeColor = Color.Black;
                TxtPassword.UseSystemPasswordChar = false;
            }
        }

        private void BTNCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void BTNMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
            WaitForm Esperar = new WaitForm();
        void GenerateUser () //Función para generar ActUser de la clase Usuario
        {
            string query = "SELECT * FROM `Usuarios` WHERE `Codigo` = '" + TxtUsuario.Text + "' ";
           
            string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
            MySqlConnection connetionBD = new MySqlConnection(conexion);
            MySqlCommand comando = new MySqlCommand(query,connetionBD);
            MySqlDataReader lector;
            connetionBD.Open();
            lector = comando.ExecuteReader();
            if (lector.Read())
            {
                ActUser = new Usuario(lector.GetInt32(0),lector.GetString(1), lector.GetString(2), lector.GetString(3), lector.GetString(4),lector.GetString(5)); 
            }
            connetionBD.Close();
        }

        public string Decriptar(string dato, string llave)
        {
            byte[] keyArray;
            byte[] decriptar = Convert.FromBase64String(dato);
            keyArray = Encoding.UTF8.GetBytes(llave);
            var tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultado = cTransform.TransformFinalBlock(decriptar, 0, decriptar.Length);
            tdes.Clear();
            return Encoding.UTF8.GetString(resultado);
        }

        void RecuperarPass()
        {
            
            MySqlConnection conexion = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
            MySqlCommand comando = new MySqlCommand("SELECT * FROM Usuarios WHERE Codigo = @ID", conexion);
            comando.Parameters.AddWithValue("@ID", TxtUsuario.Text);
            conexion.Open();
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                lblComparacion.Text = registro["Password"].ToString();
            }
            conexion.Close();
        }

        private void BtnInicioSesion_Click(object sender, EventArgs e)
        {
            if (Offline)
            {
                FRMOffline NuevaVentana = new FRMOffline();
                NuevaVentana.Show();
                this.Hide();
            }
            else
            {
                Esperar.Show();
                RecuperarPass();//recupera encriptada de la BD
                lblComparacion.Text = Decriptar(lblComparacion.Text, Llave);//desencripta y guarda en lbl
                MySqlConnection conectar = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
                conectar.Open();
                MySqlCommand checkin = new MySqlCommand();
                MySqlConnection conectarya = new MySqlConnection();
                checkin.Connection = conectar;
                checkin.CommandText = ("SELECT *From Usuarios WHERE Codigo='" + TxtUsuario.Text + "'");
                if (TxtPassword.Text == lblComparacion.Text)
                {
                    MySqlDataReader leer = checkin.ExecuteReader();
                    if (leer.Read())
                    {
                        GenerateUser();
                        conectar.Close();
                        Thread.Sleep(3000);
                        MessageBox.Show("Bienvenido");

                        Principal go = new Principal();
                        go.User = false;
                        go.ActUser = ActUser;
                        go.manduser.Text = TxtUsuario.Text;
                        go.Show();
                        this.Hide();
                    }
                    conectar.Close();

                    Esperar.Hide();
                }
            }
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form formulario = new Registro();
            formulario.Show();
            this.Hide();
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNINVITADO_Click(object sender, EventArgs e)
        {
            WaitForm Wait = new WaitForm();
            Wait.Show();
            Thread.Sleep(3000);
            MessageBox.Show("¡Bienvenido!");
            MessageBox.Show("Entraras en modo invitado, no podras:" +Environment.NewLine+">Escribir historias" +
            Environment.NewLine + ">Comentar historias, descargarlas o seguirlas"+
            Environment.NewLine + ">Que te recomendemos peliculas","¡Atención!");
            Principal directo = new Principal();
            directo.User = true;
            directo.Show();
            this.Hide();
            Wait.Dispose();
        }
        bool Online ()
        {
            System.Uri Url = new System.Uri("https://www.google.com/");

            System.Net.WebRequest WebRequest;
            WebRequest = System.Net.WebRequest.Create(Url);
            System.Net.WebResponse objetoResp;

            try
            {
                objetoResp = WebRequest.GetResponse();
                return true;
                objetoResp.Close();
                WebRequest = null;
            }
            catch (Exception ex)
            {
                return false;
                WebRequest = null;
            }
            
        }
        private void Login_Load(object sender, EventArgs e)
        {
            if (!Online())
            {
                TxtPassword.Enabled = false;
                TxtUsuario.Enabled = false;
                //label3.Visible = false;
                //label5.Visible = false;
                //label6.Visible = false;
                BTNINVITADO.Visible = false;
                LinkLabel.Visible = false;
                BtnInicioSesion.Text = "LEER TUS HISTORIAS DESCARGADAS";
                Offline = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
