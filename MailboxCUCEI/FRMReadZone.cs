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
using Microsoft.ML;
using Microsoft.ML.Trainers;
using System.Threading;

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
		void CreateChapterList()
		{
			string query = "SELECT C.*, Base.`ID_Historia` FROM `Historias_Capitulos` AS Base INNER JOIN Capitulo AS C ON Base.ID_Capitulo = C.ID_Cap  WHERE ID_Historia =" + MainStory.GetID() + "";
			string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
			MySqlConnection connetionBD = new MySqlConnection(conexion);
			MySqlCommand comando = new MySqlCommand(query, connetionBD);
			MySqlDataReader lector;
			connetionBD.Open();
			lector = comando.ExecuteReader();
			while (lector.Read())
			{
				Capitulos temp = new Capitulos(lector.GetInt16(0), lector.GetString(1), lector.GetInt16(2), lector.GetString(3));
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
			if (RTBWriteZone.SelectionFont.Underline == true)
			{
				newFontStyle = new Font(currentFont, currentFont.Style | FontStyle.Regular);
			}
			else
			{
				newFontStyle = new Font(currentFont, currentFont.Style | FontStyle.Underline);
			}
			RTBWriteZone.SelectionFont = newFontStyle;
			RTBWriteZone.Focus();
		}
		void BTNNegritasClick(object sender, EventArgs e)
		{
			System.Drawing.Font currentFont = RTBWriteZone.SelectionFont, newFontStyle;
			if (RTBWriteZone.SelectionFont.Bold == true)
			{
				newFontStyle = new Font(currentFont, currentFont.Style | FontStyle.Regular);
			}
			else
			{
				newFontStyle = new Font(currentFont, currentFont.Style | FontStyle.Bold);
			}
			RTBWriteZone.SelectionFont = newFontStyle;
			RTBWriteZone.Focus();
		}
		void BTNItalicClick(object sender, EventArgs e)
		{
			System.Drawing.Font currentFont = RTBWriteZone.SelectionFont, newFontStyle;
			if (RTBWriteZone.SelectionFont.Italic == true)
			{
				newFontStyle = new Font(currentFont, currentFont.Style | FontStyle.Regular);
			}
			else
			{
				newFontStyle = new Font(currentFont, currentFont.Style | FontStyle.Italic);
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
			RTBWriteZone.ForeColor = Color.Black;
		}
		void BTNDecreaseLettersClick(object sender, EventArgs e)
		{
			System.Drawing.Font currentFont = RTBWriteZone.SelectionFont;
			float ActualLeght = currentFont.Size;
			ActualLeght = ActualLeght - 1;
			RTBWriteZone.Font = new Font(
			   currentFont.FontFamily,
			   ActualLeght, currentFont.Style
			);
			RTBWriteZone.ForeColor = Color.Black;
		}
		void TxtCodigoModificarTextChanged(object sender, EventArgs e)
		{

		}
		string[] OfflineChaptersList;
		private void FRMWrite_Load(object sender, EventArgs e)
		{
			WaitForm Wait = new WaitForm();
			Wait.Show();
			//luis'codigo
			if (Ventana.User == false)
			{
				string usuario = ActUser.GetID().ToString();
				string historia = MainStory.GetID().ToString();
				MySqlConnection conexion = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
				MySqlCommand comando = new MySqlCommand("SELECT * FROM Rating WHERE ID_Usuario = @ID AND ID_Historia = @IDHi", conexion);
				comando.Parameters.AddWithValue("@ID", usuario);
				comando.Parameters.AddWithValue("@IDHi", historia);
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
				string nameWithoutSpaces = temp.GetFilename();
				DownloadStory("https://notecucei.000webhostapp.com/" + nameWithoutSpaces, temp.GetFilename());
				RTBWriteZone.LoadFile(temp.GetFilename());
				//Volver oscuro
				RTBWriteZone.SelectAll();
				RTBWriteZone.SelectionColor = Color.Black;
				RTBWriteZone.ForeColor = Color.Black;
				RTBWriteZone.DeselectAll();
				if (!MoreChapter())
				{
					BTNNextChapter.Enabled = false;
				}
			}

			if (Ventana.User == false )
            {
				if (!Offline)
                {
					MLContext mlContext = new MLContext();
					(IDataView trainingDataView, IDataView testDataView) = LoadData(mlContext);
					ITransformer model = BuildAndTrainModel(mlContext, trainingDataView);
					EvaluateModel(mlContext, testDataView, model);

					//Sacar lista de ID
					string query = "SELECT DISTINCT ID_Historia From Rating";
					string conexionAlt = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
					MySqlConnection connetionBD = new MySqlConnection(conexionAlt);
					MySqlCommand comandoAlt = new MySqlCommand(query, connetionBD);
					MySqlDataReader lector;
					connetionBD.Open();
					lector = comandoAlt.ExecuteReader();
					while (lector.Read())
					{
						if (UseModelForSinglePrediction(mlContext, model, ActUser.GetID(), lector.GetInt32(0)))
						{
							if (lector.GetInt32(0) != MainStory.GetID())
							{
								CreateObjectStory(lector.GetInt32(0));
							}
						}
					}
					connetionBD.Close();
					CreateObjects();
				}
            }
			Thread.Sleep(3000);
			Wait.Dispose();
		}

		void LoadComments()
		{
			string query = "SELECT  Usuarios.Nombre, Capitulo.Numero, Comentarios.Comentario FROM Comentarios INNER JOIN Usuarios ON Usuarios.Codigo = Comentarios.ID_Usuario INNER JOIN Capitulo ON Capitulo.ID_Cap = Comentarios.ID_Cap WHERE Comentarios.ID_Historia = " + MainStory.GetID();
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
				String aux = "";
				while (lector.Read())
				{
					aux = aux + lector.GetString(0) + "(Capitulo " + lector.GetString(1) + ")" + Environment.NewLine + lector.GetString(2) + Environment.NewLine;

				}
				txtcomments.Text = aux;
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
			if (txtComment.Text == "¡Dejale un comentario al autor!")
			{
				txtComment.Text = "";
			}
		}
		private void BTNSendComment_Click(object sender, EventArgs e)
		{
			if (txtComment.Text == "")
			{
				MessageBox.Show("Ingresa un comentario primero");
			}
			else
			{
				string query = "INSERT INTO `Comentarios` (`ID_Comentario`, `ID_Cap`, `ID_Usuario`, `Comentario`, `ID_Historia`) VALUES(NULL, '" + ListChapters[ActualChapter].GetID().ToString() + "', '" + ActUser.GetID() + "', '" + txtComment.Text + "', '" + MainStory.GetID().ToString() + "')";
				MySqlConnection conectar = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
				conectar.Open();
				MySqlCommand comando = new MySqlCommand(query);
				comando.Connection = conectar;
				comando.ExecuteNonQuery();
				conectar.Close();
				txtcomments.Text = "";
				LoadComments();
				txtComment.Text = "";
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

				//Actualizar csv
				string  raiting = CalificacionCB.Text;
				var trainingDataPath = Path.Combine(Environment.CurrentDirectory, "Datos", "Rating.csv");
				string separador = ",";
				StringBuilder salida = new StringBuilder();
				string cadena = ActUser.GetID().ToString() + "," + MainStory.GetID().ToString() + "," + raiting.ToString() + ",1";
				salida.AppendLine(string.Join(separador, cadena));
				File.AppendAllText(trainingDataPath, salida.ToString());
			}

		}
		public static (IDataView training, IDataView test) LoadData(MLContext mlContext)
		{
			var trainingDataPath = Path.Combine(Environment.CurrentDirectory, "Datos", "Rating.csv");
			var testDataPath = Path.Combine(Environment.CurrentDirectory, "Datos", "Rating-Test.csv");

			IDataView trainingDataView = mlContext.Data.LoadFromTextFile<StoryRating>(trainingDataPath, hasHeader: true, separatorChar: ',');
			IDataView testDataView = mlContext.Data.LoadFromTextFile<StoryRating>(testDataPath, hasHeader: true, separatorChar: ',');

			return (trainingDataView, testDataView);
		}
		public static ITransformer BuildAndTrainModel(MLContext mlContext, IDataView trainingDataView)
		{
			IEstimator<ITransformer> estimator = mlContext.Transforms.Conversion.MapValueToKey(outputColumnName: "userIdEncoded", inputColumnName: "userId")
				.Append(mlContext.Transforms.Conversion.MapValueToKey(outputColumnName: "storyIdEncoded", inputColumnName: "storyId"));
			var options = new MatrixFactorizationTrainer.Options
			{
				MatrixColumnIndexColumnName = "userIdEncoded",
				MatrixRowIndexColumnName = "storyIdEncoded",
				LabelColumnName = "Label",
				NumberOfIterations = 20,
				ApproximationRank = 100
			};

			var trainerEstimator = estimator.Append(mlContext.Recommendation().Trainers.MatrixFactorization(options));
			ITransformer model = trainerEstimator.Fit(trainingDataView);

			return model;
		}
		public static void EvaluateModel(MLContext mlContext, IDataView testDataView, ITransformer model)
		{
			var prediction = model.Transform(testDataView);
			var metrics = mlContext.Regression.Evaluate(prediction, labelColumnName: "Label", scoreColumnName: "Score");
			//MessageBox.Show("Root Mean Squared Error : " + metrics.RootMeanSquaredError.ToString());
			//MessageBox.Show("RSquared: " + metrics.RSquared.ToString());
		}
		public static bool UseModelForSinglePrediction(MLContext mlContext, ITransformer model, int ID, int StoryID)
		{
			
			var predictionEngine = mlContext.Model.CreatePredictionEngine<StoryRating, StoryRatingPrediction>(model);
			var testInput = new StoryRating { userId = ID, storyId = StoryID };

			var storyRatingPrediction = predictionEngine.Predict(testInput);
			if (Math.Round(storyRatingPrediction.Score, 1) > 3.8)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		List<Historias> ListStories = new List<Historias>();
		void CreateObjects ()
        {
			
			int LocalX = 0;
			foreach (Historias elements in ListStories)
			{

				Historias tempelement = ListStories[0];
				PictureBox pbox = new PictureBox();
				pbox.Size = new Size(194, 138);
				pbox.SizeMode = PictureBoxSizeMode.StretchImage;
				pbox.Location = new Point(LocalX, 0);
				pbox.Image = Image.FromFile(elements.GetCover());
				//Crear Boton
				Button lblPlateNOBAR = new Button();
				lblPlateNOBAR.Text = elements.GetName();
				lblPlateNOBAR.FlatStyle = FlatStyle.Flat;
				lblPlateNOBAR.BackColor = Color.DimGray;
				lblPlateNOBAR.Font = new Font("Consola", 9, FontStyle.Bold);
				lblPlateNOBAR.Size = new Size(194, 30);
				lblPlateNOBAR.ForeColor = Color.Black;
				lblPlateNOBAR.Location = new Point(LocalX, 140);
				lblPlateNOBAR.Click += new EventHandler(handlerComun_Click);
				PNRecommends.Controls.Add(pbox);
				PNRecommends.Controls.Add(lblPlateNOBAR);
				LocalX = LocalX + 209;
			}
		}
		void GenerateView(Historias temp)
		{
			temp.IncreaseID();
			string query = "INSERT INTO `Vistas` (`ID_Vista`, `ID_Historia`, `ID_Usuario`) VALUES (NULL, '" + temp.GetID() + "', '" + ActUser.GetID() + "');";
			MySqlConnection conectar = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
			conectar.Open();
			MySqlCommand comando = new MySqlCommand(query);
			comando.Connection = conectar;
			comando.ExecuteNonQuery();
			conectar.Close();
		}
		private void handlerComun_Click(object sender, EventArgs e)
		{
			foreach (Historias temp in ListStories)
			{

				if (((Button)sender).Text == temp.GetName())
				{
					FRMPreview Prev = new FRMPreview();
					
						GenerateView(temp);
						string query = "UPDATE `Historias` SET `Vistas` = '" + temp.GetViews() + "' WHERE `Historias`.`ID_Historia` = " + temp.GetID() + "";
						MySqlConnection conectar = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
						conectar.Open();
						MySqlCommand comando = new MySqlCommand(query);
						comando.Connection = conectar;
						comando.ExecuteNonQuery();
						conectar.Close();
					
					Prev.ActUser = ActUser;
					Prev.Ventana = Ventana;
					Prev.Story = temp;
					Prev.Show();
					this.Dispose();
				}

			}
		}
		public  void  CreateObjectStory (int ID)
        {
			string query = "SELECT h.Nom_Historia,h.ID_Historia,h.Resumen,h.ID_Genero,h.Fo_Portada,h.Raiting,h.Estatus,Base.ID_Usuario,h.Seguidores,h.Favoritos,h.Vistas,u.Nombre From Usuarios_Historias AS Base INNER JOIN Usuarios AS u ON u.Codigo = Base.ID_Usuario INNER JOIN Historias AS h ON h.ID_Historia = Base.ID_Historia  WHERE h.ID_Historia ="+ID;
			string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
			MySqlConnection connetionBD = new MySqlConnection(conexion);
			MySqlCommand comando = new MySqlCommand(query, connetionBD);
			MySqlDataReader lector;
			connetionBD.Open();
			lector = comando.ExecuteReader();
			while (lector.Read())
			{
				Historias element = new Historias(lector.GetString(0), lector.GetInt32(1), lector.GetString(2), lector.GetString(3), lector.GetString(4), lector.GetString(5), lector.GetString(6), lector.GetInt32(7), lector.GetInt32(8), lector.GetInt32(8), lector.GetInt32(10), lector.GetString(11));
				DownloadImage("https://notecucei.000webhostapp.com/" + element.GetCover(), element.GetCover());
				ListStories.Add(element);
			}
			connetionBD.Close();

		}
		void DownloadImage(string URL, String Name)
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
		public static void SaveModel(MLContext mlContext, DataViewSchema trainingDataViewSchema, ITransformer model)
		{
			var modelPath = Path.Combine(Environment.CurrentDirectory, "Datos", "StoryRecommenderModel.zip");
			mlContext.Model.Save(model, trainingDataViewSchema, modelPath);
		}

        private void RTBWriteZone_TextChanged(object sender, EventArgs e)
        {

        }

        private void GBRecommend_Enter(object sender, EventArgs e)
        {

        }

        private void GBDetails_Enter(object sender, EventArgs e)
        {

        }
    }
}
