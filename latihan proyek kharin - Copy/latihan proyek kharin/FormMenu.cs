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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonmulai_Click(object sender, EventArgs e)
        {
            Form1 formUtama = new Form1();
            formUtama.Show();
            this.Hide(); // Halaman awal disembunyikan
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Size = f1.Size;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = f1.Location;
        }
    }
}
