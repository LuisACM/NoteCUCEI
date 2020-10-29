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

namespace MailboxCUCEI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if(TxtUsuario.Text=="CODIGO")
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
                TxtUsuario.Text = "CODIGO";
                TxtUsuario.ForeColor = Color.Black;
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "CONTRASEÑA")
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
                TxtPassword.Text = "CONTRASEÑA";
                TxtPassword.ForeColor = Color.Black;
                TxtPassword.UseSystemPasswordChar = false;
            }
        }

        private void BTNCerrar_Click(object sender, EventArgs e)
        {
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
            MessageBox.Show(query);
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
        }
        private void BtnInicioSesion_Click(object sender, EventArgs e)
        {
            Esperar.Show();
            MySqlConnection conectar = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
            conectar.Open();
            MySqlCommand checkin = new MySqlCommand();
            MySqlConnection conectarya = new MySqlConnection();
            checkin.Connection = conectar;
            checkin.CommandText = ("SELECT *From Usuarios WHERE Codigo='"+TxtUsuario.Text+"'and Password ='"+TxtPassword.Text+"'");
            MySqlDataReader leer = checkin.ExecuteReader();
            if(leer.Read())
            {
                GenerateUser();
                conectar.Close();
                MessageBox.Show("Bienvenido");
                Principal go = new Principal();
                go.User = false;
                go.ActUser = ActUser;
                go.manduser.Text = TxtUsuario.Text;
                go.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Codigo o contraseña erroneos");
            }
            conectar.Close();
            Esperar.Hide();
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
            MessageBox.Show("Bienvenido");
            Principal directo = new Principal();
            directo.User = true;
            directo.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"\Image"))
            {

            }
            else
            {
                System.IO.Directory.CreateDirectory(@"\Image");
            }
            
        }
    }
}
