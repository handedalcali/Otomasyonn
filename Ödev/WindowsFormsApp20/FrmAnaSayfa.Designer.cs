namespace WindowsFormsApp20
{
    partial class FrmAnaSayfa
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
            this.BtnAdminGiris = new System.Windows.Forms.Button();
            this.BtnYeniMusteri = new System.Windows.Forms.Button();
            this.BtnMusteriler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAdminGiris
            // 
            this.BtnAdminGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAdminGiris.Location = new System.Drawing.Point(311, 151);
            this.BtnAdminGiris.Name = "BtnAdminGiris";
            this.BtnAdminGiris.Size = new System.Drawing.Size(303, 163);
            this.BtnAdminGiris.TabIndex = 0;
            this.BtnAdminGiris.Text = "Admin Giriş";
            this.BtnAdminGiris.UseVisualStyleBackColor = false;
            this.BtnAdminGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnYeniMusteri
            // 
            this.BtnYeniMusteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnYeniMusteri.Location = new System.Drawing.Point(857, 151);
            this.BtnYeniMusteri.Name = "BtnYeniMusteri";
            this.BtnYeniMusteri.Size = new System.Drawing.Size(303, 163);
            this.BtnYeniMusteri.TabIndex = 0;
            this.BtnYeniMusteri.Text = "Yeni Müşteri";
            this.BtnYeniMusteri.UseVisualStyleBackColor = false;
            this.BtnYeniMusteri.Click += new System.EventHandler(this.BtnYeniMusteri_Click);
            // 
            // BtnMusteriler
            // 
            this.BtnMusteriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnMusteriler.Location = new System.Drawing.Point(1399, 151);
            this.BtnMusteriler.Name = "BtnMusteriler";
            this.BtnMusteriler.Size = new System.Drawing.Size(303, 163);
            this.BtnMusteriler.TabIndex = 1;
            this.BtnMusteriler.Text = "Müşteriler";
            this.BtnMusteriler.UseVisualStyleBackColor = false;
            this.BtnMusteriler.Click += new System.EventHandler(this.BtnMusteriler_Click);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(2063, 1082);
            this.Controls.Add(this.BtnMusteriler);
            this.Controls.Add(this.BtnYeniMusteri);
            this.Controls.Add(this.BtnAdminGiris);
            this.Name = "FrmAnaSayfa";
            this.Text = "FrmAnaSayfa";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAdminGiris;
        private System.Windows.Forms.Button BtnYeniMusteri;
        private System.Windows.Forms.Button BtnMusteriler;
    }
}