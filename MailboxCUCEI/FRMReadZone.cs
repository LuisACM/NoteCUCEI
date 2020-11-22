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
using Renci.SshNet.Common;

namespace MailboxCUCEI
{
    public partial class FRMReadZone : Form
    {
		public Usuario ActUser;
    	public Principal Ventana;
		public Historias MainStory;
		List<Capitulos> ListChapters = new List<Capitulos>();
		int ActualChapter;
		private WebClient Cliente = new WebClient();
		public bool Offline = false;
		public string ChaptersOffline;
		public string StoryName;
		public FRMReadZone()
        {
            InitializeComponent();
        }

		public int ID_Historia = 0;
        public void BTNSalir_Click(object sender, EventArgs e)
        {
			if (Offline)
            {
				FRMOffline Venta = new FRMOffline();
				Venta.Show();
				this.Dispose();
            }
			else
            {
				Principal go = new Principal();
				go.User = Ventana.User;
				go.ActUser = Ventana.ActUser;
				go.manduser.Text = Ventana.manduser.Text;
				go.Show();
				this.Dispose();
            }
			
        }
		void CreateChapterList ()
        {
			string query = "SELECT C.*, Base.`ID_Historia` FROM `Historias_Capitulos` AS Base INNER JOIN Capitulo AS C ON Base.ID_Capitulo = C.ID_Cap  WHERE ID_Historia =" + MainStory.GetID()+"";
			string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
			MySqlConnection connetionBD = new MySqlConnection(conexion);
			MySqlCommand comando = new MySqlCommand(query, connetionBD);
			MySqlDataReader lector;
			connetionBD.Open();
			lector = comando.ExecuteReader();
			while (lector.Read())
			{
				Capitulos temp = new Capitulos(lector.GetInt16(0),lector.GetString(1),lector.GetInt16(2),lector.GetString(3));
				ListChapters.Add(temp);
			}
			connetionBD.Close();
			ActualChapter = 0;
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
				  RTBWriteZone.Font = new Font(
			         currentFont.FontFamily, 
			         ActualLeght, currentFont.Style 
			      );
			RTBWriteZone.ForeColor = Color.DodgerBlue;
		}
		void BTNDecreaseLettersClick(object sender, EventArgs e)
		{
			System.Drawing.Font currentFont = RTBWriteZone.SelectionFont;
				  float ActualLeght = currentFont.Size;
				  ActualLeght = ActualLeght - 1;
				  RTBWriteZone.Font = new Font(
			         currentFont.FontFamily, 
			         ActualLeght,currentFont.Style 
			      );
			RTBWriteZone.ForeColor = Color.DodgerBlue;
		}
		void TxtCodigoModificarTextChanged(object sender, EventArgs e)
		{
	
		}
		string[] OfflineChaptersList;
        private void FRMWrite_Load(object sender, EventArgs e)
        {

            //luis'codigo
			if (Ventana.User == false)
            {
				string usuario = ActUser.GetID().ToString();
				string historia = MainStory.GetID().ToString();
				MySqlConnection conexion = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
				MySqlCommand comando = new MySqlCommand("SELECT * FROM Rating WHERE ID_Usuario = @ID AND ID_Historia = @IDHi", conexion);
				comando.Parameters.AddWithValue("@ID", usuario);
				comando.Parameters.AddWithValue("@IDHi",historia);
				conexion.Open();
				MySqlDataReader registro = comando.ExecuteReader();
				if (registro.Read())
				{
					flagLabel.Text = registro["Flag"].ToString();
				}
				conexion.Close();
				//MessageBox.Show(flagLabel.Text);

				if (flagLabel.Text == "1")
				{
					calificarbtn.Enabled = false;
				}
				else
				{

				}
            }
            
            //pepe's codigo
            if (Offline)
            {
				txtComment.Visible = false;
				panel1.Visible = false;
				BTNSendComment.Visible = false;
				lblCapitulo.Visible = false;
                CalificacionCB.Visible = false;
                calificarbtn.Visible = false;
                calificarlabel.Visible = false;
				lblStoryName.Text = StoryName;
				OfflineChaptersList = ChaptersOffline.Split('|');
				ActualChapter = 0;
				RTBWriteZone.LoadFile(OfflineChaptersList[ActualChapter]);
				if (!MoreChapterOff())
				{
					BTNNextChapter.Enabled = false;
				}
			}
			else
            {
				if (Ventana.User)
				{
					txtComment.Visible = false;
					BTNSendComment.Visible = false;
                    calificarbtn.Visible = false;
                    CalificacionCB.Visible = false;
                    calificarlabel.Visible = false;
				}
				LoadComments();
				CreateChapterList();
				Capitulos temp;
				temp = ListChapters[ActualChapter];
				lblCapitulo.Text = temp.GetName();
				lblStoryName.Text = MainStory.GetName();
				DownloadStory("https://notecucei.000webhostapp.com/", temp.GetFilename());
				RTBWriteZone.LoadFile(temp.GetFilename());
					if (!MoreChapter())
				{
					BTNNextChapter.Enabled = false;
				}
            }
			
		}
		
