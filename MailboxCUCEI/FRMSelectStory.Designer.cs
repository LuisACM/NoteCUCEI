namespace MailboxCUCEI
{
    partial class FRMSelectStory
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
            this.LBLDescription = new System.Windows.Forms.Label();
            this.CBStory = new System.Windows.Forms.ComboBox();
            this.BTNBack = new System.Windows.Forms.Button();
            this.BTNOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBLDescription
            // 
            this.LBLDescription.AutoSize = true;
            this.LBLDescription.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDescription.ForeColor = System.Drawing.Color.Black;
            this.LBLDescription.Location = new System.Drawing.Point(68, 21);
            this.LBLDescription.Name = "LBLDescription";
            this.LBLDescription.Size = new System.Drawing.Size(450, 22);
            this.LBLDescription.TabIndex = 7;
            this.LBLDescription.Text = "Seleciona la historia que quieres actualizar";
            // 
            // CBStory
            // 
            this.CBStory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CBStory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBStory.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBStory.ForeColor = System.Drawing.Color.Black;
            this.CBStory.FormattingEnabled = true;
            this.CBStory.ItemHeight = 22;
            this.CBStory.Location = new System.Drawing.Point(118, 60);
            this.CBStory.Name = "CBStory";
            this.CBStory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CBStory.Size = new System.Drawing.Size(318, 30);
            this.CBStory.TabIndex = 13;
            // 
            // BTNBack
            // 
            this.BTNBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNBack.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BTNBack.Location = new System.Drawing.Point(107, 20);
            this.BTNBack.Name = "BTNBack";
            this.BTNBack.Size = new System.Drawing.Size(150, 36);
            this.BTNBack.TabIndex = 14;
            this.BTNBack.Text = "Volver";
            this.BTNBack.UseVisualStyleBackColor = true;
            this.BTNBack.Click += new System.EventHandler(this.BTNBack_Click);
            // 
            // BTNOk
            // 
            this.BTNOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNOk.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BTNOk.Location = new System.Drawing.Point(295, 20);
            this.BTNOk.Name = "BTNOk";
            this.BTNOk.Size = new System.Drawing.Size(150, 36);
            this.BTNOk.TabIndex = 15;
            this.BTNOk.Text = "Continuar";
            this.BTNOk.UseVisualStyleBackColor = true;
            this.BTNOk.Click += new System.EventHandler(this.BTNOk_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.BTNBack);
            this.panel1.Controls.Add(this.BTNOk);
            this.panel1.Location = new System.Drawing.Point(1, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 76);
            this.panel1.TabIndex = 16;
            // 
            // FRMSelectStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(530, 260);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CBStory);
            this.Controls.Add(this.LBLDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMSelectStory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.FRMSelectStory_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBLDescription;
        private System.Windows.Forms.ComboBox CBStory;
        private System.Windows.Forms.Button BTNBack;
        private System.Windows.Forms.Button BTNOk;
        private System.Windows.Forms.Panel panel1;
    }
}