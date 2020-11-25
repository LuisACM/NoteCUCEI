namespace MailboxCUCEI
{
    partial class FRMChoose
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.manduser = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PNResults = new System.Windows.Forms.Panel();
            this.LBLWarning = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.calificarlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3.SuspendLayout();
            this.PNResults.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // manduser
            // 
            this.manduser.AutoSize = true;
            this.manduser.Location = new System.Drawing.Point(0, 471);
            this.manduser.Name = "manduser";
            this.manduser.Size = new System.Drawing.Size(35, 13);
            this.manduser.TabIndex = 11;
            this.manduser.Text = "label2";
            this.manduser.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PNResults);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(13, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(794, 222);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Elige al menos tres historias";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // PNResults
            // 
            this.PNResults.AutoScroll = true;
            this.PNResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PNResults.Controls.Add(this.LBLWarning);
            this.PNResults.Location = new System.Drawing.Point(7, 23);
            this.PNResults.Name = "PNResults";
            this.PNResults.Size = new System.Drawing.Size(781, 191);
            this.PNResults.TabIndex = 0;
            // 
            // LBLWarning
            // 
            this.LBLWarning.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLWarning.ForeColor = System.Drawing.Color.DimGray;
            this.LBLWarning.Location = new System.Drawing.Point(3, 65);
            this.LBLWarning.Name = "LBLWarning";
            this.LBLWarning.Size = new System.Drawing.Size(775, 40);
            this.LBLWarning.TabIndex = 32;
            this.LBLWarning.Text = "¡Aún no has descargado ninguna historia!";
            this.LBLWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBLWarning.UseMnemonic = false;
            this.LBLWarning.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(580, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnborrar
            // 
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnborrar.Location = new System.Drawing.Point(355, 20);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(151, 36);
            this.btnborrar.TabIndex = 33;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Visible = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // calificarlabel
            // 
            this.calificarlabel.AutoSize = true;
            this.calificarlabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calificarlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.calificarlabel.Location = new System.Drawing.Point(10, 27);
            this.calificarlabel.Name = "calificarlabel";
            this.calificarlabel.Size = new System.Drawing.Size(290, 22);
            this.calificarlabel.TabIndex = 31;
            this.calificarlabel.Text = "Haz seleccionado 0 historias";
            this.calificarlabel.UseMnemonic = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnborrar);
            this.panel1.Controls.Add(this.calificarlabel);
            this.panel1.Location = new System.Drawing.Point(0, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 84);
            this.panel1.TabIndex = 34;
            // 
            // FRMChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(819, 332);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.manduser);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMChoose";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailboxCUCEI";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.groupBox3.ResumeLayout(false);
            this.PNResults.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Label manduser;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel PNResults;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Label calificarlabel;
        private System.Windows.Forms.Label LBLWarning;
        private System.Windows.Forms.Panel panel1;
    }
}