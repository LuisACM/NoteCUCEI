namespace MailboxCUCEI
{
    partial class FRMReadZone

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMReadZone));
            this.BTNSalir = new System.Windows.Forms.Button();
            this.BTNNextChapter = new System.Windows.Forms.Button();
            this.GBDetails = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNBack = new System.Windows.Forms.Button();
            this.lblCapitulo = new System.Windows.Forms.Label();
            this.lblStoryName = new System.Windows.Forms.Label();
            this.BTNDecreaseLetters = new System.Windows.Forms.Button();
            this.BTNIncreaseLetters = new System.Windows.Forms.Button();
            this.RTBWriteZone = new System.Windows.Forms.RichTextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.BTNSendComment = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtcomments = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CalificacionCB = new System.Windows.Forms.ComboBox();
            this.calificarlabel = new System.Windows.Forms.Label();
            this.calificarbtn = new System.Windows.Forms.Button();
            this.flagLabel = new System.Windows.Forms.Label();
            this.GBRecommend = new System.Windows.Forms.GroupBox();
            this.PNRecommends = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GBDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.GBRecommend.SuspendLayout();
            this.PNRecommends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNSalir
            // 
            this.BTNSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSalir.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSalir.ForeColor = System.Drawing.Color.Gray;
            this.BTNSalir.Location = new System.Drawing.Point(19, 467);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(164, 49);
            this.BTNSalir.TabIndex = 2;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // BTNNextChapter
            // 
            this.BTNNextChapter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNNextChapter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNNextChapter.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNextChapter.ForeColor = System.Drawing.Color.Gray;
            this.BTNNextChapter.Location = new System.Drawing.Point(19, 224);
            this.BTNNextChapter.Name = "BTNNextChapter";
            this.BTNNextChapter.Size = new System.Drawing.Size(164, 54);
            this.BTNNextChapter.TabIndex = 15;
            this.BTNNextChapter.Text = "Capítulo siguiente";
            this.BTNNextChapter.UseVisualStyleBackColor = true;
            this.BTNNextChapter.Click += new System.EventHandler(this.BTNPublish_Click);
            // 
            // GBDetails
            // 
            this.GBDetails.Controls.Add(this.label1);
            this.GBDetails.Controls.Add(this.BTNBack);
            this.GBDetails.Controls.Add(this.lblCapitulo);
            this.GBDetails.Controls.Add(this.lblStoryName);
            this.GBDetails.Controls.Add(this.BTNNextChapter);
            this.GBDetails.Controls.Add(this.BTNDecreaseLetters);
            this.GBDetails.Controls.Add(this.BTNSalir);
            this.GBDetails.Controls.Add(this.BTNIncreaseLetters);
            this.GBDetails.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDetails.ForeColor = System.Drawing.Color.Gray;
            this.GBDetails.Location = new System.Drawing.Point(11, 236);
            this.GBDetails.Name = "GBDetails";
            this.GBDetails.Size = new System.Drawing.Size(221, 530);
            this.GBDetails.TabIndex = 16;
            this.GBDetails.TabStop = false;
            this.GBDetails.Text = "Estas Leyendo";
            this.GBDetails.Enter += new System.EventHandler(this.GBDetails_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tamaño de letra";
            // 
            // BTNBack
            // 
            this.BTNBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNBack.Enabled = false;
            this.BTNBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNBack.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBack.ForeColor = System.Drawing.Color.Gray;
            this.BTNBack.Location = new System.Drawing.Point(19, 154);
            this.BTNBack.Name = "BTNBack";
            this.BTNBack.Size = new System.Drawing.Size(164, 55);
            this.BTNBack.TabIndex = 26;
            this.BTNBack.Text = "Capítulo anterior";
            this.BTNBack.UseVisualStyleBackColor = true;
            this.BTNBack.Click += new System.EventHandler(this.BTNBack_Click);
            // 
            // lblCapitulo
            // 
            this.lblCapitulo.AutoSize = true;
            this.lblCapitulo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblCapitulo.Location = new System.Drawing.Point(6, 97);
            this.lblCapitulo.Name = "lblCapitulo";
            this.lblCapitulo.Size = new System.Drawing.Size(81, 19);
            this.lblCapitulo.TabIndex = 25;
            this.lblCapitulo.Text = "Capitulo";
            this.lblCapitulo.UseMnemonic = false;
            // 
            // lblStoryName
            // 
            this.lblStoryName.AutoSize = true;
            this.lblStoryName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoryName.ForeColor = System.Drawing.Color.Gray;
            this.lblStoryName.Location = new System.Drawing.Point(8, 42);
            this.lblStoryName.Name = "lblStoryName";
            this.lblStoryName.Size = new System.Drawing.Size(81, 19);
            this.lblStoryName.TabIndex = 16;
            this.lblStoryName.Text = "Historia";
            this.lblStoryName.UseMnemonic = false;
            // 
            // BTNDecreaseLetters
            // 
            this.BTNDecreaseLetters.BackColor = System.Drawing.Color.Transparent;
            this.BTNDecreaseLetters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNDecreaseLetters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDecreaseLetters.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDecreaseLetters.ForeColor = System.Drawing.Color.Gray;
            this.BTNDecreaseLetters.Location = new System.Drawing.Point(30, 368);
            this.BTNDecreaseLetters.Name = "BTNDecreaseLetters";
            this.BTNDecreaseLetters.Size = new System.Drawing.Size(55, 42);
            this.BTNDecreaseLetters.TabIndex = 24;
            this.BTNDecreaseLetters.Text = "A-";
            this.BTNDecreaseLetters.UseVisualStyleBackColor = false;
            this.BTNDecreaseLetters.Click += new System.EventHandler(this.BTNDecreaseLettersClick);
            // 
            // BTNIncreaseLetters
            // 
            this.BTNIncreaseLetters.BackColor = System.Drawing.Color.Transparent;
            this.BTNIncreaseLetters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNIncreaseLetters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNIncreaseLetters.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNIncreaseLetters.ForeColor = System.Drawing.Color.Gray;
            this.BTNIncreaseLetters.Location = new System.Drawing.Point(128, 368);
            this.BTNIncreaseLetters.Name = "BTNIncreaseLetters";
            this.BTNIncreaseLetters.Size = new System.Drawing.Size(55, 42);
            this.BTNIncreaseLetters.TabIndex = 23;
            this.BTNIncreaseLetters.Text = "A+";
            this.BTNIncreaseLetters.UseVisualStyleBackColor = false;
            this.BTNIncreaseLetters.Click += new System.EventHandler(this.BTNIncreaseLettersClick);
            // 
            // RTBWriteZone
            // 
            this.RTBWriteZone.BackColor = System.Drawing.Color.Gray;
            this.RTBWriteZone.EnableAutoDragDrop = true;
            this.RTBWriteZone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBWriteZone.ForeColor = System.Drawing.Color.Black;
            this.RTBWriteZone.Location = new System.Drawing.Point(254, 1);
            this.RTBWriteZone.Name = "RTBWriteZone";
            this.RTBWriteZone.ReadOnly = true;
            this.RTBWriteZone.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.RTBWriteZone.Size = new System.Drawing.Size(878, 532);
            this.RTBWriteZone.TabIndex = 17;
            this.RTBWriteZone.Text = "";
            this.RTBWriteZone.TextChanged += new System.EventHandler(this.RTBWriteZone_TextChanged);
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComment.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.ForeColor = System.Drawing.Color.Gray;
            this.txtComment.Location = new System.Drawing.Point(3, 3);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComment.Size = new System.Drawing.Size(316, 194);
            this.txtComment.TabIndex = 25;
            this.txtComment.Text = "Déjale un comentario al autor";
            this.txtComment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtComment.Click += new System.EventHandler(this.txtComment_Click);
            // 
            // BTNSendComment
            // 
            this.BTNSendComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNSendComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSendComment.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSendComment.ForeColor = System.Drawing.Color.Gray;
            this.BTNSendComment.Location = new System.Drawing.Point(9, 203);
            this.BTNSendComment.Name = "BTNSendComment";
            this.BTNSendComment.Size = new System.Drawing.Size(310, 39);
            this.BTNSendComment.TabIndex = 26;
            this.BTNSendComment.Text = "Enviar";
            this.BTNSendComment.UseVisualStyleBackColor = true;
            this.BTNSendComment.Click += new System.EventHandler(this.BTNSendComment_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txtcomments);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 309);
            this.panel1.TabIndex = 27;
            // 
            // txtcomments
            // 
            this.txtcomments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtcomments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcomments.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtcomments.ForeColor = System.Drawing.Color.Black;
            this.txtcomments.Location = new System.Drawing.Point(3, 37);
            this.txtcomments.Multiline = true;
            this.txtcomments.Name = "txtcomments";
            this.txtcomments.ReadOnly = true;
            this.txtcomments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtcomments.Size = new System.Drawing.Size(307, 269);
            this.txtcomments.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(61, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 33);
            this.label2.TabIndex = 17;
            this.label2.Text = "Zona de comentarios";
            this.label2.UseMnemonic = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CalificacionCB
            // 
            this.CalificacionCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CalificacionCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalificacionCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalificacionCB.ForeColor = System.Drawing.Color.Gray;
            this.CalificacionCB.FormattingEnabled = true;
            this.CalificacionCB.ItemHeight = 20;
            this.CalificacionCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CalificacionCB.Location = new System.Drawing.Point(82, 618);
            this.CalificacionCB.Name = "CalificacionCB";
            this.CalificacionCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CalificacionCB.Size = new System.Drawing.Size(154, 28);
            this.CalificacionCB.TabIndex = 29;
            this.CalificacionCB.Text = "0";
            // 
            // calificarlabel
            // 
            this.calificarlabel.AutoSize = true;
            this.calificarlabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calificarlabel.ForeColor = System.Drawing.Color.Gray;
            this.calificarlabel.Location = new System.Drawing.Point(39, 577);
            this.calificarlabel.Name = "calificarlabel";
            this.calificarlabel.Size = new System.Drawing.Size(250, 22);
            this.calificarlabel.TabIndex = 28;
            this.calificarlabel.Text = "Califica esta historia: ";
            this.calificarlabel.UseMnemonic = false;
            // 
            // calificarbtn
            // 
            this.calificarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calificarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calificarbtn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calificarbtn.ForeColor = System.Drawing.Color.Gray;
            this.calificarbtn.Location = new System.Drawing.Point(21, 692);
            this.calificarbtn.Name = "calificarbtn";
            this.calificarbtn.Size = new System.Drawing.Size(295, 50);
            this.calificarbtn.TabIndex = 30;
            this.calificarbtn.Text = "Calificar";
            this.calificarbtn.UseVisualStyleBackColor = true;
            this.calificarbtn.Click += new System.EventHandler(this.calificarbtn_Click);
            // 
            // flagLabel
            // 
            this.flagLabel.AutoSize = true;
            this.flagLabel.BackColor = System.Drawing.Color.Transparent;
            this.flagLabel.ForeColor = System.Drawing.Color.Black;
            this.flagLabel.Location = new System.Drawing.Point(1119, 775);
            this.flagLabel.Name = "flagLabel";
            this.flagLabel.Size = new System.Drawing.Size(13, 13);
            this.flagLabel.TabIndex = 31;
            this.flagLabel.Text = "0";
            this.flagLabel.Visible = false;
            // 
            // GBRecommend
            // 
            this.GBRecommend.Controls.Add(this.PNRecommends);
            this.GBRecommend.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.GBRecommend.ForeColor = System.Drawing.Color.Black;
            this.GBRecommend.Location = new System.Drawing.Point(254, 539);
            this.GBRecommend.Name = "GBRecommend";
            this.GBRecommend.Size = new System.Drawing.Size(878, 237);
            this.GBRecommend.TabIndex = 32;
            this.GBRecommend.TabStop = false;
            this.GBRecommend.Text = "Te recomendamos";
            this.GBRecommend.Enter += new System.EventHandler(this.GBRecommend_Enter);
            // 
            // PNRecommends
            // 
            this.PNRecommends.AutoScroll = true;
            this.PNRecommends.Controls.Add(this.button2);
            this.PNRecommends.Controls.Add(this.pictureBox2);
            this.PNRecommends.Controls.Add(this.pictureBox1);
            this.PNRecommends.Controls.Add(this.button1);
            this.PNRecommends.Location = new System.Drawing.Point(8, 25);
            this.PNRecommends.Name = "PNRecommends";
            this.PNRecommends.Size = new System.Drawing.Size(781, 198);
            this.PNRecommends.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(209, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(209, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 138);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 138);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.GBDetails);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 787);
            this.panel2.TabIndex = 33;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(41, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(164, 209);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.txtComment);
            this.panel3.Controls.Add(this.BTNSendComment);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.calificarlabel);
            this.panel3.Controls.Add(this.CalificacionCB);
            this.panel3.Controls.Add(this.calificarbtn);
            this.panel3.Location = new System.Drawing.Point(1138, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 787);
            this.panel3.TabIndex = 34;
            // 
            // FRMReadZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1475, 788);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flagLabel);
            this.Controls.Add(this.GBRecommend);
            this.Controls.Add(this.RTBWriteZone);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMReadZone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.FRMWrite_Load);
            this.GBDetails.ResumeLayout(false);
            this.GBDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GBRecommend.ResumeLayout(false);
            this.PNRecommends.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.Button BTNNextChapter;
        private System.Windows.Forms.GroupBox GBDetails;
        private System.Windows.Forms.RichTextBox RTBWriteZone;
        public System.Windows.Forms.Label lblStoryName;
        public System.Windows.Forms.Label lblCapitulo;
        private System.Windows.Forms.Button BTNDecreaseLetters;
        private System.Windows.Forms.Button BTNIncreaseLetters;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button BTNSendComment;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcomments;
        private System.Windows.Forms.Button BTNBack;
        private System.Windows.Forms.ComboBox CalificacionCB;
        private System.Windows.Forms.Label calificarlabel;
        private System.Windows.Forms.Button calificarbtn;
        private System.Windows.Forms.Label flagLabel;
        private System.Windows.Forms.GroupBox GBRecommend;
        private System.Windows.Forms.Panel PNRecommends;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
    }
}