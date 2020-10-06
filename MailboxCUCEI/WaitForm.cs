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
    public partial class WaitForm : Form
    {
    	public Principal NueaVentana;
        public WaitForm()
        {
            InitializeComponent();
        }

       

       

        
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
			FRMWrite Ventana = new FRMWrite();
			Ventana.Ventana = NueaVentana;
			this.Hide();
			Ventana.Show();
		}
		void BTNNewStoClick(object sender, EventArgs e)
		{
			FRMCreateStory NVentada = new FRMCreateStory();
			NVentada.Base=NueaVentana;
			this.Hide();
			NVentada.Show();
		}
    }
}
