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

			DialogResult result = MessageBox.Show("¿Seguro que quieres salir?", "Confirmation", MessageBoxButtons.YesNoCancel);
			if (result == DialogResult.Yes)
			{
				Principal go = new Principal();
				go.User = Ventana.User;
				go.ActUser = Ventana.ActUser;
				go.manduser.Text = Ventana.manduser.Text;
				go.Show();
				this.Dispose();
			}
			else if (result == DialogResult.No)
			{
				//... Do Nothing
			}
			
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
		int Capitulo;
		//
		// 
		private void FRMWrite_Load(object sender, EventArgs e)
        {
			LoadID();
			string query = "SELECT COUNT(*) FROM Historias_Capitulos WHERE ID_Historia = "+ID_Historia+" ";
			string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
			MySqlConnection connetionBD = new MySqlConnection(conexion);
			MySqlCommand comando = new MySqlCommand(query, connetionBD);
			MySqlDataReader lector;
			connetionBD.Open();
			lector = comando.ExecuteReader();
			if (lector.Read())
			{
				Capitulo = lector.GetInt32(0);
			}
			connetionBD.Close();
			if (Capitulo == 0)
            {
				Capitulo = 1;
            }
		}
		void LoadID ()
        {
			string query = "SELECT ID_Historia FROM `Historias` WHERE `Nom_Historia` = '" + lblStoryName.Text + "' ";
			string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
			MySqlConnection connetionBD = new MySqlConnection(conexion);
			MySqlCommand comando = new MySqlCommand(query, connetionBD);
			MySqlDataReader lector;
			connetionBD.Open();
			lector = comando.ExecuteReader();
			while (lector.Read())
			{
				ID_Historia = lector.GetInt32(0);
			}
			connetionBD.Close();
		}
		int LoadIDCap ()
        {
			int ID = 0;
			string query = "SELECT ID_Cap FROM `Capitulo` WHERE `Ubicacion` = '" + txtTitle.Text + ID_Historia.ToString() + ".rtf '";
			string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
			MySqlConnection connetionBD = new MySqlConnection(conexion);
			MySqlCommand comando = new MySqlCommand(query, connetionBD);
			MySqlDataReader lector;
			connetionBD.Open();
			lector = comando.ExecuteReader();
			while (lector.Read())
			{
				ID = lector.GetInt32(0);
			}
			connetionBD.Close();
			return ID;
        }
		void InsertRelation() //Insertando en la tabla Historias-Capitulos
        {
			
			string query = "INSERT INTO `Historias_Capitulos` (`ID_Historia`, `ID_Capitulo`) VALUES ("+ID_Historia+","+LoadIDCap()+");";
			
			MySqlConnection conectar = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
			conectar.Open();
			MySqlCommand comando = new MySqlCommand(query);
			comando.Connection = conectar;
			comando.ExecuteNonQuery();
			conectar.Close();
		}
        private void BTNPublish_Click(object sender, EventArgs e)
        {
			try
            {
				if (txtTitle.Text == "Título")
				{
					MessageBox.Show("Por favor, asigna un nombre a tu capitulo");
				}
				else
                {
					WaitForm Wait = new WaitForm();
					Wait.Show();
					RTBWriteZone.SaveFile(txtTitle.Text+ID_Historia.ToString()+".rtf");
					string query = "INSERT INTO `Capitulo` (`ID_Cap`, `Nombre`, `Numero`, `Ubicacion`) VALUES (NULL, '"+txtTitle.Text+"', '"+ Capitulo +"', '" + txtTitle.Text + ID_Historia.ToString() + ".rtf ')";
					MySqlConnection conectar = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
					conectar.Open();
					MySqlCommand comando = new MySqlCommand(query);
					comando.Connection = conectar;
					comando.ExecuteNonQuery();
					UploadTEXT();
					conectar.Close();
					MessageBox.Show("Capitulo subido.");
					InsertRelation();
					StarNotify();
					Wait.Dispose();
					Principal go = new Principal();
					go.User = Ventana.User;
					go.ActUser = Ventana.ActUser;
					go.manduser.Text = Ventana.manduser.Text;
					go.Show();
					this.Dispose();
				}
				
            }
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}

		}
		void SendNotify(List<int> ListUsers)
        {
			foreach (int temporal in ListUsers)
            {
				string queryNotify = "INSERT INTO `Notificaciones` (`ID_Usuario`, `Mensaje`, `Estatus`) VALUES ('"+temporal.ToString()+"', 'Se ha publicado un nuevo capitulo de la historia que sigues \""+lblStoryName.Text+"\".', '1');";
				MySqlConnection conectar = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
				conectar.Open();
				MySqlCommand comando = new MySqlCommand(queryNotify);
				comando.Connection = conectar;
				comando.ExecuteNonQuery();
				conectar.Close();
			}
        }
		void StarNotify ()
        {
			try
            {
				bool AntiBug = false;
				List<int> ListUsers = new List<int>();
				string query = "SELECT `ID_Usuario` FROM `Seguidores` WHERE `ID_Historia` = "+ID_Historia.ToString()+" UNION SELECT `ID_Usuario` FROM `Favoritos` WHERE `ID_Historia` = " + ID_Historia.ToString();
				string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
				MySqlConnection connetionBD = new MySqlConnection(conexion);
				MySqlCommand comando = new MySqlCommand(query, connetionBD);
				MySqlDataReader lector;
				connetionBD.Open();
				lector = comando.ExecuteReader();
				while (lector.Read())
				{
					AntiBug = true;
					ListUsers.Add(lector.GetInt32(0));
				}
				connetionBD.Close();
				if (AntiBug)
                {
					SendNotify(ListUsers);
                }
				
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

				client.UploadFile(@"https://notecucei.000webhostapp.com/upload.php?namefile=" + txtTitle.Text + ID_Historia.ToString() + ".rtf", "POST", txtTitle.Text + ID_Historia.ToString() + ".rtf");
				client.Dispose();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}

        private void RTBWriteZone_Click(object sender, EventArgs e)
        {
			if (RTBWriteZone.Text == "¡Escribe aquí!")
            {
				RTBWriteZone.Text = "";

			}
        }

        private void BTNLoadWord_Click(object sender, EventArgs e)
        {
			OpenFileDialog WindownForWord = new OpenFileDialog();
			WindownForWord.InitialDirectory = "c:\\";
			WindownForWord.Filter = "DOCX files (*.docx)|*.docx|DOC files (*.doc*)|*.doc*";
			WindownForWord.FilterIndex = 2;
			WindownForWord.RestoreDirectory = false;
			if (WindownForWord.ShowDialog() == DialogResult.OK)
			{
				object readOnly = false;
				object visible = true;
				object Filename = WindownForWord.FileName;
				object newTemplate = false;
				object docType = 0;
				object missing = Type.Missing;
				Microsoft.Office.Interop.Word._Document oDoc = null;
				Microsoft.Office.Interop.Word._Application oWord = new Microsoft.Office.Interop.Word.Application() { Visible = false };
				oDoc = oWord.Documents.Open(
						ref Filename, ref missing, ref readOnly, ref missing,
						ref missing, ref missing, ref missing, ref missing,
						ref missing, ref missing, ref missing, ref visible,
						ref missing, ref missing, ref missing, ref missing);
				oDoc.ActiveWindow.Selection.WholeStory();
				oDoc.ActiveWindow.Selection.Copy();
				IDataObject data = Clipboard.GetDataObject();
				RTBWriteZone.Rtf = data.GetData(DataFormats.Rtf).ToString();
				oWord.Quit(ref missing, ref missing, ref missing);
				RTBWriteZone.SelectAll();
				RTBWriteZone.ForeColor = Color.DodgerBlue;
				RTBWriteZone.SelectionColor = Color.DodgerBlue;
				RTBWriteZone.DeselectAll();
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
			RTBWriteZone.SelectionColor = Color.DodgerBlue;
			RTBWriteZone.ForeColor = Color.DodgerBlue;
		}

        private void txtTitle_Click(object sender, EventArgs e)
        {
			 if (txtTitle.Text == "Título")
            {
				txtTitle.Text = "";
            }
        }
    }
}
