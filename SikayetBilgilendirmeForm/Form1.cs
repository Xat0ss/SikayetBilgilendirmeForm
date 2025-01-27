using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace SifreliGiris
{
    public partial class Form1 : Form
    {

        private string dogrulamaKodu;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnKodGonder_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string numara = txtNumara.Text;

            // burası alanların doldurulup doldurulmadığını kontrol ettiğimiz yer
            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad) || string.IsNullOrWhiteSpace(numara))
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz şekilde doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // telefon numarası geçerli dizaynda yazılmış mı diye kontrol ettiğimiz yer
            if (!IsValidPhoneNumber(numara))
            {
                MessageBox.Show("Geçerli bir şekilde (+90****) telefon numarası giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // random bi doğrulama kodu oluşturuyoruz 6 haneli
            Random random = new Random();
            dogrulamaKodu = random.Next(100000, 999999).ToString();

            // şuan sms gönderme oalyını gerçek telefona gönderemediğimiz için mesaj kutusu olarak çıkartıyoruz
            MessageBox.Show($"Sayın {ad} {soyad}, {numara} numarasına doğrulama kodu gönderildi.\nKod: {dogrulamaKodu}",
                "SMS Gönderildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            if (txtDogrulamaKodu.Text == dogrulamaKodu)
            {
                MessageBox.Show("Doğrulama başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // form2 yani ikinci ekrana şikayet formuna geçiş
                Form2 sikayetFormu = new Form2();
                sikayetFormu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Doğrulama kodu hatalı. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // tel no kontrol
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^\+90\d{10}$"; // türkiye tel no formatı
            Regex regex = new Regex(pattern);
            return regex.IsMatch(phoneNumber);
        }
    }
}
