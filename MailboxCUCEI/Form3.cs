using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.IO;
using System.Threading;

namespace MailboxCUCEI
{
	public partial class FRMCreateStory : Form
	{
		public FRMCreateStory()
		{
			InitializeComponent();
		}
		public Principal Base;
		WaitForm Esperar = new WaitForm();
		public Usuario ActUser;
		
		void InicioAdminLoad(object sender, EventArgs e)
		{
			Esperar.Show();
			this.toolTip1.SetToolTip(this.CBRaiting, "K: Apto para todo publico" + Environment.NewLine + "K+: Apto para mayores de 8 años" + Environment.NewLine + "T: Apto para adolecentes" + Environment.NewLine + "M: Apto para mayores de 18 años");
			this.toolTip2.SetToolTip(this.CBEstatus, "Completo si vas a publicar una historias de un solo capitulo y ya no tendra más"+Environment.NewLine +"Incompleto si vas a publicar más capitulos");
			string query = "SELECT * FROM Generos";
			string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
			MySqlConnection connetionBD = new MySqlConnection(conexion);
			MySqlCommand comando = new MySqlCommand(query, connetionBD);
			MySqlDataReader lector;
			connetionBD.Open();
			lector = comando.ExecuteReader();
			while (lector.Read())
			{
				CBGender1.Items.Add(lector.GetString(1));
				CBGender2.Items.Add(lector.GetString(1));
			}
			Esperar.Hide();
			connetionBD.Close();
		}
		void TxtnombreTextChanged(object sender, EventArgs e)
		{
				
			if (txtnombre.Text=="Nombre")
			{
				txtnombre.Text="";
				txtnombre.ForeColor=Color.LightGray;
			}
		}
		void TXTSummaryTextChanged(object sender, EventArgs e)
		{
			if (TXTSummary.Text == "Escribe aqui una pequeña descripción de tu obra.")
			{
				TXTSummary.Text="";
				TXTSummary.ForeColor = Color.LightGray;
			}
		}
		string InPathImage, namefile;
		void UploadImage ()
        {
			try
			{
				WebClient client = new WebClient();
				client.Credentials = CredentialCache.DefaultCredentials;
				client.UploadFile(@"https://notecucei.000webhostapp.com/upload.php?namefile=" + namefile, "POST", InPathImage);
				client.Dispose();
				MessageBox.Show("Imagen Subida con Exito");
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
		string GenderCode="";
		void GenerateGenderCode ()
        {
				bool CtrlCB2 = true;
						if (CBGender1.Text == CBGender2.Text)
						{
							CtrlCB2 = false;
						}
			if (CBGender2.Text=="")
			{
				CtrlCB2 = false;
			}

			string query = "SELECT * FROM `Generos` WHERE `Nombre` = '" + CBGender1.Text + "' ";
			string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
			MySqlConnection connetionBD = new MySqlConnection(conexion);
			MySqlCommand comando = new MySqlCommand(query, connetionBD);
			MySqlDataReader lector;
			connetionBD.Open();
			lector = comando.ExecuteReader();
			if (lector.Read())
						{
							GenderCode = lector.GetString(0);
						}
						if (CtrlCB2)
						{
							GenderCode = GenderCode +"|"+ SecondGender();
						}
			
						else { GenderCode = GenderCode + "|NONE"; }
						connetionBD.Close();
		}
        private void BTNSend_Click(object sender, EventArgs e)
        {
			Esperar.Show();
			try
			{
				GenerateGenderCode();
				string query = "INSERT INTO `Historias` (`Nom_Historia`, `ID_Historia`, `Resumen`, `ID_Genero`, `Fo_Portada`, `Raiting`, `Estatus`, `Seguidores`, `Favoritos`, `Vistas`) VALUES ('"+txtnombre.Text+"', NULL, '"+TXTSummary.Text+"', '"+GenderCode+"', '"+namefile+"', '"+CBRaiting.Text+"', '"+CBEstatus.Text+"', '0', '0', '0')";
				MySqlConnection conectar = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
				conectar.Open();
				MySqlCommand comando = new MySqlCommand(query);
				comando.Connection = conectar;
				comando.ExecuteNonQuery();
				UploadImage();
				conectar.Close();
				Thread.Sleep(3000);
				MessageBox.Show("Historia subida con exito, ahora pasaras al area de escritura");
				InsertRelation();
				FRMWrite NewWindows = new FRMWrite();
				
				NewWindows.Ventana = Base;
				NewWindows.ActUser = ActUser;
				NewWindows.lblraiting.Text = CBRaiting.Text;
				NewWindows.LBLGenero.Text = CBGender1.Text + " " + CBGender2.Text;
				NewWindows.lblstatus.Text = CBEstatus.Text;
				NewWindows.ID_Historia = CreateStory();
				NewWindows.Show();
				NewWindows.lblStoryName.Text = txtnombre.Text;
				this.Dispose();
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message);
			}
			Esperar.Hide();
			
		}
		Historias ActualStory;
		 int CreateStory ()
        {
			int ID = 0;
			string query = "SELECT ID_Historia FROM `Historias` WHERE `Nom_Historia` = '"+txtnombre.Text+"' AND Resumen = '"+TXTSummary.Text+"' ";
			string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
			MySqlConnection connetionBD = new MySqlConnection(conexion);
			MySqlCommand comando = new MySqlCommand(query, connetionBD);
			MySqlDataReader lector;
			connetionBD.Open();
			lector = comando.ExecuteReader();
			if (lector.Read())
			{
				ID = lector.GetInt32(0);
			}
			connetionBD.Close();
			return ID;
		}
		string SecondGender ()
        {
			string gender="";
			string query = "SELECT * FROM `Generos` WHERE `Nombre` = '" + CBGender2.Text + "' ";
			string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
			MySqlConnection connetionBD = new MySqlConnection(conexion);
			MySqlCommand comando = new MySqlCommand(query, connetionBD);
			MySqlDataReader lector;
			connetionBD.Open();
			lector = comando.ExecuteReader();
			if (lector.Read())
			{
				gender = lector.GetString(0);
			}
			connetionBD.Close();
			return gender;
        }

		void InsertRelation() //Inserta la relación Historia-Usuario
        {
			string query = "INSERT INTO `Usuarios_Historias` (`ID_Usuario`, `ID_Historia`) VALUES ('"+ActUser.GetID()+"', '"+ LoadID().ToString()+"');";
			MySqlConnection conectar = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
			conectar.Open();
			MySqlCommand comando = new MySqlCommand(query);
			comando.Connection = conectar;
			comando.ExecuteNonQuery();
			conectar.Close();
        }
        private void CBGender1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
		int LoadID()  //Función para conseguir el ID de la historia.
		{
			int ID_Historia = 0;
			string query = "SELECT ID_Historia FROM `Historias` WHERE `Nom_Historia` = '" + txtnombre.Text + "' ";
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
			return ID_Historia;
		}

        private void BTNSalir_Click(object sender, EventArgs e)
        {
			Base.Show();
			this.Dispose();
        }

        void BtnImageClick(object sender, EventArgs e)
		{
			
			OpenFileDialog WindownForCover = new OpenFileDialog();
			WindownForCover.InitialDirectory = "c:\\";
		    WindownForCover.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png*)|*.png*";
		    WindownForCover.FilterIndex = 2;
		    WindownForCover.RestoreDirectory = true;
			if (WindownForCover.ShowDialog() == DialogResult.OK)
			   {
			     InPathImage = WindownForCover.FileName;
			     PBCover.Image = Image.FromFile(InPathImage);
			     namefile=WindownForCover.SafeFileName;
			   }
			
		}

    }
}
