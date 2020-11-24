namespace MailboxCUCEI
{
    partial class FRMPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMPreview));
            this.BTNSalir = new System.Windows.Forms.Button();
            this.GBDetails = new System.Windows.Forms.GroupBox();
            this.lblSummary = new System.Windows.Forms.Label();
            this.LBLTitle = new System.Windows.Forms.Label();
            this.PBCover = new System.Windows.Forms.PictureBox();
            this.LBLAuthor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblraiting = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBLGenero = new System.Windows.Forms.Label();
            this.LBLQuest = new System.Windows.Forms.Label();
            this.CBFollow = new System.Windows.Forms.CheckBox();
            this.CBDowload = new System.Windows.Forms.CheckBox();
            this.CBFav = new System.Windows.Forms.CheckBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GBDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBCover)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNSalir
            // 
            this.BTNSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSalir.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BTNSalir.Location = new System.Drawing.Point(11, 395);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(149, 47);
            this.BTNSalir.TabIndex = 2;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // GBDetails
            // 
            this.GBDetails.Controls.Add(this.lblSummary);
            this.GBDetails.Controls.Add(this.LBLTitle);
            this.GBDetails.Controls.Add(this.PBCover);
            this.GBDetails.Controls.Add(this.LBLAuthor);
            this.GBDetails.Controls.Add(this.label4);
            this.GBDetails.Controls.Add(this.lblstatus);
            this.GBDetails.Controls.Add(this.label1);
            this.GBDetails.Controls.Add(this.lblraiting);
            this.GBDetails.Controls.Add(this.label2);
            this.GBDetails.Controls.Add(this.LBLGenero);
            this.GBDetails.Controls.Add(this.LBLQuest);
            this.GBDetails.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDetails.ForeColor = System.Drawing.Color.Black;
            this.GBDetails.Location = new System.Drawing.Point(200, 12);
            this.GBDetails.Name = "GBDetails";
            this.GBDetails.Size = new System.Drawing.Size(434, 440);
            this.GBDetails.TabIndex = 16;
            this.GBDetails.TabStop = false;
            this.GBDetails.Text = "Información";
            this.GBDetails.Enter += new System.EventHandler(this.GBDetails_Enter);
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.ForeColor = System.Drawing.Color.Black;
            this.lblSummary.Location = new System.Drawing.Point(6, 296);
            this.lblSummary.MaximumSize = new System.Drawing.Size(366, 108);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSummary.Size = new System.Drawing.Size(72, 18);
            this.lblSummary.TabIndex = 19;
            this.lblSummary.Text = "[Nombre]";
            this.lblSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSummary.UseMnemonic = false;
            this.lblSummary.Click += new System.EventHandler(this.lblSummary_Click);
            // 
            // LBLTitle
            // 
            this.LBLTitle.AutoSize = true;
            this.LBLTitle.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTitle.ForeColor = System.Drawing.Color.Black;
            this.LBLTitle.Location = new System.Drawing.Point(6, 263);
            this.LBLTitle.Name = "LBLTitle";
            this.LBLTitle.Size = new System.Drawing.Size(72, 18);
            this.LBLTitle.TabIndex = 18;
            this.LBLTitle.Text = "[Nombre]";
            this.LBLTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBLTitle.UseMnemonic = false;
            this.LBLTitle.Click += new System.EventHandler(this.LBLTitle_Click);
            // 
            // PBCover
            // 
            this.PBCover.Location = new System.Drawing.Point(35, 19);
            this.PBCover.Name = "PBCover";
            this.PBCover.Size = new System.Drawing.Size(377, 241);
            this.PBCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBCover.TabIndex = 17;
            this.PBCover.TabStop = false;
            // 
            // LBLAuthor
            // 
            this.LBLAuthor.AutoSize = true;
            this.LBLAuthor.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAuthor.ForeColor = System.Drawing.Color.Black;
            this.LBLAuthor.Location = new System.Drawing.Point(81, 384);
            this.LBLAuthor.Name = "LBLAuthor";
            this.LBLAuthor.Size = new System.Drawing.Size(72, 18);
            this.LBLAuthor.TabIndex = 16;
            this.LBLAuthor.Text = "Historia";
            this.LBLAuthor.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(186, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Estatus";
            this.label4.UseMnemonic = false;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.ForeColor = System.Drawing.Color.Black;
            this.lblstatus.Location = new System.Drawing.Point(261, 413);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(72, 18);
            this.lblstatus.TabIndex = 14;
            this.lblstatus.Text = "Completo";
            this.lblstatus.UseMnemonic = false;
            this.lblstatus.Click += new System.EventHandler(this.Label5Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Raiting";
            this.label1.UseMnemonic = false;
            // 
            // lblraiting
            // 
            this.lblraiting.AutoSize = true;
            this.lblraiting.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblraiting.ForeColor = System.Drawing.Color.Black;
            this.lblraiting.Location = new System.Drawing.Point(91, 413);
            this.lblraiting.Name = "lblraiting";
            this.lblraiting.Size = new System.Drawing.Size(16, 18);
            this.lblraiting.TabIndex = 12;
            this.lblraiting.Text = "M";
            this.lblraiting.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(183, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Generos";
            this.label2.UseMnemonic = false;
            // 
            // LBLGenero
            // 
            this.LBLGenero.AutoSize = true;
            this.LBLGenero.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLGenero.ForeColor = System.Drawing.Color.Black;
            this.LBLGenero.Location = new System.Drawing.Point(261, 384);
            this.LBLGenero.Name = "LBLGenero";
            this.LBLGenero.Size = new System.Drawing.Size(64, 18);
            this.LBLGenero.TabIndex = 10;
            this.LBLGenero.Text = "Generos";
            this.LBLGenero.UseMnemonic = false;
            // 
            // LBLQuest
            // 
            this.LBLQuest.AutoSize = true;
            this.LBLQuest.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLQuest.ForeColor = System.Drawing.Color.Black;
            this.LBLQuest.Location = new System.Drawing.Point(10, 384);
            this.LBLQuest.Name = "LBLQuest";
            this.LBLQuest.Size = new System.Drawing.Size(48, 18);
            this.LBLQuest.TabIndex = 8;
            this.LBLQuest.Text = "Autor";
            this.LBLQuest.UseMnemonic = false;
            // 
            // CBFollow
            // 
            this.CBFollow.AutoSize = true;
            this.CBFollow.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.CBFollow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CBFollow.Location = new System.Drawing.Point(11, 267);
            this.CBFollow.Name = "CBFollow";
            this.CBFollow.Size = new System.Drawing.Size(72, 24);
            this.CBFollow.TabIndex = 22;
            this.CBFollow.Text = "Seguir";
            this.CBFollow.UseVisualStyleBackColor = true;
            this.CBFollow.CheckedChanged += new System.EventHandler(this.CBFollow_CheckedChanged);
            // 
            // CBDowload
            // 
            this.CBDowload.AutoSize = true;
            this.CBDowload.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.CBDowload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CBDowload.Location = new System.Drawing.Point(11, 172);
            this.CBDowload.Name = "CBDowload";
            this.CBDowload.Size = new System.Drawing.Size(105, 24);
            this.CBDowload.TabIndex = 20;
            this.CBDowload.Text = "Descargar";
            this.CBDowload.UseVisualStyleBackColor = true;
            this.CBDowload.CheckedChanged += new System.EventHandler(this.CBDowload_CheckedChanged);
            // 
            // CBFav
            // 
            this.CBFav.AutoSize = true;
            this.CBFav.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.CBFav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CBFav.Location = new System.Drawing.Point(11, 219);
            this.CBFav.Name = "CBFav";
            this.CBFav.Size = new System.Drawing.Size(94, 24);
            this.CBFav.TabIndex = 21;
            this.CBFav.Text = "Favoritos";
            this.CBFav.UseVisualStyleBackColor = true;
            this.CBFav.CheckedChanged += new System.EventHandler(this.CBFav_CheckedChanged);
            // 
            // btnRead
            // 
            this.btnRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRead.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRead.Location = new System.Drawing.Point(11, 318);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(149, 53);
            this.btnRead.TabIndex = 17;
            this.btnRead.Text = "Leer";
            this.btnRead.UseCompatibleTextRendering = true;
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BTNSalir);
            this.panel1.Controls.Add(this.CBFollow);
            this.panel1.Controls.Add(this.btnRead);
            this.panel1.Controls.Add(this.CBFav);
            this.panel1.Controls.Add(this.CBDowload);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 464);
            this.panel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // FRMPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(648, 465);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GBDetails);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.FRMWrite_Load);
            this.GBDetails.ResumeLayout(false);
            this.GBDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBCover)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.GroupBox GBDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBLQuest;
        public System.Windows.Forms.Label lblstatus;
        public System.Windows.Forms.Label lblraiting;
        public System.Windows.Forms.Label LBLGenero;
        public System.Windows.Forms.Label LBLAuthor;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label LBLTitle;
        private System.Windows.Forms.PictureBox PBCover;
        private System.Windows.Forms.CheckBox CBFollow;
        private System.Windows.Forms.CheckBox CBDowload;
        private System.Windows.Forms.CheckBox CBFav;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}