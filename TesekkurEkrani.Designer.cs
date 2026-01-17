namespace mağaza
{
    partial class TesekkurEkrani
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstOzet = new System.Windows.Forms.ListBox();
            this.lblOzetTutar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblAdresBilgi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::mağaza.Properties.Resources.onay_Photoroom;
            this.pictureBox1.Location = new System.Drawing.Point(21, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(151, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "SİPARİŞİNİZ ALINDI!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(281, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 56);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kuryemiz en kısa sürede kapınızda olacaktır. \r\nBizi tercih ettiğiniz için teşekkü" +
    "r ederiz.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(420, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 61);
            this.button1.TabIndex = 3;
            this.button1.Text = "SİSTEMDEN ÇIK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(73, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sipariş Özetiniz:";
            // 
            // lstOzet
            // 
            this.lstOzet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstOzet.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstOzet.FormattingEnabled = true;
            this.lstOzet.ItemHeight = 22;
            this.lstOzet.Location = new System.Drawing.Point(21, 172);
            this.lstOzet.Name = "lstOzet";
            this.lstOzet.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstOzet.Size = new System.Drawing.Size(245, 266);
            this.lstOzet.TabIndex = 5;
            // 
            // lblOzetTutar
            // 
            this.lblOzetTutar.AutoSize = true;
            this.lblOzetTutar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOzetTutar.Location = new System.Drawing.Point(17, 454);
            this.lblOzetTutar.Name = "lblOzetTutar";
            this.lblOzetTutar.Size = new System.Drawing.Size(20, 24);
            this.lblOzetTutar.TabIndex = 6;
            this.lblOzetTutar.Text = "a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(321, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tahmini Teslimat Süresi : 45 - 60 dakika\r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::mağaza.Properties.Resources.sepet_2_png;
            this.pictureBox2.Location = new System.Drawing.Point(12, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lblAdresBilgi
            // 
            this.lblAdresBilgi.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdresBilgi.Location = new System.Drawing.Point(330, 145);
            this.lblAdresBilgi.Name = "lblAdresBilgi";
            this.lblAdresBilgi.Size = new System.Drawing.Size(338, 82);
            this.lblAdresBilgi.TabIndex = 9;
            this.lblAdresBilgi.Text = "label5";
            // 
            // TesekkurEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(732, 503);
            this.Controls.Add(this.lblAdresBilgi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOzetTutar);
            this.Controls.Add(this.lstOzet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "TesekkurEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TEŞEKKÜRLER!";
            this.Load += new System.EventHandler(this.TesekkurEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstOzet;
        private System.Windows.Forms.Label lblOzetTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblAdresBilgi;
    }
}