		void LoadComments()
        {
			string query = "SELECT  Usuarios.Nombre, Capitulo.Numero, Comentarios.Comentario FROM Comentarios INNER JOIN Usuarios ON Usuarios.Codigo = Comentarios.ID_Usuario INNER JOIN Capitulo ON Capitulo.ID_Cap = Comentarios.ID_Cap WHERE Comentarios.ID_Historia = "+MainStory.GetID();
			string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
			MySqlConnection connetionBD = new MySqlConnection(conexion);
			MySqlCommand comando = new MySqlCommand(query, connetionBD);
			MySqlDataReader lector;
			connetionBD.Open();
			lector = comando.ExecuteReader();
			if (!lector.Read())
            {
				txtcomments.Text = "No hay comentarios, ¡Se el primero en comentar la obra!";
				connetionBD.Close();
			}
			else
            {
				connetionBD.Close();
				connetionBD.Open();
				lector = comando.ExecuteReader();
				String aux="";
				while (lector.Read())
                {
					aux = aux+ lector.GetString(0)+"(Capitulo " + lector.GetString(1) + ")"+ Environment.NewLine + lector.GetString(2) + Environment.NewLine;

				}
				txtcomments.Text=aux;
				connetionBD.Close();
			}
			
		}
		
		bool MoreChapterOff()
		{
			if (ActualChapter + 1 < OfflineChaptersList.Length)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		bool MoreChapter()
		{
			if (ListChapters.Count() > ActualChapter + 1)
			{
				return true;
            }
			else
            {
				return false;
			}
        }
        private void BTNPublish_Click(object sender, EventArgs e)
        {
			BTNBack.Enabled = true;
			ActualChapter++;
			if (Offline)
            {
				RTBWriteZone.LoadFile(OfflineChaptersList[ActualChapter]);
				if (!MoreChapterOff())
				{
					BTNNextChapter.Enabled = false;
				}

			}
			else
            {
				Capitulos temp;
				temp = ListChapters[ActualChapter];
				lblCapitulo.Text = temp.GetName();
				lblStoryName.Text = MainStory.GetName();
				DownloadStory("https://notecucei.000webhostapp.com/", temp.GetFilename());
				RTBWriteZone.LoadFile(temp.GetFilename());
				if (!MoreChapter())
				{
					BTNNextChapter.Enabled = false;
				}
            }
			
		}
		void DownloadStory(string URL, String Name)
		{
			if (File.Exists(Name))
			{
				return;
			}
			else
			{
				Cliente.DownloadFile(new Uri(URL), Name);
			}
		}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtComment_Click(object sender, EventArgs e)
        {
			if (txtComment.Text== "¡Dejale un comentario al autor!")
            {
				txtComment.Text = "";
            }
        }

        private void BTNSendComment_Click(object sender, EventArgs e)
        {
			if (txtComment.Text=="")
            {
				MessageBox.Show("Ingresa un comentario primero");
            }
			else
            {
			string query = "INSERT INTO `Comentarios` (`ID_Comentario`, `ID_Cap`, `ID_Usuario`, `Comentario`, `ID_Historia`) VALUES(NULL, '"+ListChapters[ActualChapter].GetID().ToString()+"', '"+ActUser.GetID()+ "', '"+txtComment.Text+"', '"+MainStory.GetID().ToString() + "')";
			MySqlConnection conectar = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
			conectar.Open();
			MySqlCommand comando = new MySqlCommand(query);
			comando.Connection = conectar;
			comando.ExecuteNonQuery();
			conectar.Close();
			txtcomments.Text = "";
			LoadComments();
				txtComment.Text ="";
				MessageBox.Show("Mensaje enviado, gracias por aportar tu opinion");
            }
		}

        private void BTNBack_Click(object sender, EventArgs e)
        {
			ActualChapter--;
			if (Offline)
			{
				RTBWriteZone.LoadFile(OfflineChaptersList[ActualChapter]);
				BTNNextChapter.Enabled = true;
				if (ActualChapter == 0)
				{
					BTNBack.Enabled = false;
				}

			}
			else
			{
				Capitulos temp;
				BTNNextChapter.Enabled = true;
				temp = ListChapters[ActualChapter];
				lblCapitulo.Text = temp.GetName();
				lblStoryName.Text = MainStory.GetName();
				DownloadStory("https://notecucei.000webhostapp.com/", temp.GetFilename());
				RTBWriteZone.LoadFile(temp.GetFilename());
				if (ActualChapter == 0)
				{
					BTNBack.Enabled = false;
				}
			}
		}

        void ObtenerFlag()
        {
            string usuario = ActUser.GetID().ToString();
            MySqlConnection conexion = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
            MySqlCommand comando = new MySqlCommand("SELECT * FROM Rating WHERE ID_Usuario = @ID", conexion);
            comando.Parameters.AddWithValue("@ID", usuario);
            conexion.Open();
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                flagLabel.Text = registro["Flag"].ToString();
            }
            conexion.Close();
            MessageBox.Show(flagLabel.Text);
        }


        private void calificarbtn_Click(object sender, EventArgs e)
        {
            int control = 1;
            string usuario = ActUser.GetID().ToString();
            string historia = MainStory.GetID().ToString();


            if (CalificacionCB.Text == "0")
            {
                MessageBox.Show("Usted debe escojer un valor entre 1 y 5");
            }
            else
            {
                string query = "INSERT INTO Rating (ID_Usuario,ID_Historia,Rating,Flag) VALUES('" + usuario + "','" + historia + "','" + CalificacionCB.Text + "','" + control + "')";
                MySqlConnection conectar = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
                conectar.Open();
                MySqlCommand comando = new MySqlCommand(query);
                comando.Connection = conectar;
                comando.ExecuteNonQuery();
                conectar.Close();
                MessageBox.Show("Gracias por tu calificación!");
                calificarbtn.Enabled = false;
            }
            
        }
    }
}
