namespace MailboxCUCEI
{
    partial class FRMInbox
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
            this.BTNCont = new System.Windows.Forms.Button();
            this.LBLUser = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.TXTMessange = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNCont
            // 
            this.BTNCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCont.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTNCont.Location = new System.Drawing.Point(467, 299);
            this.BTNCont.Name = "BTNCont";
            this.BTNCont.Size = new System.Drawing.Size(101, 67);
            this.BTNCont.TabIndex = 2;
            this.BTNCont.Text = "Enviar";
            this.BTNCont.UseVisualStyleBackColor = true;
            this.BTNCont.Click += new System.EventHandler(this.BTNContClick);
            // 
            // LBLUser
            // 
            this.LBLUser.AutoSize = true;
            this.LBLUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUser.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LBLUser.Location = new System.Drawing.Point(12, 12);
            this.LBLUser.Name = "LBLUser";
            this.LBLUser.Size = new System.Drawing.Size(63, 20);
            this.LBLUser.TabIndex = 7;
            this.LBLUser.Text = "Usuario";
            this.LBLUser.Click += new System.EventHandler(this.Label1Click);
            // 
            // BtnBack
            // 
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnBack.Location = new System.Drawing.Point(477, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(97, 36);
            this.BtnBack.TabIndex = 8;
            this.BtnBack.Text = "Volver";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBackClick);
            // 
            // TXTMessange
            // 
            this.TXTMessange.BackColor = System.Drawing.Color.Black;
            this.TXTMessange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTMessange.Location = new System.Drawing.Point(16, 299);
            this.TXTMessange.Multiline = true;
            this.TXTMessange.Name = "TXTMessange";
            this.TXTMessange.Size = new System.Drawing.Size(445, 67);
            this.TXTMessange.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hola amigito";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 238);
            this.panel1.TabIndex = 11;
            // 
            // FRMInbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(583, 378);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TXTMessange);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BTNCont);
            this.Controls.Add(this.LBLUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMInbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.FRMPreWri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTNCont;
        private System.Windows.Forms.Label LBLUser;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.TextBox TXTMessange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}