namespace mağaza
{
    partial class OdemeEkrani
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
            this.gbOdeme = new System.Windows.Forms.GroupBox();
            this.rbKart = new System.Windows.Forms.RadioButton();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lstFis = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSonTutar = new System.Windows.Forms.Label();
            this.btnOdemeBitir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxtAdres = new System.Windows.Forms.RichTextBox();
            this.mtxtKartNo = new System.Windows.Forms.MaskedTextBox();
            this.pnlKartBilgileri = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.mtxtSKT = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIndirimMiktari = new System.Windows.Forms.Label();
            this.gbOdeme.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlKartBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOdeme
            // 
            this.gbOdeme.BackColor = System.Drawing.Color.Azure;
            this.gbOdeme.Controls.Add(this.rbKart);
            this.gbOdeme.Controls.Add(this.rbNakit);
            this.gbOdeme.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbOdeme.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbOdeme.Location = new System.Drawing.Point(539, 119);
            this.gbOdeme.Name = "gbOdeme";
            this.gbOdeme.Size = new System.Drawing.Size(181, 132);
            this.gbOdeme.TabIndex = 2;
            this.gbOdeme.TabStop = false;
            this.gbOdeme.Text = "LÜTFEN ÖDEME YÖNTEMİNİ SEÇİN";
            // 
            // rbKart
            // 
            this.rbKart.AutoSize = true;
            this.rbKart.Location = new System.Drawing.Point(16, 98);
            this.rbKart.Name = "rbKart";
            this.rbKart.Size = new System.Drawing.Size(113, 23);
            this.rbKart.TabIndex = 1;
            this.rbKart.TabStop = true;
            this.rbKart.Text = "KREDİ KARTI";
            this.rbKart.UseVisualStyleBackColor = true;
            this.rbKart.CheckedChanged += new System.EventHandler(this.rbKart_CheckedChanged);
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Location = new System.Drawing.Point(16, 50);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(137, 42);
            this.rbNakit.TabIndex = 0;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "NAKİT\r\n(kapıda ödeme)";
            this.rbNakit.UseVisualStyleBackColor = true;
            this.rbNakit.CheckedChanged += new System.EventHandler(this.rbNakit_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 86);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(212, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "SİPARİŞ ÖZETİNİZ:";
            // 
            // lstFis
            // 
            this.lstFis.BackColor = System.Drawing.Color.AliceBlue;
            this.lstFis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstFis.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFis.FormattingEnabled = true;
            this.lstFis.ItemHeight = 25;
            this.lstFis.Location = new System.Drawing.Point(12, 117);
            this.lstFis.Name = "lstFis";
            this.lstFis.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstFis.Size = new System.Drawing.Size(287, 277);
            this.lstFis.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.lblSonTutar);
            this.panel2.Location = new System.Drawing.Point(12, 446);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 54);
            this.panel2.TabIndex = 5;
            // 
            // lblSonTutar
            // 
            this.lblSonTutar.AutoSize = true;
            this.lblSonTutar.BackColor = System.Drawing.Color.GhostWhite;
            this.lblSonTutar.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonTutar.ForeColor = System.Drawing.Color.Red;
            this.lblSonTutar.Location = new System.Drawing.Point(3, 7);
            this.lblSonTutar.Name = "lblSonTutar";
            this.lblSonTutar.Size = new System.Drawing.Size(215, 30);
            this.lblSonTutar.TabIndex = 6;
            this.lblSonTutar.Text = "Genel Toplam : 0 TL";
            // 
            // btnOdemeBitir
            // 
            this.btnOdemeBitir.BackColor = System.Drawing.Color.SeaGreen;
            this.btnOdemeBitir.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeBitir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOdemeBitir.Location = new System.Drawing.Point(365, 423);
            this.btnOdemeBitir.Name = "btnOdemeBitir";
            this.btnOdemeBitir.Size = new System.Drawing.Size(303, 56);
            this.btnOdemeBitir.TabIndex = 6;
            this.btnOdemeBitir.Text = "SİPARİŞİ TAMAMLA VE ÖDE";
            this.btnOdemeBitir.UseVisualStyleBackColor = false;
            this.btnOdemeBitir.Click += new System.EventHandler(this.btnOdemeBitir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(346, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad - Soyad:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdSoyad.Location = new System.Drawing.Point(350, 119);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(183, 22);
            this.txtAdSoyad.TabIndex = 8;
            this.txtAdSoyad.TextChanged += new System.EventHandler(this.txtAdSoyad_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(346, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adres:";
            // 
            // rtxtAdres
            // 
            this.rtxtAdres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtAdres.Location = new System.Drawing.Point(350, 171);
            this.rtxtAdres.Name = "rtxtAdres";
            this.rtxtAdres.Size = new System.Drawing.Size(183, 80);
            this.rtxtAdres.TabIndex = 10;
            this.rtxtAdres.Text = "";
            this.rtxtAdres.TextChanged += new System.EventHandler(this.rtxtAdres_TextChanged);
            // 
            // mtxtKartNo
            // 
            this.mtxtKartNo.Location = new System.Drawing.Point(99, 4);
            this.mtxtKartNo.Mask = "0000 0000 0000 0000";
            this.mtxtKartNo.Name = "mtxtKartNo";
            this.mtxtKartNo.Size = new System.Drawing.Size(125, 22);
            this.mtxtKartNo.TabIndex = 11;
            this.mtxtKartNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mtxtKartNo_MouseClick);
            // 
            // pnlKartBilgileri
            // 
            this.pnlKartBilgileri.BackColor = System.Drawing.Color.Azure;
            this.pnlKartBilgileri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKartBilgileri.Controls.Add(this.label6);
            this.pnlKartBilgileri.Controls.Add(this.label5);
            this.pnlKartBilgileri.Controls.Add(this.label4);
            this.pnlKartBilgileri.Controls.Add(this.txtCVV);
            this.pnlKartBilgileri.Controls.Add(this.mtxtSKT);
            this.pnlKartBilgileri.Controls.Add(this.mtxtKartNo);
            this.pnlKartBilgileri.Location = new System.Drawing.Point(390, 286);
            this.pnlKartBilgileri.Name = "pnlKartBilgileri";
            this.pnlKartBilgileri.Size = new System.Drawing.Size(250, 119);
            this.pnlKartBilgileri.TabIndex = 12;
            this.pnlKartBilgileri.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "CVV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "SKT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "KART NO:";
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(57, 79);
            this.txtCVV.MaxLength = 3;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(38, 22);
            this.txtCVV.TabIndex = 12;
            this.txtCVV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCVV_KeyPress);
            // 
            // mtxtSKT
            // 
            this.mtxtSKT.Location = new System.Drawing.Point(55, 40);
            this.mtxtSKT.Mask = "00/00";
            this.mtxtSKT.Name = "mtxtSKT";
            this.mtxtSKT.Size = new System.Drawing.Size(38, 22);
            this.mtxtSKT.TabIndex = 0;
            this.mtxtSKT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mtxtSKT_MouseClick);
            this.mtxtSKT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtSKT_KeyPress);
            this.mtxtSKT.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtSKT_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "SEPETİNİZ:";
            // 
            // lblIndirimMiktari
            // 
            this.lblIndirimMiktari.AutoSize = true;
            this.lblIndirimMiktari.BackColor = System.Drawing.Color.AliceBlue;
            this.lblIndirimMiktari.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIndirimMiktari.ForeColor = System.Drawing.Color.Green;
            this.lblIndirimMiktari.Location = new System.Drawing.Point(12, 407);
            this.lblIndirimMiktari.Name = "lblIndirimMiktari";
            this.lblIndirimMiktari.Size = new System.Drawing.Size(73, 27);
            this.lblIndirimMiktari.TabIndex = 14;
            this.lblIndirimMiktari.Text = "label8";
            // 
            // OdemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(732, 503);
            this.Controls.Add(this.lblIndirimMiktari);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pnlKartBilgileri);
            this.Controls.Add(this.rtxtAdres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOdemeBitir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lstFis);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbOdeme);
            this.Name = "OdemeEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖDEME BİLGİLERİNİ GİRİNİZ";
            this.Load += new System.EventHandler(this.OdemeEkrani_Load);
            this.gbOdeme.ResumeLayout(false);
            this.gbOdeme.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlKartBilgileri.ResumeLayout(false);
            this.pnlKartBilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbOdeme;
        private System.Windows.Forms.RadioButton rbKart;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstFis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSonTutar;
        private System.Windows.Forms.Button btnOdemeBitir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtAdres;
        private System.Windows.Forms.MaskedTextBox mtxtKartNo;
        private System.Windows.Forms.Panel pnlKartBilgileri;
        private System.Windows.Forms.MaskedTextBox mtxtSKT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIndirimMiktari;
    }
}