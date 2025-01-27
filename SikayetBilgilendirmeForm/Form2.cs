using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SifreliGiris
{
    public partial class Form2 : Form
    {
        // alt katagoriler
        private Dictionary<string, List<string>> altKategoriler;

        public Form2()
        {
            InitializeComponent();
            AltKategorileriOlustur();
            cmbTur.SelectedIndexChanged += CmbTur_SelectedIndexChanged; 
        }

        private void AltKategorileriOlustur()
        {
            // iki farklı katagoriye göre alt sınıfları belirliyoruz
            altKategoriler = new Dictionary<string, List<string>>
            {
                { "Şikayet", new List<string> {
                    "Proje Onay ve Kabul İşlemleri",
                    "Kamulaştırma İşlemleri",
                    "Emlak Şerh/İrtifak Terkini İşlemleri",
                    "Deplase/İptal İşlemleri",
                    "Hukuki İşlemler",
                    "Eğitim Faaliyetleri",
                    "Mali Konular Ödemeler",
                    "Personel Faaliyetleri",
                    "Dağıtım Şirketi Faaliyetleri",
                    "Diğer"
                }},
                { "Öneri", new List<string> {
                    "Proje Onay ve Kabul İşlemleri",
                    "Eğitim Faaliyetleri",
                    "Personel Faaliyetleri",
                    "Diğer"
                }}
            };

            
            cmbTur.Items.AddRange(new[] { "Şikayet", "Öneri" });
        }

        private void CmbTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAltTur.Items.Clear(); 

            string seciliTur = cmbTur.SelectedItem.ToString();
            if (altKategoriler.ContainsKey(seciliTur))
            {
                cmbAltTur.Items.AddRange(altKategoriler[seciliTur].ToArray());
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string konu = txtKonu.Text;
            string aciklama = txtAciklama.Text;
            string belgeYolu = lblBelgeYolu.Text;
            string tur = cmbTur.SelectedItem?.ToString();
            string altTur = cmbAltTur.SelectedItem?.ToString();

            // boş bırakılan yer varmı onu kontrol ediyoruz
            if (string.IsNullOrWhiteSpace(tur) || string.IsNullOrWhiteSpace(altTur) ||
                string.IsNullOrWhiteSpace(konu) || string.IsNullOrWhiteSpace(aciklama))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 8 haneli random bi ıd oluşturuyoruz sikayet için
            Random random = new Random();
            string sikayetID = random.Next(10000000, 99999999).ToString();

            MessageBox.Show(
                $"Başarıyla kaydedildi!\nID: {sikayetID}\nTür: {tur}\nAlt Tür: {altTur}\nKonu: {konu}\nAçıklama: {aciklama}",
                "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
            txtKonu.Clear();
            txtAciklama.Clear();
            lblBelgeYolu.Text = "Belge seçilmedi.";
            cmbTur.SelectedIndex = -1;
            cmbAltTur.Items.Clear();
        }

        private void btnBelgeSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblBelgeYolu.Text = openFileDialog.FileName;
            }
        }

        // sonradan ek bi katagori eklenmek isterse metot oluşturduk 
        public void YeniAltKategoriEkle(string tur, string yeniAltKategori)
        {
            if (altKategoriler.ContainsKey(tur))
            {
                altKategoriler[tur].Add(yeniAltKategori);
            }
            else
            {
                altKategoriler[tur] = new List<string> { yeniAltKategori };
            }
        }
    }
}
