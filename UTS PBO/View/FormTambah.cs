using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTS_PBO.Controller;
using UTS_PBO.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UTS_PBO
{
    public partial class FormTambah : Form
    {
        public FormTambah()
        {
            InitializeComponent();
        }

        private void FormTambah_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Inputan tidak valid");
                return;
            }

            M_inventaris inventaris = new M_inventaris
            {
                nama_barang = textBox1.Text,
                kategori = textBox2.Text,
                jumlah = int.Parse(textBox4.Text),
                harga = int.Parse(textBox3.Text),
            };

            InventarisContext.AddInventaris(inventaris);
            MessageBox.Show("Mahasiswa baru berhasil ditambahkan");

            ClearFields();

            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }


        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                !int.TryParse(textBox4.Text, out _))
            {
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
