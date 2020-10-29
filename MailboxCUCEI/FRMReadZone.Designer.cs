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
            this.lblCapitulo = new System.Windows.Forms.Label();
            this.lblStoryName = new System.Windows.Forms.Label();
            this.BTNDecreaseLetters = new System.Windows.Forms.Button();
            this.BTNIncreaseLetters = new System.Windows.Forms.Button();
            this.RTBWriteZone = new System.Windows.Forms.RichTextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.BTNSendComment = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.RTBWriteZone.Size = new System.Drawing.Size(816, 417);
            this.RTBWriteZone.TabIndex = 17;
            this.RTBWriteZone.Text = "";
            // 
            // txtComment
            // 
            this.txtComment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
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
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(854, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 416);
            this.panel1.TabIndex = 27;
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Zona de comentarios";
            this.label1.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Zona de comentarios";
            this.label3.UseMnemonic = false;
            // 
            // FRMReadZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1115, 527);
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
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
    }
}