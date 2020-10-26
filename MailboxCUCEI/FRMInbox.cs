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
    public partial class FRMInbox : Form
    {
    	public Principal NueaVentana;
        public FRMInbox()
        {
            InitializeComponent();
        }
		int CurrentLocationX, CurrentLocationY;
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
		

        private void FRMPreWri_Load(object sender, EventArgs e)
        {

        }
    }
}
