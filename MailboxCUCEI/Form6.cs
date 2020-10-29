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

        public void Cargar_data_grid()
        {
           
        }
        public void Administrador_Load(object sender, EventArgs e)
        {
            Cargar_data_grid();
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que deseas eliminar este usuario?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                MySqlConnection con = new MySqlConnection("server=127.0.0.1; database=mailbox; Uid=root; pdw=;");
                con.Open();
                string id = "";
                if (DataGridAdmin.SelectedCells.Count > 0)
                {
                    id = DataGridAdmin.SelectedCells[0].Value.ToString();
                }
                MySqlCommand borrar = new MySqlCommand("DELETE FROM usuario where usuario_id=(@usuario);", con);
                borrar.Parameters.AddWithValue("@usuario", id);
                borrar.ExecuteNonQuery();
                DataGridAdmin.DataSource = null;
                Cargar_data_grid();
                con.Close();
                MessageBox.Show("Se ha eliminado con exito");
            }
            else
            {
                MessageBox.Show("No se ha eliminado nada");
            }
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            Form mody = new FRMWrite();
            mody.Show();
        }

        private void DataGridAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTNRefrescar_Click(object sender, EventArgs e)
        {
            Cargar_data_grid();
        }

        private void BTNRespaldo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que deseas realizar una copia de seguridad?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string cnx = "server=127.0.0.1; database=mailbox; Uid=root; pdw=;";
                cnx += "charset=utf8;convertzerodatetime=true";
                string backup = "BackupMailboxCUCEI";
                using (MySqlConnection con = new MySqlConnection(cnx))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = con;
                            con.Open();
                            mb.ExportToFile(backup);
                            con.Close();
                        }
                    }
                }
                MessageBox.Show("Se realizo una copia de seguridad con exito \nSe encuentra en C:/Users/PC/Source/repos/MailboxCUCEI/MailboxCUCEI/bin/Debug ");
            }
            else
            {
                MessageBox.Show("No se ha realizado nada");
            }
        }
    }
}
