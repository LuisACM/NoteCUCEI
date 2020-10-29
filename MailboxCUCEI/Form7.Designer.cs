namespace MailboxCUCEI
{
    partial class FRMWrite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMWrite));
            this.BTNSalir = new System.Windows.Forms.Button();
            this.BTNPublish = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.GBDetails = new System.Windows.Forms.GroupBox();
            this.lblStoryName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblraiting = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBLGenero = new System.Windows.Forms.Label();
            this.LBLQuest = new System.Windows.Forms.Label();
            this.RTBWriteZone = new System.Windows.Forms.RichTextBox();
            this.BTNAlignLeft = new System.Windows.Forms.Button();
            this.BTNAlignRight = new System.Windows.Forms.Button();
            this.BTNAlignCenter = new System.Windows.Forms.Button();
            this.BTNUnderline = new System.Windows.Forms.Button();
            this.BTNNegritas = new System.Windows.Forms.Button();
            this.BTNItalic = new System.Windows.Forms.Button();
            this.BTNIncreaseLetters = new System.Windows.Forms.Button();
            this.BTNDecreaseLetters = new System.Windows.Forms.Button();
            this.GBDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNSalir
            // 
            this.BTNSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSalir.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTNSalir.Location = new System.Drawing.Point(24, 403);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(53, 26);
            this.BTNSalir.TabIndex = 2;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // BTNPublish
            // 
            this.BTNPublish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNPublish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPublish.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTNPublish.Location = new System.Drawing.Point(83, 403);
            this.BTNPublish.Name = "BTNPublish";
            this.BTNPublish.Size = new System.Drawing.Size(89, 26);
            this.BTNPublish.TabIndex = 15;
            this.BTNPublish.Text = "Publicar";
            this.BTNPublish.UseVisualStyleBackColor = true;
            this.BTNPublish.Click += new System.EventHandler(this.BTNPublish_Click);
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
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.DimGray;
            this.txtTitle.Location = new System.Drawing.Point(335, 26);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(433, 20);
            this.txtTitle.TabIndex = 8;
            this.txtTitle.Text = "Título";
            this.txtTitle.TextChanged += new System.EventHandler(this.TxtCodigoModificarTextChanged);
            // 
            // GBDetails
            // 
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
            this.GBDetails.Size = new System.Drawing.Size(261, 188);
            this.GBDetails.TabIndex = 16;
            this.GBDetails.TabStop = false;
            this.GBDetails.Text = "groupBox1";
            // 
            // lblStoryName
            // 
            this.lblStoryName.AutoSize = true;
            this.lblStoryName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoryName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblStoryName.Location = new System.Drawing.Point(84, 26);
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
            this.label4.Location = new System.Drawing.Point(9, 139);
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
            this.lblstatus.Location = new System.Drawing.Point(84, 139);
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
            this.label1.Location = new System.Drawing.Point(6, 98);
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
            this.lblraiting.Location = new System.Drawing.Point(84, 98);
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
            this.label2.Location = new System.Drawing.Point(6, 63);
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
            this.LBLGenero.Location = new System.Drawing.Point(84, 63);
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
            this.LBLQuest.Location = new System.Drawing.Point(6, 26);
            this.LBLQuest.Name = "LBLQuest";
            this.LBLQuest.Size = new System.Drawing.Size(61, 20);
            this.LBLQuest.TabIndex = 8;
            this.LBLQuest.Text = "Historía";
            this.LBLQuest.UseMnemonic = false;
            // 
            // RTBWriteZone
            // 
            this.RTBWriteZone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.RTBWriteZone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBWriteZone.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RTBWriteZone.Location = new System.Drawing.Point(335, 121);
            this.RTBWriteZone.Name = "RTBWriteZone";
            this.RTBWriteZone.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTBWriteZone.Size = new System.Drawing.Size(433, 304);
            this.RTBWriteZone.TabIndex = 17;
            this.RTBWriteZone.Text = "¡Escribe aquí!";
            // 
            // BTNAlignLeft
            // 
            this.BTNAlignLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BTNAlignLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNAlignLeft.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTNAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("BTNAlignLeft.Image")));
            this.BTNAlignLeft.Location = new System.Drawing.Point(335, 90);
            this.BTNAlignLeft.Name = "BTNAlignLeft";
            this.BTNAlignLeft.Size = new System.Drawing.Size(25, 25);
            this.BTNAlignLeft.TabIndex = 1;
            this.BTNAlignLeft.UseVisualStyleBackColor = false;
            this.BTNAlignLeft.Click += new System.EventHandler(this.BTNAlignLeftClick);
            // 
            // BTNAlignRight
            // 
            this.BTNAlignRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BTNAlignRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNAlignRight.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTNAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("BTNAlignRight.Image")));
            this.BTNAlignRight.Location = new System.Drawing.Point(397, 90);
            this.BTNAlignRight.Name = "BTNAlignRight";
            this.BTNAlignRight.Size = new System.Drawing.Size(25, 25);
            this.BTNAlignRight.TabIndex = 18;
            this.BTNAlignRight.UseVisualStyleBackColor = false;
            this.BTNAlignRight.Click += new System.EventHandler(this.BTNAlignRightClick);
            // 
            // BTNAlignCenter
            // 
            this.BTNAlignCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BTNAlignCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNAlignCenter.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTNAlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("BTNAlignCenter.Image")));
            this.BTNAlignCenter.Location = new System.Drawing.Point(366, 90);
            this.BTNAlignCenter.Name = "BTNAlignCenter";
            this.BTNAlignCenter.Size = new System.Drawing.Size(25, 25);
            this.BTNAlignCenter.TabIndex = 19;
            this.BTNAlignCenter.UseVisualStyleBackColor = false;
            this.BTNAlignCenter.Click += new System.EventHandler(this.BTNAlignCenterClick);
            // 
            // BTNUnderline
            // 
            this.BTNUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BTNUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNUnderline.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTNUnderline.Location = new System.Drawing.Point(428, 90);
            this.BTNUnderline.Name = "BTNUnderline";
            this.BTNUnderline.Size = new System.Drawing.Size(25, 25);
            this.BTNUnderline.TabIndex = 20;
            this.BTNUnderline.Text = "U";
            this.BTNUnderline.UseVisualStyleBackColor = false;
            this.BTNUnderline.Click += new System.EventHandler(this.BTNUnderlineClick);
            // 
            // BTNNegritas
            // 
            this.BTNNegritas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BTNNegritas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNNegritas.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTNNegritas.Location = new System.Drawing.Point(459, 90);
            this.BTNNegritas.Name = "BTNNegritas";
            this.BTNNegritas.Size = new System.Drawing.Size(25, 25);
            this.BTNNegritas.TabIndex = 21;
            this.BTNNegritas.Text = "B";
            this.BTNNegritas.UseVisualStyleBackColor = false;
            this.BTNNegritas.Click += new System.EventHandler(this.BTNNegritasClick);
            // 
            // BTNItalic
            // 
            this.BTNItalic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BTNItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNItalic.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTNItalic.Location = new System.Drawing.Point(490, 90);
            this.BTNItalic.Name = "BTNItalic";
            this.BTNItalic.Size = new System.Drawing.Size(25, 25);
            this.BTNItalic.TabIndex = 22;
            this.BTNItalic.Text = "I";
            this.BTNItalic.UseVisualStyleBackColor = false;
            this.BTNItalic.Click += new System.EventHandler(this.BTNItalicClick);
            // 
            // BTNIncreaseLetters
            // 
            this.BTNIncreaseLetters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BTNIncreaseLetters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNIncreaseLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNIncreaseLetters.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTNIncreaseLetters.Location = new System.Drawing.Point(521, 90);
            this.BTNIncreaseLetters.Name = "BTNIncreaseLetters";
            this.BTNIncreaseLetters.Size = new System.Drawing.Size(25, 25);
            this.BTNIncreaseLetters.TabIndex = 23;
            this.BTNIncreaseLetters.Text = "A+";
            this.BTNIncreaseLetters.UseVisualStyleBackColor = false;
            this.BTNIncreaseLetters.Click += new System.EventHandler(this.BTNIncreaseLettersClick);
            // 
            // BTNDecreaseLetters
            // 
            this.BTNDecreaseLetters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BTNDecreaseLetters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDecreaseLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDecreaseLetters.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTNDecreaseLetters.Location = new System.Drawing.Point(552, 90);
            this.BTNDecreaseLetters.Name = "BTNDecreaseLetters";
            this.BTNDecreaseLetters.Size = new System.Drawing.Size(25, 25);
            this.BTNDecreaseLetters.TabIndex = 24;
            this.BTNDecreaseLetters.Text = "A-";
            this.BTNDecreaseLetters.UseVisualStyleBackColor = false;
            this.BTNDecreaseLetters.Click += new System.EventHandler(this.BTNDecreaseLettersClick);
            // 
            // FRMWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.BTNDecreaseLetters);
            this.Controls.Add(this.BTNIncreaseLetters);
            this.Controls.Add(this.BTNItalic);
            this.Controls.Add(this.BTNNegritas);
            this.Controls.Add(this.BTNUnderline);
            this.Controls.Add(this.BTNAlignCenter);
            this.Controls.Add(this.BTNAlignRight);
            this.Controls.Add(this.RTBWriteZone);
            this.Controls.Add(this.GBDetails);
            this.Controls.Add(this.BTNPublish);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.BTNAlignLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMWrite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.FRMWrite_Load);
            this.GBDetails.ResumeLayout(false);
            this.GBDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNAlignLeft;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNPublish;
        private System.Windows.Forms.GroupBox GBDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBLQuest;
        private System.Windows.Forms.RichTextBox RTBWriteZone;
        private System.Windows.Forms.Button BTNAlignRight;
        private System.Windows.Forms.Button BTNAlignCenter;
        private System.Windows.Forms.Button BTNUnderline;
        private System.Windows.Forms.Button BTNNegritas;
        private System.Windows.Forms.Button BTNItalic;
        private System.Windows.Forms.Button BTNIncreaseLetters;
        private System.Windows.Forms.Button BTNDecreaseLetters;
        public System.Windows.Forms.Label lblstatus;
        public System.Windows.Forms.Label lblraiting;
        public System.Windows.Forms.Label LBLGenero;
        public System.Windows.Forms.Label lblStoryName;
    }
}