using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using UTS_PBO.Controller;
using UTS_PBO.Model;

namespace UTS_PBO.View
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HalUtama halUtama = new HalUtama();
            this.Hide();
            halUtama.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Inputan tidak valid");
                return;
            }

            M_Akun akun = new M_Akun();
            {
                string username = textBox1.Text, password = textBox2.Text;
            };

            AkunContext.AddAkun(akun);
            MessageBox.Show("Mahasiswa baru berhasil ditambahkan");

            ClearFields();

            this.DialogResult = DialogResult.OK;
            this.Hide();
            HalUtama halUtama = new HalUtama();
            this.Hide();
            halUtama.Show();
        }


        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
        }


        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text))
            {
                return false;
            }
            return true;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
