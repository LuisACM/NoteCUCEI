﻿namespace MailboxCUCEI
{
    partial class FRMCreateStory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMCreateStory));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTSummary = new System.Windows.Forms.TextBox();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.BTNSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBGender1 = new System.Windows.Forms.ComboBox();
            this.LBLQuest = new System.Windows.Forms.Label();
            this.CBGender2 = new System.Windows.Forms.ComboBox();
            this.CBRaiting = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBEstatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PBCover = new System.Windows.Forms.PictureBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PBCover)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa los datos de tu historia.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(277, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 2);
            this.label2.TabIndex = 5;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // TXTSummary
            // 
            this.TXTSummary.BackColor = System.Drawing.Color.Gray;
            this.TXTSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTSummary.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTSummary.ForeColor = System.Drawing.Color.Black;
            this.TXTSummary.HideSelection = false;
            this.TXTSummary.Location = new System.Drawing.Point(277, 170);
            this.TXTSummary.MaximumSize = new System.Drawing.Size(433, 184);
            this.TXTSummary.Multiline = true;
            this.TXTSummary.Name = "TXTSummary";
            this.TXTSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXTSummary.Size = new System.Drawing.Size(433, 184);
            this.TXTSummary.TabIndex = 2;
            this.TXTSummary.Text = "Escribe aqui una pequeña descripción de tu obra.";
            this.TXTSummary.Click += new System.EventHandler(this.TXTSummaryTextChanged);
            this.TXTSummary.TextChanged += new System.EventHandler(this.TXTSummaryTextChanged);
            // 
            // BTNSalir
            // 
            this.BTNSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTNSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSalir.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSalir.ForeColor = System.Drawing.Color.Black;
            this.BTNSalir.Location = new System.Drawing.Point(345, 18);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(150, 36);
            this.BTNSalir.TabIndex = 1;
            this.BTNSalir.Text = "Cancelar";
            this.BTNSalir.UseVisualStyleBackColor = false;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // BTNSend
            // 
            this.BTNSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTNSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSend.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSend.ForeColor = System.Drawing.Color.Black;
            this.BTNSend.Location = new System.Drawing.Point(501, 18);
            this.BTNSend.Name = "BTNSend";
            this.BTNSend.Size = new System.Drawing.Size(150, 36);
            this.BTNSend.TabIndex = 0;
            this.BTNSend.Text = "Continuar";
            this.BTNSend.UseVisualStyleBackColor = false;
            this.BTNSend.Click += new System.EventHandler(this.BTNSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(263, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 6;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.Gray;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.Black;
            this.txtnombre.Location = new System.Drawing.Point(278, 43);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(437, 19);
            this.txtnombre.TabIndex = 7;
            this.txtnombre.Text = "Nombre";
            this.txtnombre.Click += new System.EventHandler(this.TxtnombreTextChanged);
            this.txtnombre.TextChanged += new System.EventHandler(this.TxtnombreTextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(278, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(450, 2);
            this.label4.TabIndex = 8;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // CBGender1
            // 
            this.CBGender1.BackColor = System.Drawing.Color.Gray;
            this.CBGender1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBGender1.ForeColor = System.Drawing.Color.Black;
            this.CBGender1.FormattingEnabled = true;
            this.CBGender1.ItemHeight = 13;
            this.CBGender1.Location = new System.Drawing.Point(345, 85);
            this.CBGender1.Name = "CBGender1";
            this.CBGender1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CBGender1.Size = new System.Drawing.Size(182, 21);
            this.CBGender1.TabIndex = 11;
            this.CBGender1.SelectedIndexChanged += new System.EventHandler(this.CBGender1_SelectedIndexChanged);
            // 
            // LBLQuest
            // 
            this.LBLQuest.AutoSize = true;
            this.LBLQuest.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLQuest.ForeColor = System.Drawing.Color.Black;
            this.LBLQuest.Location = new System.Drawing.Point(278, 85);
            this.LBLQuest.Name = "LBLQuest";
            this.LBLQuest.Size = new System.Drawing.Size(64, 18);
            this.LBLQuest.TabIndex = 10;
            this.LBLQuest.Text = "Generos";
            this.LBLQuest.UseMnemonic = false;
            // 
            // CBGender2
            // 
            this.CBGender2.BackColor = System.Drawing.Color.Gray;
            this.CBGender2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBGender2.ForeColor = System.Drawing.Color.Black;
            this.CBGender2.FormattingEnabled = true;
            this.CBGender2.ItemHeight = 13;
            this.CBGender2.Location = new System.Drawing.Point(533, 85);
            this.CBGender2.Name = "CBGender2";
            this.CBGender2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CBGender2.Size = new System.Drawing.Size(182, 21);
            this.CBGender2.TabIndex = 12;
            // 
            // CBRaiting
            // 
            this.CBRaiting.BackColor = System.Drawing.Color.Gray;
            this.CBRaiting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBRaiting.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBRaiting.ForeColor = System.Drawing.Color.Black;
            this.CBRaiting.FormattingEnabled = true;
            this.CBRaiting.ItemHeight = 19;
            this.CBRaiting.Items.AddRange(new object[] {
            "K",
            "K+",
            "M",
            "T"});
            this.CBRaiting.Location = new System.Drawing.Point(396, 124);
            this.CBRaiting.Name = "CBRaiting";
            this.CBRaiting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CBRaiting.Size = new System.Drawing.Size(114, 27);
            this.CBRaiting.TabIndex = 14;
            this.CBRaiting.Text = "K";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(278, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Clasificación";
            this.label5.UseMnemonic = false;
            // 
            // CBEstatus
            // 
            this.CBEstatus.BackColor = System.Drawing.Color.Gray;
            this.CBEstatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBEstatus.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBEstatus.ForeColor = System.Drawing.Color.Black;
            this.CBEstatus.FormattingEnabled = true;
            this.CBEstatus.ItemHeight = 18;
            this.CBEstatus.Items.AddRange(new object[] {
            "Incompleto",
            "Completo"});
            this.CBEstatus.Location = new System.Drawing.Point(597, 125);
            this.CBEstatus.Name = "CBEstatus";
            this.CBEstatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CBEstatus.Size = new System.Drawing.Size(118, 26);
            this.CBEstatus.TabIndex = 16;
            this.CBEstatus.Text = "Incompleto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(533, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Estatus";
            this.label6.UseMnemonic = false;
            // 
            // PBCover
            // 
            this.PBCover.Location = new System.Drawing.Point(12, 13);
            this.PBCover.Name = "PBCover";
            this.PBCover.Size = new System.Drawing.Size(245, 346);
            this.PBCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBCover.TabIndex = 18;
            this.PBCover.TabStop = false;
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.ForeColor = System.Drawing.Color.Black;
            this.btnImage.Location = new System.Drawing.Point(47, 17);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(172, 36);
            this.btnImage.TabIndex = 19;
            this.btnImage.Text = "Cargar portada";
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.BtnImageClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnImage);
            this.panel1.Controls.Add(this.BTNSalir);
            this.panel1.Controls.Add(this.BTNSend);
            this.panel1.Location = new System.Drawing.Point(0, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 73);
            this.panel1.TabIndex = 20;
            // 
            // FRMCreateStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(735, 449);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PBCover);
            this.Controls.Add(this.CBEstatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBRaiting);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBGender2);
            this.Controls.Add(this.CBGender1);
            this.Controls.Add(this.LBLQuest);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTSummary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMCreateStory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.InicioAdminLoad);
            ((System.ComponentModel.ISupportInitialize)(this.PBCover)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTSummary;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.Button BTNSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBGender1;
        private System.Windows.Forms.Label LBLQuest;
        private System.Windows.Forms.ComboBox CBGender2;
        private System.Windows.Forms.ComboBox CBRaiting;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBEstatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox PBCover;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}