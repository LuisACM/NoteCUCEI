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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void TxtNombre_Enter(object sender, EventArgs e)
        {
            if(TxtNombre.Text=="Nombre")
            {
                TxtNombre.Text = "";
                TxtNombre.ForeColor = Color.Black;
            }

        }

        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            if(TxtNombre.Text=="")
            {
                TxtNombre.Text = "Nombre";
                TxtNombre.ForeColor = Color.Black;
            }
        }

        private void TxtPasswordRegistro_Enter(object sender, EventArgs e)
        {
            if (TxtPasswordRegistro.Text == "Contraseña")
            {
                TxtPasswordRegistro.Text = "";
                TxtPasswordRegistro.ForeColor = Color.Black;
                TxtPasswordRegistro.PasswordChar = '*';
            }
        }

        private void TxtPasswordRegistro_Leave(object sender, EventArgs e)
        {
            if (TxtPasswordRegistro.Text == "")
            {
                TxtPasswordRegistro.Text = "Contraseña";
                TxtPasswordRegistro.ForeColor = Color.Black;
                TxtPasswordRegistro.PasswordChar = '*';
            }
        }

        private void TxtCodigoRegistro_Enter(object sender, EventArgs e)
        {
            if (TxtCodigoRegistro.Text == "Código")
            {
                TxtCodigoRegistro.Text = "";
                TxtCodigoRegistro.ForeColor = Color.Black;
            }
        }

        private void TxtCodigoRegistro_Leave(object sender, EventArgs e)
        {
            if (TxtCodigoRegistro.Text == "")
            {
                TxtCodigoRegistro.Text = "Código";
                TxtCodigoRegistro.ForeColor = Color.Black;
            }
        }

        private void TxtCorreo_Enter(object sender, EventArgs e)
        {
            if (TxtCorreo.Text == "Correo")
            {
                TxtCorreo.Text = "";
                TxtCorreo.ForeColor = Color.Black;
            }
        }

        private void TxtCorreo_Leave(object sender, EventArgs e)
        {
            if (TxtCorreo.Text == "")
            {
                TxtCorreo.Text = "Correo";
                TxtCorreo.ForeColor = Color.Black;
            }
        }

        private void BTNRegresar_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Login();
            formulario1.Show();
            this.Dispose();
        }

        private void BTNRegistro_Click(object sender, EventArgs e)
        {
            if(TxtNombre.Text=="Nombre" || TxtNombre.Text=="")
            {
                MessageBox.Show("Porfavor introduzca su nombre");
            }
            else if (TxtPasswordRegistro.Text == "Contraseña" || TxtPasswordRegistro.Text=="")
            {
                MessageBox.Show("Porfavor introduzca su contraseña");
            }
            else if (TxtCodigoRegistro.Text == "Código" || TxtCodigoRegistro.Text=="")
            {
                MessageBox.Show("Porfavor introduzca su codigo");
            }
            else if (TxtCorreo.Text == "Correo" || TxtCorreo.Text=="")
            {
                MessageBox.Show("Porfavor introduzca su correo");
            }
            else
            {
                if (AlreadyExist("Codigo",TxtCodigoRegistro.Text))
                {
                    MessageBox.Show("El codigo que escribiste ya existe");
                }
                else if (AlreadyExist("Correo",TxtCodigoRegistro.Text))
                {
                    MessageBox.Show("El correo que escribiste ya existe");
                }
                else
                {
                    MySqlConnection conectar = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
                    conectar.Open();
                    MySqlCommand comando = new MySqlCommand("INSERT INTO Usuarios (Codigo,Nombre,Password,Correo,F_Nacimiento) VALUES ('" + TxtCodigoRegistro.Text + "', '" + TxtNombre.Text + "','" + TxtPasswordRegistro.Text + "','" + TxtCorreo.Text + "','"+txtFecha.Text+"');");
                    comando.Connection = conectar;
                    comando.ExecuteNonQuery();
                    conectar.Close();
                    MessageBox.Show("Usuario creado con exito");
                    TxtNombre.Text = "Nombre";
                    TxtPasswordRegistro.Text = "Contraseña";
                    TxtPasswordRegistro.UseSystemPasswordChar = false;
                    TxtCodigoRegistro.Text = "Código";
                    TxtCorreo.Text = "Correo";
                    MessageBox.Show("Te has registrado exitosamente");
                    FRMChoose vent = new FRMChoose();
                    vent.Show();
                    vent.code = TxtCodigoRegistro.Text;
                    this.Hide();
                }
               
            }
        }
        bool AlreadyExist (string campo, string valor)
        {
            string query = "SELECT * FROM `Usuarios` WHERE `"+campo+"` = '" + valor + "' ";
            string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
            MySqlConnection connetionBD = new MySqlConnection(conexion);
            MySqlCommand comando = new MySqlCommand(query, connetionBD);
            MySqlDataReader lector;
            connetionBD.Open();
            lector = comando.ExecuteReader();
            if (lector.Read())
            {
                return true;
            }
            connetionBD.Close();
            return false;
        }
        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void passCB_CheckedChanged(object sender, EventArgs e)
        {
            if(passCB.Checked==true)
            {
                if (TxtPasswordRegistro.PasswordChar=='*')
                {
                    TxtPasswordRegistro.PasswordChar = '\0';
                }
            }
            else
            {
                TxtPasswordRegistro.PasswordChar = '*';
            }
        }

        private void btnOwo_Click(object sender, EventArgs e)
        {
            FRMChoose vent = new FRMChoose();
            vent.Show();
            vent.code = TxtCodigoRegistro.Text;
            this.Hide();
        }
    }
}
