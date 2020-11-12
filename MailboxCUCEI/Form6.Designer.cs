namespace MailboxCUCEI
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.FechaNac = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPassPerfil = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCorreoPerfil = new System.Windows.Forms.TextBox();
            this.TxtCodigoPerfil = new System.Windows.Forms.TextBox();
            this.TxtNombrePerfil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.BTNModificar = new System.Windows.Forms.Button();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FechaNac
            // 
            this.FechaNac.CustomFormat = "yyyy-MM-dd";
            this.FechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaNac.Location = new System.Drawing.Point(536, 395);
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.Size = new System.Drawing.Size(86, 20);
            this.FechaNac.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(268, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 20);
            this.label9.TabIndex = 57;
            this.label9.Text = "FECHA DE NACIMIENTO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(267, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "CONTRASEÑA";
            // 
            // TxtPassPerfil
            // 
            this.TxtPassPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TxtPassPerfil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassPerfil.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtPassPerfil.Location = new System.Drawing.Point(419, 296);
            this.TxtPassPerfil.Name = "TxtPassPerfil";
            this.TxtPassPerfil.Size = new System.Drawing.Size(433, 19);
            this.TxtPassPerfil.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(418, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(433, 2);
            this.label8.TabIndex = 55;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(265, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "CORREO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(265, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "CODIGO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(268, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "NOMBRE";
            // 
            // TxtCorreoPerfil
            // 
            this.TxtCorreoPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TxtCorreoPerfil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCorreoPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreoPerfil.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtCorreoPerfil.Location = new System.Drawing.Point(418, 204);
            this.TxtCorreoPerfil.Name = "TxtCorreoPerfil";
            this.TxtCorreoPerfil.Size = new System.Drawing.Size(433, 19);
            this.TxtCorreoPerfil.TabIndex = 45;
            // 
            // TxtCodigoPerfil
            // 
            this.TxtCodigoPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TxtCodigoPerfil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCodigoPerfil.Enabled = false;
            this.TxtCodigoPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoPerfil.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtCodigoPerfil.Location = new System.Drawing.Point(416, 45);
            this.TxtCodigoPerfil.Name = "TxtCodigoPerfil";
            this.TxtCodigoPerfil.Size = new System.Drawing.Size(433, 19);
            this.TxtCodigoPerfil.TabIndex = 46;
            // 
            // TxtNombrePerfil
            // 
            this.TxtNombrePerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TxtNombrePerfil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombrePerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombrePerfil.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtNombrePerfil.Location = new System.Drawing.Point(418, 125);
            this.TxtNombrePerfil.Name = "TxtNombrePerfil";
            this.TxtNombrePerfil.Size = new System.Drawing.Size(433, 19);
            this.TxtNombrePerfil.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(417, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(433, 2);
            this.label4.TabIndex = 50;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(417, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 2);
            this.label3.TabIndex = 49;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(418, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 2);
            this.label2.TabIndex = 47;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // BTNSalir
            // 
            this.BTNSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSalir.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTNSalir.Location = new System.Drawing.Point(23, 572);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(180, 50);
            this.BTNSalir.TabIndex = 44;
            this.BTNSalir.Text = "SALIR";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click_1);
            // 
            // BTNModificar
            // 
            this.BTNModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNModificar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTNModificar.Location = new System.Drawing.Point(23, 27);
            this.BTNModificar.Name = "BTNModificar";
            this.BTNModificar.Size = new System.Drawing.Size(180, 45);
            this.BTNModificar.TabIndex = 43;
            this.BTNModificar.Text = "MODIFICAR";
            this.BTNModificar.UseVisualStyleBackColor = true;
            this.BTNModificar.Click += new System.EventHandler(this.BTNModificar_Click);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNEliminar.ForeColor = System.Drawing.Color.Red;
            this.BTNEliminar.Location = new System.Drawing.Point(23, 505);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(180, 50);
            this.BTNEliminar.TabIndex = 42;
            this.BTNEliminar.Text = "ELIMINAR MI CUENTA";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click_1);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(947, 695);
            this.Controls.Add(this.FechaNac);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtPassPerfil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCorreoPerfil);
            this.Controls.Add(this.TxtCodigoPerfil);
            this.Controls.Add(this.TxtNombrePerfil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.BTNModificar);
            this.Controls.Add(this.BTNEliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FechaNac;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPassPerfil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCorreoPerfil;
        private System.Windows.Forms.TextBox TxtNombrePerfil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.Button BTNModificar;
        private System.Windows.Forms.Button BTNEliminar;
        public System.Windows.Forms.TextBox TxtCodigoPerfil;
    }
}