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
            if(TxtNombre.Text=="NOMBRE")
            {
                TxtNombre.Text = "";
                TxtNombre.ForeColor = Color.Black;
            }

        }

        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            if(TxtNombre.Text=="")
            {
                TxtNombre.Text = "NOMBRE";
                TxtNombre.ForeColor = Color.Black;
            }
        }

        private void TxtPasswordRegistro_Enter(object sender, EventArgs e)
        {
            if (TxtPasswordRegistro.Text == "CONTRASEÑA")
            {
                TxtPasswordRegistro.Text = "";
                TxtPasswordRegistro.ForeColor = Color.Black;
                TxtPasswordRegistro.UseSystemPasswordChar = true;
            }
        }

        private void TxtPasswordRegistro_Leave(object sender, EventArgs e)
        {
            if (TxtPasswordRegistro.Text == "")
            {
                TxtPasswordRegistro.Text = "CONTRASEÑA";
                TxtPasswordRegistro.ForeColor = Color.Black;
                TxtPasswordRegistro.UseSystemPasswordChar = false;
            }
        }

        private void TxtCodigoRegistro_Enter(object sender, EventArgs e)
        {
            if (TxtCodigoRegistro.Text == "CODIGO")
            {
                TxtCodigoRegistro.Text = "";
                TxtCodigoRegistro.ForeColor = Color.Black;
            }
        }

        private void TxtCodigoRegistro_Leave(object sender, EventArgs e)
        {
            if (TxtCodigoRegistro.Text == "")
            {
                TxtCodigoRegistro.Text = "CODIGO";
                TxtCodigoRegistro.ForeColor = Color.Black;
            }
        }

        private void TxtCorreo_Enter(object sender, EventArgs e)
        {
            if (TxtCorreo.Text == "CORREO")
            {
                TxtCorreo.Text = "";
                TxtCorreo.ForeColor = Color.Black;
            }
        }

        private void TxtCorreo_Leave(object sender, EventArgs e)
        {
            if (TxtCorreo.Text == "")
            {
                TxtCorreo.Text = "CORREO";
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
            if(TxtNombre.Text=="NOMBRE" || TxtNombre.Text=="")
            {
                MessageBox.Show("Porfavor introduzca su nombre");
            }
            else if (TxtPasswordRegistro.Text == "CONTRASEÑA" || TxtPasswordRegistro.Text=="")
            {
                MessageBox.Show("Porfavor introduzca su contraseña");
            }
            else if (TxtCodigoRegistro.Text == "CODIGO" || TxtCodigoRegistro.Text=="")
            {
                MessageBox.Show("Porfavor introduzca su codigo");
            }
            else if (TxtCorreo.Text == "CORREO" || TxtCorreo.Text=="")
            {
                MessageBox.Show("Porfavor introduzca su correo");
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
                TxtNombre.Text = "NOMBRE";
                TxtPasswordRegistro.Text = "CONTRASEÑA";
                TxtPasswordRegistro.UseSystemPasswordChar = false;
                TxtCodigoRegistro.Text = "CODIGO";
                TxtCorreo.Text = "CORREO";
            }
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
    }
}