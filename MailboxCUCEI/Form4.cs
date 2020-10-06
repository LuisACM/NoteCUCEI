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

namespace MailboxCUCEI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
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
