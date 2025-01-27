namespace SifreliGiris
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtDogrulamaKodu;
        private System.Windows.Forms.Button btnKodGonder;
        private System.Windows.Forms.Button btnDogrula;

        private void InitializeComponent()
        {
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtDogrulamaKodu = new System.Windows.Forms.TextBox();
            this.btnKodGonder = new System.Windows.Forms.Button();
            this.btnDogrula = new System.Windows.Forms.Button();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblNumara = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(45, 155);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(200, 22);
            this.txtTelefon.TabIndex = 0;
            // 
            // txtDogrulamaKodu
            // 
            this.txtDogrulamaKodu.Location = new System.Drawing.Point(45, 195);
            this.txtDogrulamaKodu.Name = "txtDogrulamaKodu";
            this.txtDogrulamaKodu.Size = new System.Drawing.Size(200, 22);
            this.txtDogrulamaKodu.TabIndex = 1;
            // 
            // btnKodGonder
            // 
            this.btnKodGonder.BackColor = System.Drawing.Color.LightBlue;
            this.btnKodGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKodGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnKodGonder.Location = new System.Drawing.Point(265, 155);
            this.btnKodGonder.Name = "btnKodGonder";
            this.btnKodGonder.Size = new System.Drawing.Size(100, 30);
            this.btnKodGonder.TabIndex = 2;
            this.btnKodGonder.Text = "Kod Gönder";
            this.btnKodGonder.UseVisualStyleBackColor = false;
            this.btnKodGonder.Click += new System.EventHandler(this.btnKodGonder_Click);
            // 
            // btnDogrula
            // 
            this.btnDogrula.BackColor = System.Drawing.Color.LightBlue;
            this.btnDogrula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDogrula.Location = new System.Drawing.Point(265, 195);
            this.btnDogrula.Name = "btnDogrula";
            this.btnDogrula.Size = new System.Drawing.Size(100, 30);
            this.btnDogrula.TabIndex = 3;
            this.btnDogrula.Text = "Doğrula";
            this.btnDogrula.UseVisualStyleBackColor = false;
            this.btnDogrula.Click += new System.EventHandler(this.btnDogrula_Click);
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(165, 116);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(200, 22);
            this.txtNumara.TabIndex = 4;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(165, 76);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(200, 22);
            this.txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(165, 37);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 22);
            this.txtAd.TabIndex = 6;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(63, 43);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(24, 16);
            this.lblAd.TabIndex = 7;
            this.lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(63, 82);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(47, 16);
            this.lblSoyad.TabIndex = 8;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Location = new System.Drawing.Point(63, 119);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(55, 16);
            this.lblNumara.TabIndex = 9;
            this.lblNumara.Text = "Numara";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(424, 287);
            this.Controls.Add(this.lblNumara);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtDogrulamaKodu);
            this.Controls.Add(this.btnKodGonder);
            this.Controls.Add(this.btnDogrula);
            this.Name = "Form1";
            this.Text = "Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblNumara;
    }
}

