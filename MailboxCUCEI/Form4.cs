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
using System.Net;
using System.IO;
using System.Threading;

namespace MailboxCUCEI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        List<Historias> ListStories = new List<Historias>();
        List<Historias> ResultSearch;
        private WebClient Cliente = new WebClient();
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
        

        private void BTNCerrarSesion_Click(object sender, EventArgs e)
        {
            ControlThread = false;
            Form regreso = new Login();
            regreso.Show();
            Hide();
        }
        bool TopStoriesAlready = false;
        public bool User;
        public Usuario ActUser; //Variable de los datos del usuario
        
        void CreateStoryList ()
        {
            string query = "SELECT h.Nom_Historia,h.ID_Historia,h.Resumen,h.ID_Genero,h.Fo_Portada,h.Raiting,h.Estatus,Base.ID_Usuario,h.Seguidores,h.Favoritos,h.Vistas,u.Nombre From Usuarios_Historias AS Base INNER JOIN Usuarios AS u ON u.Codigo = Base.ID_Usuario INNER JOIN Historias AS h ON h.ID_Historia = Base.ID_Historia  ORDER BY h.Vistas DESC LIMIT 10 ";
            string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
            MySqlConnection connetionBD = new MySqlConnection(conexion);
            MySqlCommand comando = new MySqlCommand(query, connetionBD);
            MySqlDataReader lector;
            connetionBD.Open();
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Historias element = new Historias(lector.GetString(0), lector.GetInt32(1), lector.GetString(2), lector.GetString(3), lector.GetString(4), lector.GetString(5), lector.GetString(6), lector.GetInt32(7), lector.GetInt32(8), lector.GetInt32(8), lector.GetInt32(10),lector.GetString(11));
                DownloadImage("https://notecucei.000webhostapp.com/"+element.GetCover(),element.GetCover());
                ListStories.Add(element);
            }
            connetionBD.Close();
        }
        bool ControlThread = true;
        private void Principal_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            if (User)
            {
                BtnPerfil.Enabled = false;
                BTNEscribir.Enabled = false;
            }
            else
            {
                Thread th = new Thread(function1);
                th.Start();
            }
            CreateStoryList();
            CreateTopStorie();
        }
        int NotifyNumber = 0;
        void function1()
        {
            while (ControlThread)
            {
                string query = "SELECT *From Notificaciones WHERE ID_Usuario = " + ActUser.GetID() + " AND Estatus = 1";
                string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
                MySqlConnection connetionBD = new MySqlConnection(conexion);
                MySqlCommand comando = new MySqlCommand(query, connetionBD);
                MySqlDataReader lector;
                connetionBD.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    NotifyNumber++;
                    BtnPerfil.Text ="Mi Perfil(" + NotifyNumber.ToString() + ")" ;
                }
                connetionBD.Close();
                Thread.Sleep(60000); // Esperar un minuto hasta la siguiente notificación
            }
        }
        public void Reload ()
        {
            PanelTopStories.Controls.Clear();
            TopStoriesAlready = false;
            CreateStoryList();
            CreateTopStorie();
        }
        void CreateResults ()
        {
            //Consolas, 9.75pt, style=Bold
            int LocalX = 0;
                foreach (Historias elements in ResultSearch)
                {
                    PictureBox pbox = new PictureBox();
                    pbox.Size = new Size(194, 138);
                    pbox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbox.Location = new Point(LocalX, 0);
                    pbox.Image = Image.FromFile(elements.GetCover());
                    //Crear Boton
                    Button lblPlateNOBAR = new Button();
                    lblPlateNOBAR.Text = elements.GetName();
                    lblPlateNOBAR.FlatStyle = FlatStyle.Flat;
                    lblPlateNOBAR.Font = new Font("Consolas", 9,FontStyle.Bold);
                    lblPlateNOBAR.Size = new Size(194, 30);
                    lblPlateNOBAR.ForeColor = Color.Black;
                    lblPlateNOBAR.Location = new Point(LocalX, 140);
                    this.toolTip1.SetToolTip(lblPlateNOBAR, elements.GetSummary());
                    lblPlateNOBAR.Click += new EventHandler(handlerComun_Click);
                    PNResults.Controls.Add(pbox);
                    PNResults.Controls.Add(lblPlateNOBAR);
                    LocalX = LocalX + 209;
                }
            
        }
        void CreateTopStorie ()
        {
            if (TopStoriesAlready==false)
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
                    lblPlateNOBAR.Font = new Font("Consola", 9,FontStyle.Bold);
                    lblPlateNOBAR.Size = new Size(194, 30);
                    lblPlateNOBAR.ForeColor  = Color.Black;
                    lblPlateNOBAR.Location = new Point(LocalX, 140);
                    this.toolTip1.SetToolTip(lblPlateNOBAR, elements.GetSummary());
                    lblPlateNOBAR.Click += new EventHandler(handlerComun_Click);
                    PanelTopStories.Controls.Add(pbox);
                    PanelTopStories.Controls.Add(lblPlateNOBAR);
                    LocalX = LocalX + 209;
                    TopStoriesAlready = true;
                 }
            }
            
        }
        void GenerateView(Historias temp)
        {
            temp.IncreaseID();
            string query = "INSERT INTO `Vistas` (`ID_Vista`, `ID_Historia`, `ID_Usuario`) VALUES (NULL, '"+temp.GetID()+"', '"+ActUser.GetID()+"');";
            MySqlConnection conectar = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
            conectar.Open();
            MySqlCommand comando = new MySqlCommand(query);
            comando.Connection = conectar;
            comando.ExecuteNonQuery();
            conectar.Close();
        }
        private void handlerComun_Click (object sender, EventArgs e)
        {
            foreach (Historias temp in ListStories)
            {
                
                if (((Button)sender).Text== temp.GetName())
                {
                    FRMPreview Prev = new FRMPreview();
                    if (!User)
                    {
                        GenerateView(temp);
                        string query = "UPDATE `Historias` SET `Vistas` = '"+temp.GetViews()+"' WHERE `Historias`.`ID_Historia` = "+temp.GetID()+"";
                        MySqlConnection conectar = new MySqlConnection("Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;");
                        conectar.Open();
                        MySqlCommand comando = new MySqlCommand(query);
                        comando.Connection = conectar;
                        comando.ExecuteNonQuery();
                        conectar.Close();
                    }
                    ControlThread = false;
                    Prev.ActUser = ActUser;
                    Prev.Ventana = this;
                    Prev.Story = temp;
                    Prev.Show();
                    this.Hide();
                }
               
            }
        }
        

        

        private void BTNVisualizar_Click(object sender, EventArgs e)
        {

        }

        private void BTNRefrescar_Click(object sender, EventArgs e)
        {
            
        }

        

        

        private void BTNRespaldo_Click(object sender, EventArgs e)
        {
            
        }
		void BTNEscribirClick(object sender, EventArgs e)
		{
            ControlThread = false;
            FRMPreWri Nueva = new FRMPreWri();
			Nueva.NueaVentana=this;
			this.Hide();
			Nueva.Show();
            Nueva.ActUser = ActUser;
		}

        private void BtnPerfil_Click(object sender, EventArgs e)
        {
            
            ControlThread = false;
            Administrador op = new Administrador();
            op.TxtCodigoPerfil.Text = manduser.Text;
            this.Hide();
            op.ActUser = ActUser;
            op.NotifyNumber = NotifyNumber;
            op.Base = this;
            op.Show();
        }

        private void txtsearch_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text =="Buscar")
            {
                txtsearch.Text = "";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {                 //
            string query = "SELECT h.Nom_Historia,h.ID_Historia,h.Resumen,h.ID_Genero,h.Fo_Portada,h.Raiting,h.Estatus,Base.ID_Usuario,h.Seguidores,h.Favoritos,h.Vistas,u.Nombre From Usuarios_Historias AS Base INNER JOIN Usuarios AS u ON u.Codigo = Base.ID_Usuario INNER JOIN Historias AS h ON h.ID_Historia = Base.ID_Historia  WHERE MATCH(Nom_Historia,Resumen) AGAINST ('" + txtsearch.Text+"')";
            string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
            MySqlConnection connetionBD = new MySqlConnection(conexion);
            MySqlCommand comando = new MySqlCommand(query, connetionBD);
            MySqlDataReader lector;
            connetionBD.Open();
            lector = comando.ExecuteReader();

            if (lector.Read())
            {
                lblwarningsearch.Visible = false;
                connetionBD.Close();
                connetionBD.Open();
                lector = comando.ExecuteReader();
                PNResults.Controls.Clear();
                ResultSearch = new List<Historias>();
            
                while (lector.Read())
                {
                    Historias element = new Historias(lector.GetString(0), lector.GetInt32(1), lector.GetString(2), lector.GetString(3), lector.GetString(4), lector.GetString(5), lector.GetString(6), lector.GetInt32(7), lector.GetInt32(8), lector.GetInt32(8), lector.GetInt32(10), lector.GetString(11));
                    DownloadImage("https://notecucei.000webhostapp.com/" + element.GetCover(), element.GetCover());
                    ResultSearch.Add(element);
                }
                connetionBD.Close();
                CreateResults();
            }
            else
            {
                lblwarningsearch.Visible = true;
                connetionBD.Close();
            }
            
        }

        private void btnSB_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> DiccionarioDeGeneros = new Dictionary<string, int>();
            DiccionarioDeGeneros.Add("Aventura", 1);
            DiccionarioDeGeneros.Add("Romance", 2);
            DiccionarioDeGeneros.Add("Ciencia Ficción", 3);
            DiccionarioDeGeneros.Add("Drama", 4);
            DiccionarioDeGeneros.Add("Fanfiction", 5);
            DiccionarioDeGeneros.Add("Historica", 6);
            DiccionarioDeGeneros.Add("Policia", 7);
            DiccionarioDeGeneros.Add("Misterio", 8);
            DiccionarioDeGeneros.Add("Fantasia", 9);
            DiccionarioDeGeneros.Add("Suspenso", 11);
            DiccionarioDeGeneros.Add("Tragedia", 12);
            DiccionarioDeGeneros.Add("Terror", 13);
            string[] IDGenero = new string[2];
            switch (DiccionarioDeGeneros[CBGender.Text])
            {
                case 1:

                    IDGenero[0] = "%1|%";
                    IDGenero[1] = "%|1%";

                    break;
                case 2:

                    IDGenero[0] = "%2|%";
                    IDGenero[1] = "%|2%";

                    break;
                case 3:
                    IDGenero[0] = "%3|%";
                    IDGenero[1] = "%|3%";
                    break;
                case 4:
                    IDGenero[0] = "%4|%";
                    IDGenero[1] = "%|4%";
                    break;
                case 5:
                    IDGenero[0] = "%5|%";
                    IDGenero[1] = "%|5%";
                    break;
                case 6:
                    IDGenero[0] = "%6|%";
                    IDGenero[1] = "%|6%";
                    break;
                case 7:
                    IDGenero[0] = "%7|%";
                    IDGenero[1] = "%|7%";
                    break;
                case 8:
                    IDGenero[0] = "%8|%";
                    IDGenero[1] = "%|8%";
                    break;
                case 9:
                    IDGenero[0] = "%9|%";
                    IDGenero[1] = "%|9%";
                    break;
                case 11:
                    IDGenero[0] = "%11|%";
                    IDGenero[1] = "%|11%";
                    break;
                case 12:
                    IDGenero[0] = "%12|%";
                    IDGenero[1] = "%|12%";
                    break;
                case 13:
                    IDGenero[0] = "%13|%";
                    IDGenero[1] = "%|13%";
                    break;
            }
            // h.Nom_Historia,h.ID_Historia,h.Resumen,h.ID_Genero,h.Fo_Portada,h.Raiting,h.Estatus,Base.ID_Usuario,h.Seguidores,h.Favoritos,h.Vistas,u.Nombre From Usuarios_Historias AS Base INNER JOIN Usuarios AS u ON u.Codigo = Base.ID_Usuario INNER JOIN Historias AS h ON h.ID_Historia = Base.ID_Historia 
            string query = "SELECT h.Nom_Historia,h.ID_Historia,h.Resumen,h.ID_Genero,h.Fo_Portada,h.Raiting,h.Estatus,Base.ID_Usuario,h.Seguidores,h.Favoritos,h.Vistas,u.Nombre From Usuarios_Historias AS Base INNER JOIN Usuarios AS u ON u.Codigo = Base.ID_Usuario INNER JOIN Historias AS h ON h.ID_Historia = Base.ID_Historia WHERE `ID_Genero` LIKE '" + IDGenero[0] + "' UNION SELECT h.Nom_Historia,h.ID_Historia,h.Resumen,h.ID_Genero,h.Fo_Portada,h.Raiting,h.Estatus,Base.ID_Usuario,h.Seguidores,h.Favoritos,h.Vistas,u.Nombre From Usuarios_Historias AS Base INNER JOIN Usuarios AS u ON u.Codigo = Base.ID_Usuario INNER JOIN Historias AS h ON h.ID_Historia = Base.ID_Historia WHERE ID_Genero LIKE '" + IDGenero[1] + "' ";
            string conexion = "Server=bnqmsqe56xfyefbufx1k-mysql.services.clever-cloud.com; Database=bnqmsqe56xfyefbufx1k; Uid=ugdvlaubdknaqnb8; Pwd=nXHPKx9vaIhEJ2W8ZAqT;";
            MySqlConnection connetionBD = new MySqlConnection(conexion);
            MySqlCommand comando = new MySqlCommand(query, connetionBD);
            MySqlDataReader lector;
            connetionBD.Open();
            lector = comando.ExecuteReader();
            if (lector.Read())
            {
                connetionBD.Close();
                connetionBD.Open();
                lector = comando.ExecuteReader();
                PNResults.Controls.Clear();
                ResultSearch = new List<Historias>();

                while (lector.Read())
                {
                    Historias element = new Historias(lector.GetString(0), lector.GetInt32(1), lector.GetString(2), lector.GetString(3), lector.GetString(4), lector.GetString(5), lector.GetString(6), lector.GetInt32(7), lector.GetInt32(8), lector.GetInt32(8), lector.GetInt32(10), lector.GetString(11));
                    DownloadImage("https://notecucei.000webhostapp.com/" + element.GetCover(), element.GetCover());
                    ResultSearch.Add(element);
                }
                connetionBD.Close();
                CreateResults();
            }
            else
            {
                MessageBox.Show("No se encontraron resultados");
                connetionBD.Close();
            }
            
        }

        private void CBSort_SelectedValueChanged(object sender, EventArgs e)
        {
            IEnumerable<Historias> Temp = ResultSearch;
            switch (CBSort.Text)
            {
                case "Ordenar Por":
                    break;
                case "Mas Recientes":
                    Temp = ResultSearch.OrderBy(ResultSearch => ResultSearch.ID);
                    break;
                case "Menos Recientes":
                    Temp = ResultSearch.OrderByDescending(ResultSearch => ResultSearch.ID);
                    break;
                case "Mas Follows":
                    Temp = ResultSearch.OrderByDescending(ResultSearch => ResultSearch.Follows);
                    break;
                case "Menos Follows":
                    Temp = ResultSearch.OrderBy(ResultSearch => ResultSearch.Follows);
                    break;
                case "Mas Favoritos":
                    Temp = ResultSearch.OrderByDescending(ResultSearch => ResultSearch.Favs);
                    break;
                case "Menos Favoritos":
                    Temp = ResultSearch.OrderBy(ResultSearch => ResultSearch.Follows);
                    break;
                case "Mas Vistas":
                    Temp = ResultSearch.OrderByDescending(ResultSearch => ResultSearch.Views);
                    break;
                case "Menos Vistas":
                    Temp = ResultSearch.OrderBy(ResultSearch => ResultSearch.Views);
                    break;
            }
            PNResults.Controls.Clear();
            CreateResultsSort(Temp);


        }
        void CreateResultsSort(IEnumerable<Historias> Temp)
        {
            int LocalX = 0;
            foreach (Historias elements in Temp)
            {
                PictureBox pbox = new PictureBox();
                pbox.Size = new Size(194, 138);
                pbox.SizeMode = PictureBoxSizeMode.StretchImage;
                pbox.Location = new Point(LocalX, 0);
                pbox.Image = Image.FromFile(elements.GetCover());
                //Crear Boton
                Button lblPlateNOBAR = new Button();
                lblPlateNOBAR.Text = elements.GetName();
                lblPlateNOBAR.FlatStyle = FlatStyle.Flat;
                lblPlateNOBAR.Font = new Font("Consolas", 9,FontStyle.Bold);
                lblPlateNOBAR.Size = new Size(194, 30);
                lblPlateNOBAR.ForeColor = Color.Black;
                lblPlateNOBAR.Location = new Point(LocalX, 140);
                this.toolTip1.SetToolTip(lblPlateNOBAR, elements.GetSummary());
                lblPlateNOBAR.Click += new EventHandler(handlerComun_Click);
                PNResults.Controls.Add(pbox);
                PNResults.Controls.Add(lblPlateNOBAR);
                LocalX = LocalX + 209;
            }
        }
        private void CBSort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
