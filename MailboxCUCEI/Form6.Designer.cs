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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridAdmin = new System.Windows.Forms.DataGridView();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.BTNModificar = new System.Windows.Forms.Button();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.BTNRefrescar = new System.Windows.Forms.Button();
            this.BTNRespaldo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridAdmin
            // 
            this.DataGridAdmin.AllowUserToAddRows = false;
            this.DataGridAdmin.AllowUserToResizeColumns = false;
            this.DataGridAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.DataGridAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridAdmin.EnableHeadersVisualStyles = false;
            this.DataGridAdmin.GridColor = System.Drawing.Color.DodgerBlue;
            this.DataGridAdmin.Location = new System.Drawing.Point(285, 12);
            this.DataGridAdmin.Name = "DataGridAdmin";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridAdmin.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.DataGridAdmin.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridAdmin.Size = new System.Drawing.Size(605, 398);
            this.DataGridAdmin.TabIndex = 0;
            this.DataGridAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridAdmin_CellContentClick);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNEliminar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTNEliminar.Location = new System.Drawing.Point(27, 12);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(180, 50);
            this.BTNEliminar.TabIndex = 1;
            this.BTNEliminar.Text = "ELIMINAR";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // BTNModificar
            // 
            this.BTNModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNModificar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTNModificar.Location = new System.Drawing.Point(27, 83);
            this.BTNModificar.Name = "BTNModificar";
            this.BTNModificar.Size = new System.Drawing.Size(180, 45);
            this.BTNModificar.TabIndex = 2;
            this.BTNModificar.Text = "MODIFICAR";
            this.BTNModificar.UseVisualStyleBackColor = true;
            this.BTNModificar.Click += new System.EventHandler(this.BTNModificar_Click);
            // 
            // BTNSalir
            // 
            this.BTNSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSalir.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTNSalir.Location = new System.Drawing.Point(27, 360);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(180, 50);
            this.BTNSalir.TabIndex = 4;
            this.BTNSalir.Text = "SALIR";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // BTNRefrescar
            // 
            this.BTNRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNRefrescar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTNRefrescar.Location = new System.Drawing.Point(27, 150);
            this.BTNRefrescar.Name = "BTNRefrescar";
            this.BTNRefrescar.Size = new System.Drawing.Size(180, 45);
            this.BTNRefrescar.TabIndex = 5;
            this.BTNRefrescar.Text = "REFRESCAR";
            this.BTNRefrescar.UseVisualStyleBackColor = true;
            this.BTNRefrescar.Click += new System.EventHandler(this.BTNRefrescar_Click);
            // 
            // BTNRespaldo
            // 
            this.BTNRespaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNRespaldo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BTNRespaldo.Location = new System.Drawing.Point(27, 210);
            this.BTNRespaldo.Name = "BTNRespaldo";
            this.BTNRespaldo.Size = new System.Drawing.Size(180, 45);
            this.BTNRespaldo.TabIndex = 6;
            this.BTNRespaldo.Text = "RESPALDAR BD";
            this.BTNRespaldo.UseVisualStyleBackColor = true;
            this.BTNRespaldo.Click += new System.EventHandler(this.BTNRespaldo_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(915, 422);
            this.Controls.Add(this.BTNRespaldo);
            this.Controls.Add(this.BTNRefrescar);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.BTNModificar);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.DataGridAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Administrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridAdmin;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Button BTNModificar;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.Button BTNRefrescar;
        private System.Windows.Forms.Button BTNRespaldo;
    }
}