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

namespace MailboxCUCEI
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void Administrador_Load(object sender, EventArgs e)
        {
            //aqui se cargan los datos del usuario en su correspondiente textbox
            MySqlConnection conexion = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
            MySqlCommand comando = new MySqlCommand("SELECT * FROM Usuarios WHERE Codigo = @ID",conexion);
            comando.Parameters.AddWithValue("@ID", TxtCodigoPerfil.Text);
            conexion.Open();
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                TxtNombrePerfil.Text = registro["Nombre"].ToString();
                TxtCorreoPerfil.Text = registro["Correo"].ToString();
                TxtPassPerfil.Text = registro["Password"].ToString();
                FechaNac.Text = registro["F_Nacimiento"].ToString();
            }
            conexion.Close();
        }

        private void BTNEliminar_Click_1(object sender, EventArgs e)
        {
            //funcion de eliminar cuenta


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
                "'WHERE Codigo='"+TxtCodigoPerfil.Text+
                "';";

            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Datos guardados con éxito!");


        }

        private void BTNSalir_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BTNFotoPerfil_Click(object sender, EventArgs e)
        {
            OpenFileDialog GetImage = new OpenFileDialog();
            GetImage.InitialDirectory = "c:\\";
            GetImage.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png*)|*.png*";
            if (GetImage.ShowDialog() == DialogResult.OK)
            {
                FotoPerfil.ImageLocation = GetImage.FileName;
            }
            else
            {
                MessageBox.Show("No se selecciono imagen","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}
