using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latihan_proyek_kharin
{
    public partial class FormRiwayat : Form
    {
        // variabel untuk menyimpan Form1
        Form1 mainForm;
        public FormRiwayat()
        {
            InitializeComponent();
        }
        public FormRiwayat(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        public void TambahRiwayat(string nama, string id, string totalGaji)
        {
            listBox1.Items.Add(
                $"{DateTime.Now:dd/MM/yyyy HH:mm} | {nama} | ID: {id} | Gaji: {totalGaji}"
            );
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();          // sembunyikan form riwayat
            mainForm.Show();      // tampilkan form utama
        }
        

        private void FormRiwayat_Load(object sender, EventArgs e)
        {

        }
    }
}
