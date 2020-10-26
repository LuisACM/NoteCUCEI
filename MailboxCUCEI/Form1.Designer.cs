namespace MailboxCUCEI
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnInicioSesion = new System.Windows.Forms.Button();
            this.LinkLabel = new System.Windows.Forms.LinkLabel();
            this.BTNCerrar = new System.Windows.Forms.PictureBox();
            this.BTNMinimizar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNINVITADO = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 389);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 43);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(220, 297);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(298, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 2);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(298, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 2);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.Color.Black;
            this.TxtUsuario.Location = new System.Drawing.Point(299, 75);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(433, 20);
            this.TxtUsuario.TabIndex = 1;
            this.TxtUsuario.Text = "CODIGO";
            this.TxtUsuario.Enter += new System.EventHandler(this.TxtUsuario_Enter);
            this.TxtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.Black;
            this.TxtPassword.Location = new System.Drawing.Point(299, 122);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(433, 20);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.Text = "CONTRASEÑA";
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // BtnInicioSesion
            // 
            this.BtnInicioSesion.BackColor = System.Drawing.Color.SaddleBrown;
            this.BtnInicioSesion.FlatAppearance.BorderSize = 0;
            this.BtnInicioSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnInicioSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicioSesion.ForeColor = System.Drawing.Color.Black;
            this.BtnInicioSesion.Location = new System.Drawing.Point(299, 195);
            this.BtnInicioSesion.Name = "BtnInicioSesion";
            this.BtnInicioSesion.Size = new System.Drawing.Size(432, 40);
            this.BtnInicioSesion.TabIndex = 3;
            this.BtnInicioSesion.Text = "ENTRAR";
            this.BtnInicioSesion.UseVisualStyleBackColor = false;
            this.BtnInicioSesion.Click += new System.EventHandler(this.BtnInicioSesion_Click);
            // 
            // LinkLabel
            // 
            this.LinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel.ForeColor = System.Drawing.Color.Black;
            this.LinkLabel.LinkColor = System.Drawing.Color.Black;
            this.LinkLabel.Location = new System.Drawing.Point(442, 351);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(158, 17);
            this.LinkLabel.TabIndex = 0;
            this.LinkLabel.TabStop = true;
            this.LinkLabel.Text = "Registrar nuevo usuario";
            this.LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // BTNCerrar
            // 
            this.BTNCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BTNCerrar.Image")));
            this.BTNCerrar.Location = new System.Drawing.Point(754, 0);
            this.BTNCerrar.Name = "BTNCerrar";
            this.BTNCerrar.Size = new System.Drawing.Size(33, 34);
            this.BTNCerrar.TabIndex = 8;
            this.BTNCerrar.TabStop = false;
            this.BTNCerrar.Click += new System.EventHandler(this.BTNCerrar_Click);
            // 
            // BTNMinimizar
            // 
            this.BTNMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BTNMinimizar.Image")));
            this.BTNMinimizar.Location = new System.Drawing.Point(722, 0);
            this.BTNMinimizar.Name = "BTNMinimizar";
            this.BTNMinimizar.Size = new System.Drawing.Size(26, 50);
            this.BTNMinimizar.TabIndex = 9;
            this.BTNMinimizar.TabStop = false;
            this.BTNMinimizar.Click += new System.EventHandler(this.BTNMinimizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(279, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 0;
            // 
            // BTNINVITADO
            // 
            this.BTNINVITADO.BackColor = System.Drawing.Color.SaddleBrown;
            this.BTNINVITADO.FlatAppearance.BorderSize = 0;
            this.BTNINVITADO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTNINVITADO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTNINVITADO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNINVITADO.ForeColor = System.Drawing.Color.Black;
            this.BTNINVITADO.Location = new System.Drawing.Point(299, 287);
            this.BTNINVITADO.Name = "BTNINVITADO";
            this.BTNINVITADO.Size = new System.Drawing.Size(432, 40);
            this.BTNINVITADO.TabIndex = 10;
            this.BTNINVITADO.Text = "ENTRAR COMO INVITADO";
            this.BTNINVITADO.UseVisualStyleBackColor = false;
            this.BTNINVITADO.Click += new System.EventHandler(this.BTNINVITADO_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "O";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "-------------------------------------------------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "-------------------------------------------------------------------";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(780, 389);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTNINVITADO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTNMinimizar);
            this.Controls.Add(this.BTNCerrar);
            this.Controls.Add(this.LinkLabel);
            this.Controls.Add(this.BtnInicioSesion);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnInicioSesion;
        private System.Windows.Forms.LinkLabel LinkLabel;
        private System.Windows.Forms.PictureBox BTNCerrar;
        private System.Windows.Forms.PictureBox BTNMinimizar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTNINVITADO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}

