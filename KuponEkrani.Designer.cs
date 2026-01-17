namespace mağaza
{
    partial class KuponEkrani
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
            this.txtKupon = new System.Windows.Forms.TextBox();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.btnKuponUygula = new System.Windows.Forms.Button();
            this.btnDevam = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKupon
            // 
            this.txtKupon.Location = new System.Drawing.Point(246, 160);
            this.txtKupon.Name = "txtKupon";
            this.txtKupon.Size = new System.Drawing.Size(214, 22);
            this.txtKupon.TabIndex = 0;
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.Location = new System.Drawing.Point(91, 93);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(529, 38);
            this.lblBilgi.TabIndex = 1;
            this.lblBilgi.Text = "İNDİRİM KUPONUNUZ VARSA GİRİNİZ";
            // 
            // btnKuponUygula
            // 
            this.btnKuponUygula.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKuponUygula.Location = new System.Drawing.Point(257, 199);
            this.btnKuponUygula.Name = "btnKuponUygula";
            this.btnKuponUygula.Size = new System.Drawing.Size(189, 44);
            this.btnKuponUygula.TabIndex = 2;
            this.btnKuponUygula.Text = "KUPONU KONTROL ET";
            this.btnKuponUygula.UseVisualStyleBackColor = true;
            this.btnKuponUygula.Click += new System.EventHandler(this.btnKuponUygula_Click);
            // 
            // btnDevam
            // 
            this.btnDevam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDevam.Location = new System.Drawing.Point(518, 442);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(202, 49);
            this.btnDevam.TabIndex = 3;
            this.btnDevam.Text = "ÖDEMEYE İLERLE";
            this.btnDevam.UseVisualStyleBackColor = true;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mağaza.Properties.Resources.sepet_3_png;
            this.pictureBox1.Location = new System.Drawing.Point(245, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // KuponEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(732, 503);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDevam);
            this.Controls.Add(this.btnKuponUygula);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.txtKupon);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "KuponEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KUPONUNUZ VARSA GİRİNİZ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKupon;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Button btnKuponUygula;
        private System.Windows.Forms.Button btnDevam;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}