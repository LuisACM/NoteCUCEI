namespace MailboxCUCEI
{
    partial class FRMPreWri
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
            this.BTNNewSto = new System.Windows.Forms.Button();
            this.BTNCont = new System.Windows.Forms.Button();
            this.LBLQuest = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNNewSto
            // 
            this.BTNNewSto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNNewSto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNewSto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BTNNewSto.Location = new System.Drawing.Point(51, 16);
            this.BTNNewSto.Name = "BTNNewSto";
            this.BTNNewSto.Size = new System.Drawing.Size(150, 36);
            this.BTNNewSto.TabIndex = 0;
            this.BTNNewSto.Text = "Nueva historia";
            this.BTNNewSto.UseVisualStyleBackColor = true;
            this.BTNNewSto.Click += new System.EventHandler(this.BTNNewStoClick);
            // 
            // BTNCont
            // 
            this.BTNCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCont.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BTNCont.Location = new System.Drawing.Point(270, 16);
            this.BTNCont.Name = "BTNCont";
            this.BTNCont.Size = new System.Drawing.Size(151, 36);
            this.BTNCont.TabIndex = 2;
            this.BTNCont.Text = "Continuar";
            this.BTNCont.UseVisualStyleBackColor = true;
            this.BTNCont.Click += new System.EventHandler(this.BTNContClick);
            // 
            // LBLQuest
            // 
            this.LBLQuest.AutoSize = true;
            this.LBLQuest.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLQuest.ForeColor = System.Drawing.Color.Black;
            this.LBLQuest.Location = new System.Drawing.Point(12, 21);
            this.LBLQuest.Name = "LBLQuest";
            this.LBLQuest.Size = new System.Drawing.Size(620, 22);
            this.LBLQuest.TabIndex = 7;
            this.LBLQuest.Text = "¿Desea publicar una nueva historia o continuar otra historia?";
            this.LBLQuest.Click += new System.EventHandler(this.Label1Click);
            // 
            // BtnBack
            // 
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnBack.Location = new System.Drawing.Point(509, 16);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(97, 36);
            this.BtnBack.TabIndex = 8;
            this.BtnBack.Text = "Volver";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBackClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.BtnBack);
            this.panel1.Controls.Add(this.BTNCont);
            this.panel1.Controls.Add(this.BTNNewSto);
            this.panel1.Location = new System.Drawing.Point(-3, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 66);
            this.panel1.TabIndex = 9;
            // 
            // FRMPreWri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(650, 137);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LBLQuest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMPreWri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.FRMPreWri_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNNewSto;
        private System.Windows.Forms.Button BTNCont;
        private System.Windows.Forms.Label LBLQuest;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Panel panel1;
    }
}