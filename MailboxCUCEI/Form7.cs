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

namespace MailboxCUCEI
{
    public partial class FRMWrite : Form
    {
		public Usuario ActUser;
    	public Principal Ventana;
    	const float TamañoEstandar = 12;
        public FRMWrite()
        {
            InitializeComponent();
        }

		public int ID_Historia = 0;
        public void BTNSalir_Click(object sender, EventArgs e)
        {
            Administrador refresh = new Administrador();
            refresh.Cargar_data_grid();
            this.Hide();

        }

        

        
		void Label5Click(object sender, EventArgs e)
		{
	
		}
		void BTNAlignLeftClick(object sender, EventArgs e)
		{
			RTBWriteZone.SelectionAlignment = HorizontalAlignment.Left;
		}
		void BTNAlignCenterClick(object sender, EventArgs e)
		{
			RTBWriteZone.SelectionAlignment = HorizontalAlignment.Center;
		}
		void BTNAlignRightClick(object sender, EventArgs e)
		{
			RTBWriteZone.SelectionAlignment = HorizontalAlignment.Right;
		}
		void BTNUnderlineClick(object sender, EventArgs e)
		{
			      System.Drawing.Font currentFont = RTBWriteZone.SelectionFont, newFontStyle;
			      if(RTBWriteZone.SelectionFont.Underline==true)
			      {
			      	newFontStyle=  new Font(currentFont, currentFont.Style | FontStyle.Regular); 
			      }
			      else
			      {
			      	newFontStyle=  new Font(currentFont, currentFont.Style | FontStyle.Underline); 
			      }
			      RTBWriteZone.SelectionFont = newFontStyle;
			      RTBWriteZone.Focus();
		}
		void BTNNegritasClick(object sender, EventArgs e)
		{
			System.Drawing.Font currentFont = RTBWriteZone.SelectionFont, newFontStyle;
			      if(RTBWriteZone.SelectionFont.Bold==true)
			      {
			      	newFontStyle =  new Font(currentFont, currentFont.Style | FontStyle.Regular); 
			      }
			      else
			      {
			      	newFontStyle =  new Font(currentFont, currentFont.Style | FontStyle.Bold); 
			      }
			      RTBWriteZone.SelectionFont = newFontStyle;
			         RTBWriteZone.Focus();
		}
		void BTNItalicClick(object sender, EventArgs e)
		{
				  System.Drawing.Font currentFont = RTBWriteZone.SelectionFont, newFontStyle;
			      if(RTBWriteZone.SelectionFont.Italic==true)
			      {
			      	newFontStyle =  new Font(currentFont, currentFont.Style | FontStyle.Regular); 
			      }
			      else
			      {
			      	newFontStyle =  new Font(currentFont, currentFont.Style | FontStyle.Italic); 
			      }
			      
			      RTBWriteZone.SelectionFont = newFontStyle;
			         RTBWriteZone.Focus();
		}
		void BTNIncreaseLettersClick(object sender, EventArgs e)
		{
				  System.Drawing.Font currentFont = RTBWriteZone.SelectionFont;
				  float ActualLeght = currentFont.Size;
				  ActualLeght = ActualLeght + 1;
				  RTBWriteZone.SelectionFont = new Font(
			         currentFont.FontFamily, 
			         ActualLeght, currentFont.Style 
			      );
				  
		}
		void BTNDecreaseLettersClick(object sender, EventArgs e)
		{
			System.Drawing.Font currentFont = RTBWriteZone.SelectionFont;
				  float ActualLeght = currentFont.Size;
				  ActualLeght = ActualLeght - 1;
				  RTBWriteZone.SelectionFont = new Font(
			         currentFont.FontFamily, 
			         ActualLeght,currentFont.Style 
			      );
		}
		void TxtCodigoModificarTextChanged(object sender, EventArgs e)
		{
	
		}
		int Capitulo = 1;
        private void FRMWrite_Load(object sender, EventArgs e)
        {
			string query = "SELECT * FROM `Capitulo` WHERE `ID_Historia` = " + ID_Historia + " ";
			string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
			MySqlConnection connetionBD = new MySqlConnection(conexion);
			MySqlCommand comando = new MySqlCommand(query, connetionBD);
			MySqlDataReader lector;
			connetionBD.Open();
			lector = comando.ExecuteReader();
			while (lector.Read())
			{
				Capitulo++;
			}
			connetionBD.Close();
			MessageBox.Show(Capitulo.ToString());
		}

        private void BTNPublish_Click(object sender, EventArgs e)
        {
			try
            {
				WaitForm Wait = new WaitForm();
				Wait.Show();
				RTBWriteZone.SaveFile(txtTitle.Text+ID_Historia+".rtf");
				string query = "INSERT INTO `Capitulo` (`ID_Cap`, `Nombre`, `Numero`, `ID_Historia`, `Ubicacion`) VALUES (NULL, '"+txtTitle.Text+"', '"+ Capitulo +"', '"+ID_Historia+"', '" + txtTitle.Text + ID_Historia + ".rtf" + "')";
				MySqlConnection conectar = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
				conectar.Open();
				MySqlCommand comando = new MySqlCommand(query);
				comando.Connection = conectar;
				comando.ExecuteNonQuery();
				UploadTEXT();
				conectar.Close();
				MessageBox.Show("Capitulo subido.");
				Wait.Dispose();
				Ventana.Show();
				this.Dispose();
            }
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}

		}
		void UploadTEXT()
		{
			try
			{
				WebClient client = new WebClient();
				client.Credentials = CredentialCache.DefaultCredentials;
				client.UploadFile(@"https://notecucei.000webhostapp.com/upload.php?namefile=" + txtTitle.Text + ID_Historia + ".rtf", "POST", txtTitle.Text + ID_Historia + ".rtf");
				client.Dispose();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
	}
}
