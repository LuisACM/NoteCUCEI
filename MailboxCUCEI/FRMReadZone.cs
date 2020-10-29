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
		public FRMReadZone()
        {
            InitializeComponent();
        }

		public int ID_Historia = 0;
        public void BTNSalir_Click(object sender, EventArgs e)
        {
			Ventana.Show();
			this.Dispose();
        }
		void CreateChapterList ()
        {
			string query = "SELECT * FROM `Capitulo` WHERE `ID_Historia` ="+MainStory.GetID()+"";
			string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
			MySqlConnection connetionBD = new MySqlConnection(conexion);
			MySqlCommand comando = new MySqlCommand(query, connetionBD);
			MySqlDataReader lector;
			connetionBD.Open();
			lector = comando.ExecuteReader();
			while (lector.Read())
			{
				Capitulos temp = new Capitulos(lector.GetInt16(0),lector.GetString(1),lector.GetInt16(3),lector.GetString(4));
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
			MessageBox.Show("I can´t :c");
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
		private void FRMWrite_Load(object sender, EventArgs e)
		{
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
		void LoadComments()
        {
			string query = "SELECT * FROM `Comentarios` WHERE `ID_Historia` =" + MainStory.GetID() + "";
			string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
			MySqlConnection connetionBD = new MySqlConnection(conexion);
			MySqlCommand comando = new MySqlCommand(query, connetionBD);
			MySqlDataReader lector;
			connetionBD.Open();
			lector = comando.ExecuteReader();
			if (!lector.Read())
            {
				Label lblPlateNOBAR = new Label();
				lblPlateNOBAR.Text = "No hay comentarios. ¡Se el primero en dejar un comentario!";
				lblPlateNOBAR.FlatStyle = FlatStyle.Flat;
				lblPlateNOBAR.Font = new Font("Arial Narrow", 12);
				lblPlateNOBAR.Size = new Size(194, 30);
				lblPlateNOBAR.AutoSize = true;
				lblPlateNOBAR.MaximumSize = new Size(250, 0);
				lblPlateNOBAR.ForeColor = Color.DodgerBlue;
				lblPlateNOBAR.Location = new Point(6, 254);
				panel1.Controls.Add(lblPlateNOBAR);
			}
			else
            {
				connetionBD.Close();
				connetionBD.Open();
				lector = comando.ExecuteReader();
				while (lector.Read())
                {
					Label lblPlateNOBAR = new Label();
					lblPlateNOBAR.Text = "No hay comentarios. ¡Se el primero en dejar un comentario!";
					lblPlateNOBAR.FlatStyle = FlatStyle.Flat;
					lblPlateNOBAR.Font = new Font("Arial Narrow", 12);
					lblPlateNOBAR.Size = new Size(194, 30);
					lblPlateNOBAR.AutoSize = true;
					lblPlateNOBAR.MaximumSize = new Size(250, 0);
					lblPlateNOBAR.ForeColor = Color.DodgerBlue;
					lblPlateNOBAR.Location = new Point(6, 254);
					panel1.Controls.Add(lblPlateNOBAR);
				}
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
			ActualChapter++;
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
    }
}
