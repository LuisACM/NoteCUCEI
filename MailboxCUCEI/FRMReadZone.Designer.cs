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
            this.BTNSalir = new System.Windows.Forms.Button();
            this.BTNNextChapter = new System.Windows.Forms.Button();
            this.GBDetails = new System.Windows.Forms.GroupBox();
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
            this.GBDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNSalir
            // 
            this.BTNSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSalir.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTNSalir.Location = new System.Drawing.Point(366, 48);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(53, 26);
            this.BTNSalir.TabIndex = 2;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // BTNNextChapter
            // 
            this.BTNNextChapter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNNextChapter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNextChapter.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTNNextChapter.Location = new System.Drawing.Point(292, 20);
            this.BTNNextChapter.Name = "BTNNextChapter";
            this.BTNNextChapter.Size = new System.Drawing.Size(137, 26);
            this.BTNNextChapter.TabIndex = 15;
            this.BTNNextChapter.Text = "Siguiente Capitulo";
            this.BTNNextChapter.UseVisualStyleBackColor = true;
            this.BTNNextChapter.Click += new System.EventHandler(this.BTNPublish_Click);
            // 
            // GBDetails
            // 
            this.GBDetails.Controls.Add(this.BTNBack);
            this.GBDetails.Controls.Add(this.lblCapitulo);
            this.GBDetails.Controls.Add(this.lblStoryName);
            this.GBDetails.Controls.Add(this.BTNDecreaseLetters);
            this.GBDetails.Controls.Add(this.BTNNextChapter);
            this.GBDetails.Controls.Add(this.BTNSalir);
            this.GBDetails.Controls.Add(this.BTNIncreaseLetters);
            this.GBDetails.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.GBDetails.ForeColor = System.Drawing.Color.DodgerBlue;
            this.GBDetails.Location = new System.Drawing.Point(13, 13);
            this.GBDetails.Name = "GBDetails";
            this.GBDetails.Size = new System.Drawing.Size(435, 79);
            this.GBDetails.TabIndex = 16;
            this.GBDetails.TabStop = false;
            this.GBDetails.Text = "Estas Leyendo";
            // 
            // BTNBack
            // 
            this.BTNBack.Enabled = false;
            this.BTNBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBack.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTNBack.Location = new System.Drawing.Point(149, 20);
            this.BTNBack.Name = "BTNBack";
            this.BTNBack.Size = new System.Drawing.Size(137, 26);
            this.BTNBack.TabIndex = 26;
            this.BTNBack.Text = "Anterior Capitulo";
            this.BTNBack.UseVisualStyleBackColor = true;
            this.BTNBack.Click += new System.EventHandler(this.BTNBack_Click);
            // 
            // lblCapitulo
            // 
            this.lblCapitulo.AutoSize = true;
            this.lblCapitulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapitulo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCapitulo.Location = new System.Drawing.Point(6, 50);
            this.lblCapitulo.Name = "lblCapitulo";
            this.lblCapitulo.Size = new System.Drawing.Size(71, 20);
            this.lblCapitulo.TabIndex = 25;
            this.lblCapitulo.Text = "Capitulo";
            this.lblCapitulo.UseMnemonic = false;
            // 
            // lblStoryName
            // 
            this.lblStoryName.AutoSize = true;
            this.lblStoryName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoryName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblStoryName.Location = new System.Drawing.Point(6, 22);
            this.lblStoryName.Name = "lblStoryName";
            this.lblStoryName.Size = new System.Drawing.Size(61, 20);
            this.lblStoryName.TabIndex = 16;
            this.lblStoryName.Text = "Historia";
            this.lblStoryName.UseMnemonic = false;
            // 
            // BTNDecreaseLetters
            // 
            this.BTNDecreaseLetters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BTNDecreaseLetters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDecreaseLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDecreaseLetters.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTNDecreaseLetters.Location = new System.Drawing.Point(251, 48);
            this.BTNDecreaseLetters.Name = "BTNDecreaseLetters";
            this.BTNDecreaseLetters.Size = new System.Drawing.Size(25, 25);
            this.BTNDecreaseLetters.TabIndex = 24;
            this.BTNDecreaseLetters.Text = "A-";
            this.BTNDecreaseLetters.UseVisualStyleBackColor = false;
            this.BTNDecreaseLetters.Click += new System.EventHandler(this.BTNDecreaseLettersClick);
            // 
            // BTNIncreaseLetters
            // 
            this.BTNIncreaseLetters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BTNIncreaseLetters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNIncreaseLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNIncreaseLetters.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTNIncreaseLetters.Location = new System.Drawing.Point(207, 48);
            this.BTNIncreaseLetters.Name = "BTNIncreaseLetters";
            this.BTNIncreaseLetters.Size = new System.Drawing.Size(25, 25);
            this.BTNIncreaseLetters.TabIndex = 23;
            this.BTNIncreaseLetters.Text = "A+";
            this.BTNIncreaseLetters.UseVisualStyleBackColor = false;
            this.BTNIncreaseLetters.Click += new System.EventHandler(this.BTNIncreaseLettersClick);
            // 
            // RTBWriteZone
            // 
            this.RTBWriteZone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.RTBWriteZone.EnableAutoDragDrop = true;
            this.RTBWriteZone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBWriteZone.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RTBWriteZone.Location = new System.Drawing.Point(15, 98);
            this.RTBWriteZone.Name = "RTBWriteZone";
            this.RTBWriteZone.ReadOnly = true;
            this.RTBWriteZone.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.RTBWriteZone.Size = new System.Drawing.Size(816, 549);
            this.RTBWriteZone.TabIndex = 17;
            this.RTBWriteZone.Text = "";
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComment.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtComment.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtComment.Location = new System.Drawing.Point(455, 22);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComment.Size = new System.Drawing.Size(460, 70);
            this.txtComment.TabIndex = 25;
            this.txtComment.Text = "¡Dejale un comentario al autor!";
            this.txtComment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtComment.Click += new System.EventHandler(this.txtComment_Click);
            // 
            // BTNSendComment
            // 
            this.BTNSendComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSendComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSendComment.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTNSendComment.Location = new System.Drawing.Point(934, 66);
            this.BTNSendComment.Name = "BTNSendComment";
            this.BTNSendComment.Size = new System.Drawing.Size(68, 26);
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
            this.panel1.Location = new System.Drawing.Point(854, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 309);
            this.panel1.TabIndex = 27;
            // 
            // txtcomments
            // 
            this.txtcomments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtcomments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcomments.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtcomments.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtcomments.Location = new System.Drawing.Point(4, 33);
            this.txtcomments.Multiline = true;
            this.txtcomments.Name = "txtcomments";
            this.txtcomments.ReadOnly = true;
            this.txtcomments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtcomments.Size = new System.Drawing.Size(243, 269);
            this.txtcomments.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(43, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Zona de comentarios";
            this.label2.UseMnemonic = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CalificacionCB
            // 
            this.CalificacionCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CalificacionCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalificacionCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalificacionCB.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CalificacionCB.FormattingEnabled = true;
            this.CalificacionCB.ItemHeight = 20;
            this.CalificacionCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CalificacionCB.Location = new System.Drawing.Point(1011, 450);
            this.CalificacionCB.Name = "CalificacionCB";
            this.CalificacionCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CalificacionCB.Size = new System.Drawing.Size(114, 28);
            this.CalificacionCB.TabIndex = 29;
            this.CalificacionCB.Text = "0";
            // 
            // calificarlabel
            // 
            this.calificarlabel.AutoSize = true;
            this.calificarlabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calificarlabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.calificarlabel.Location = new System.Drawing.Point(837, 453);
            this.calificarlabel.Name = "calificarlabel";
            this.calificarlabel.Size = new System.Drawing.Size(163, 20);
            this.calificarlabel.TabIndex = 28;
            this.calificarlabel.Text = "Califica esta historia: ";
            this.calificarlabel.UseMnemonic = false;
            // 
            // calificarbtn
            // 
            this.calificarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calificarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calificarbtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.calificarbtn.Location = new System.Drawing.Point(925, 495);
            this.calificarbtn.Name = "calificarbtn";
            this.calificarbtn.Size = new System.Drawing.Size(136, 26);
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
            this.flagLabel.Location = new System.Drawing.Point(858, 437);
            this.flagLabel.Name = "flagLabel";
            this.flagLabel.Size = new System.Drawing.Size(13, 13);
            this.flagLabel.TabIndex = 31;
            this.flagLabel.Text = "0";
            this.flagLabel.Visible = false;
            // 
            // FRMReadZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1149, 659);
            this.Controls.Add(this.flagLabel);
            this.Controls.Add(this.calificarbtn);
            this.Controls.Add(this.CalificacionCB);
            this.Controls.Add(this.calificarlabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTNSendComment);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.RTBWriteZone);
            this.Controls.Add(this.GBDetails);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMReadZone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.FRMWrite_Load);
            this.GBDetails.ResumeLayout(false);
            this.GBDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}