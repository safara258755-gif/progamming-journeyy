namespace latihan_proyek_kharin
{
    public partial class Form1 : Form
    {
        FormRiwayat riwayat;
        public Form1()
        {
            InitializeComponent();

            // PENGGUNA TIDAK BISA MENGEDIT HASIL PERHITUNGAN
            textBox4.ReadOnly = true; // Total Pendapatan
            textBox6.ReadOnly = true; // Total Potongan
            textBox9.ReadOnly = true; // Total Gaji Diterima
            buttonsimpan.Enabled = false;
        }
        // Fungsi bantu untuk parsing angka dengan aman
        private double AmanConvert(string teks)
        {
            if (string.IsNullOrWhiteSpace(teks)) return 0;

            // Hapus titik dan koma ribuan
            teks = teks.Replace(".", "").Replace(",", "");

            double hasil;
            if (double.TryParse(teks, out hasil))
                return hasil;
            else
                return 0; // JIKA gagal parsing, anggap 0
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // --- CEK DATA KOSONG ---
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" ||
                textBox5.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Semua data harus diisi terlebih dahulu!",
                                "Peringatan",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // --- UJI INPUT ANGKA ---
            try
            {
                // --- PEMASUKAN ---
                double gajiPokok = Convert.ToDouble(textBox1.Text);
                double tunjanganTransport = Convert.ToDouble(textBox2.Text);
                double tunjanganMakan = Convert.ToDouble(textBox3.Text);

                // --- POTONGAN ---
                double alfa = Convert.ToDouble(textBox8.Text);
                double asuransi = Convert.ToDouble(textBox5.Text);
                double kasbon = Convert.ToDouble(textBox7.Text);

                // --- PERHITUNGAN ---
                double totalPendapatan = gajiPokok + tunjanganTransport + tunjanganMakan;
                double totalPotongan = alfa + asuransi + kasbon;
                double totalGajiDiterima = totalPendapatan - totalPotongan;

                // --- TAMPILKAN HASIL ---
                textBox4.Text = totalPendapatan.ToString("N0"); // total pendapatan
                textBox6.Text = totalPotongan.ToString("N0");   // total potongan
                textBox9.Text = totalGajiDiterima.ToString("N0"); // total gaji diterima
                buttonsimpan.Enabled = true;

            }

            catch
            {
                MessageBox.Show("Pastikan semua data diisi dengan ANGKA tanpa titik !",
                                "Input tidak valid",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }




        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnkeluar_Click(object sender, EventArgs e)
        {
            // Konfirmasi sederhana
            DialogResult tanya = MessageBox.Show(
                "Hapus semua data?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (tanya == DialogResult.No)
                return;

            // Hapus semua isi TextBox
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBoxId.Clear();
            textBoxNama.Clear();

            // Fokus ke textbox pertama
            textBoxNama.Focus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show(
                "Apakah kamu yakin ingin keluar dari aplikasi?",
                "Konfirmasi Keluar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (konfirmasi == DialogResult.Yes)
            {
                MessageBox.Show("Terima kasih telah menggunakan aplikasi ini!", "Sampai jumpa ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Baik, lanjutkan pekerjaanmu!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonsimpan_Click(object sender, EventArgs e)
        {

            // Cek apakah hitungan sudah dilakukan
            if (string.IsNullOrEmpty(textBox9.Text) || textBox9.Text == "0")
            {
                MessageBox.Show(
                    "Harus selesaikan dulu perhitungannya sebelum menyimpan!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // --- KODE SIMPAN --- (BERHASIL DIJALANKAN)
            FormRiwayat riwayat = new FormRiwayat(this);

            riwayat.TambahRiwayat(
                textBoxNama.Text,
                textBoxId.Text,
                textBox9.Text
            );

            this.Hide();
            riwayat.Show();
        }
        

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
