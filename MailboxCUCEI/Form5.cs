using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailboxCUCEI
{
    public partial class FRMPreWri : Form
    {
    	public Principal NueaVentana;
        public FRMPreWri()
        {
            InitializeComponent();
        }





		public Usuario ActUser;

		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void BtnBackClick(object sender, EventArgs e)
		{
			NueaVentana.Show();
			this.Dispose();
		}
		void BTNContClick(object sender, EventArgs e)
		{
			FRMSelectStory Ventana = new FRMSelectStory();
			Ventana.NueaVentana = NueaVentana;
			this.Hide();
			Ventana.Show();
		}
		void BTNNewStoClick(object sender, EventArgs e)
		{
			FRMCreateStory NVentada = new FRMCreateStory();
			NVentada.Base=NueaVentana;
			this.Hide();
			NVentada.Show();
			NVentada.ActUser = ActUser;
		}

        private void FRMPreWri_Load(object sender, EventArgs e)
        {

        }
    }
}
