namespace SifreliGiris
{
    partial class Form2
    {
        /// <summary>
        /// Gerekli designer değişkeni
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Temizleme işlemleri
        /// </summary>
        /// <param name="disposing">Yönetilen kaynakları serbest bırak</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer tarafından oluşturulan kod

        private void InitializeComponent()
        {
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.cmbAltTur = new System.Windows.Forms.ComboBox();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnBelgeSec = new System.Windows.Forms.Button();
            this.lblBelgeYolu = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblAltTur = new System.Windows.Forms.Label();
            this.lblKonu = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbTur
            // 
            this.cmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(150, 30);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(200, 24);
            this.cmbTur.TabIndex = 0;
            // 
            // cmbAltTur
            // 
            this.cmbAltTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAltTur.FormattingEnabled = true;
            this.cmbAltTur.Location = new System.Drawing.Point(150, 70);
            this.cmbAltTur.Name = "cmbAltTur";
            this.cmbAltTur.Size = new System.Drawing.Size(200, 24);
            this.cmbAltTur.TabIndex = 1;
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(150, 110);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(200, 22);
            this.txtKonu.TabIndex = 2;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(150, 150);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(200, 80);
            this.txtAciklama.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LightBlue;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Location = new System.Drawing.Point(192, 250);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 30);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            // 
            // btnBelgeSec
            // 
            this.btnBelgeSec.BackColor = System.Drawing.Color.LightBlue;
            this.btnBelgeSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBelgeSec.Location = new System.Drawing.Point(29, 250);
            this.btnBelgeSec.Name = "btnBelgeSec";
            this.btnBelgeSec.Size = new System.Drawing.Size(100, 30);
            this.btnBelgeSec.TabIndex = 5;
            this.btnBelgeSec.Text = "Belge Seç";
            this.btnBelgeSec.UseVisualStyleBackColor = false;
            this.btnBelgeSec.Click += new System.EventHandler(this.btnBelgeSec_Click);
            // 
            // lblBelgeYolu
            // 
            this.lblBelgeYolu.AutoSize = true;
            this.lblBelgeYolu.Location = new System.Drawing.Point(22, 231);
            this.lblBelgeYolu.Name = "lblBelgeYolu";
            this.lblBelgeYolu.Size = new System.Drawing.Size(107, 16);
            this.lblBelgeYolu.TabIndex = 6;
            this.lblBelgeYolu.Text = "Belge seçilmedi.";
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(50, 30);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(79, 16);
            this.lblTur.TabIndex = 7;
            this.lblTur.Text = "Tür Seçiniz :";
            // 
            // lblAltTur
            // 
            this.lblAltTur.AutoSize = true;
            this.lblAltTur.Location = new System.Drawing.Point(50, 70);
            this.lblAltTur.Name = "lblAltTur";
            this.lblAltTur.Size = new System.Drawing.Size(97, 16);
            this.lblAltTur.TabIndex = 8;
            this.lblAltTur.Text = "Alt Tür Seçiniz :";
            // 
            // lblKonu
            // 
            this.lblKonu.AutoSize = true;
            this.lblKonu.Location = new System.Drawing.Point(50, 110);
            this.lblKonu.Name = "lblKonu";
            this.lblKonu.Size = new System.Drawing.Size(43, 16);
            this.lblKonu.TabIndex = 9;
            this.lblKonu.Text = "Konu :";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(50, 150);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(69, 16);
            this.lblAciklama.TabIndex = 10;
            this.lblAciklama.Text = "Açıklama :";
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(400, 313);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblKonu);
            this.Controls.Add(this.lblAltTur);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.lblBelgeYolu);
            this.Controls.Add(this.btnBelgeSec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.cmbAltTur);
            this.Controls.Add(this.cmbTur);
            this.Name = "Form2";
            this.Text = "Şikayet ve Öneri Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.ComboBox cmbAltTur;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnBelgeSec;
        private System.Windows.Forms.Label lblBelgeYolu;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblAltTur;
        private System.Windows.Forms.Label lblKonu;
        private System.Windows.Forms.Label lblAciklama;
    }
}
