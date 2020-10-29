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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMPreview));
            this.BTNSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.GBDetails = new System.Windows.Forms.GroupBox();
            this.CBFollow = new System.Windows.Forms.CheckBox();
            this.CBDowload = new System.Windows.Forms.CheckBox();
            this.CBFav = new System.Windows.Forms.CheckBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.lblSummary = new System.Windows.Forms.Label();
            this.LBLTitle = new System.Windows.Forms.Label();
            this.PBCover = new System.Windows.Forms.PictureBox();
            this.lblStoryName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblraiting = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBLGenero = new System.Windows.Forms.Label();
            this.LBLQuest = new System.Windows.Forms.Label();
            this.GBDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBCover)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNSalir
            // 
            this.BTNSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSalir.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTNSalir.Location = new System.Drawing.Point(322, 391);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(53, 26);
            this.BTNSalir.TabIndex = 2;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(334, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 2);
            this.label3.TabIndex = 13;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // GBDetails
            // 
            this.GBDetails.Controls.Add(this.CBFollow);
            this.GBDetails.Controls.Add(this.CBDowload);
            this.GBDetails.Controls.Add(this.BTNSalir);
            this.GBDetails.Controls.Add(this.CBFav);
            this.GBDetails.Controls.Add(this.btnRead);
            this.GBDetails.Controls.Add(this.lblSummary);
            this.GBDetails.Controls.Add(this.LBLTitle);
            this.GBDetails.Controls.Add(this.PBCover);
            this.GBDetails.Controls.Add(this.lblStoryName);
            this.GBDetails.Controls.Add(this.label4);
            this.GBDetails.Controls.Add(this.lblstatus);
            this.GBDetails.Controls.Add(this.label1);
            this.GBDetails.Controls.Add(this.lblraiting);
            this.GBDetails.Controls.Add(this.label2);
            this.GBDetails.Controls.Add(this.LBLGenero);
            this.GBDetails.Controls.Add(this.LBLQuest);
            this.GBDetails.Location = new System.Drawing.Point(13, 13);
            this.GBDetails.Name = "GBDetails";
            this.GBDetails.Size = new System.Drawing.Size(389, 425);
            this.GBDetails.TabIndex = 16;
            this.GBDetails.TabStop = false;
            this.GBDetails.Text = "groupBox1";
            // 
            // CBFollow
            // 
            this.CBFollow.AutoSize = true;
            this.CBFollow.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.CBFollow.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CBFollow.Location = new System.Drawing.Point(244, 394);
            this.CBFollow.Name = "CBFollow";
            this.CBFollow.Size = new System.Drawing.Size(75, 24);
            this.CBFollow.TabIndex = 22;
            this.CBFollow.Text = "Follow";
            this.CBFollow.UseVisualStyleBackColor = true;
            // 
            // CBDowload
            // 
            this.CBDowload.AutoSize = true;
            this.CBDowload.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.CBDowload.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CBDowload.Location = new System.Drawing.Point(72, 393);
            this.CBDowload.Name = "CBDowload";
            this.CBDowload.Size = new System.Drawing.Size(105, 24);
            this.CBDowload.TabIndex = 20;
            this.CBDowload.Text = "Descargar";
            this.CBDowload.UseVisualStyleBackColor = true;
            // 
            // CBFav
            // 
            this.CBFav.AutoSize = true;
            this.CBFav.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.CBFav.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CBFav.Location = new System.Drawing.Point(183, 393);
            this.CBFav.Name = "CBFav";
            this.CBFav.Size = new System.Drawing.Size(55, 24);
            this.CBFav.TabIndex = 21;
            this.CBFav.Text = "Fav";
            this.CBFav.UseVisualStyleBackColor = true;
            // 
            // btnRead
            // 
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnRead.Location = new System.Drawing.Point(13, 393);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(53, 26);
            this.btnRead.TabIndex = 17;
            this.btnRead.Text = "Leer";
            this.btnRead.UseCompatibleTextRendering = true;
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSummary.Location = new System.Drawing.Point(9, 214);
            this.lblSummary.MaximumSize = new System.Drawing.Size(366, 108);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSummary.Size = new System.Drawing.Size(78, 20);
            this.lblSummary.TabIndex = 19;
            this.lblSummary.Text = "[Nombre]";
            this.lblSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSummary.UseMnemonic = false;
            // 
            // LBLTitle
            // 
            this.LBLTitle.AutoSize = true;
            this.LBLTitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LBLTitle.Location = new System.Drawing.Point(9, 194);
            this.LBLTitle.Name = "LBLTitle";
            this.LBLTitle.Size = new System.Drawing.Size(78, 20);
            this.LBLTitle.TabIndex = 18;
            this.LBLTitle.Text = "[Nombre]";
            this.LBLTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBLTitle.UseMnemonic = false;
            // 
            // PBCover
            // 
            this.PBCover.Location = new System.Drawing.Point(6, 19);
            this.PBCover.Name = "PBCover";
            this.PBCover.Size = new System.Drawing.Size(369, 172);
            this.PBCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBCover.TabIndex = 17;
            this.PBCover.TabStop = false;
            // 
            // lblStoryName
            // 
            this.lblStoryName.AutoSize = true;
            this.lblStoryName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoryName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblStoryName.Location = new System.Drawing.Point(84, 331);
            this.lblStoryName.Name = "lblStoryName";
            this.lblStoryName.Size = new System.Drawing.Size(61, 20);
            this.lblStoryName.TabIndex = 16;
            this.lblStoryName.Text = "Historia";
            this.lblStoryName.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(154, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Estatus";
            this.label4.UseMnemonic = false;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblstatus.Location = new System.Drawing.Point(229, 360);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(82, 20);
            this.lblstatus.TabIndex = 14;
            this.lblstatus.Text = "Completo";
            this.lblstatus.UseMnemonic = false;
            this.lblstatus.Click += new System.EventHandler(this.Label5Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(9, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Raiting";
            this.label1.UseMnemonic = false;
            // 
            // lblraiting
            // 
            this.lblraiting.AutoSize = true;
            this.lblraiting.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblraiting.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblraiting.Location = new System.Drawing.Point(87, 360);
            this.lblraiting.Name = "lblraiting";
            this.lblraiting.Size = new System.Drawing.Size(24, 20);
            this.lblraiting.TabIndex = 12;
            this.lblraiting.Text = "M";
            this.lblraiting.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(151, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Generos";
            this.label2.UseMnemonic = false;
            // 
            // LBLGenero
            // 
            this.LBLGenero.AutoSize = true;
            this.LBLGenero.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLGenero.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LBLGenero.Location = new System.Drawing.Point(229, 331);
            this.LBLGenero.Name = "LBLGenero";
            this.LBLGenero.Size = new System.Drawing.Size(72, 20);
            this.LBLGenero.TabIndex = 10;
            this.LBLGenero.Text = "Generos";
            this.LBLGenero.UseMnemonic = false;
            // 
            // LBLQuest
            // 
            this.LBLQuest.AutoSize = true;
            this.LBLQuest.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLQuest.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LBLQuest.Location = new System.Drawing.Point(6, 331);
            this.LBLQuest.Name = "LBLQuest";
            this.LBLQuest.Size = new System.Drawing.Size(61, 20);
            this.LBLQuest.TabIndex = 8;
            this.LBLQuest.Text = "Historía";
            this.LBLQuest.UseMnemonic = false;
            // 
            // FRMPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.GBDetails);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.FRMWrite_Load);
            this.GBDetails.ResumeLayout(false);
            this.GBDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GBDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBLQuest;
        public System.Windows.Forms.Label lblstatus;
        public System.Windows.Forms.Label lblraiting;
        public System.Windows.Forms.Label LBLGenero;
        public System.Windows.Forms.Label lblStoryName;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label LBLTitle;
        private System.Windows.Forms.PictureBox PBCover;
        private System.Windows.Forms.CheckBox CBFollow;
        private System.Windows.Forms.CheckBox CBDowload;
        private System.Windows.Forms.CheckBox CBFav;
    }
}