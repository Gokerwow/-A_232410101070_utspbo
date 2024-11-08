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

namespace UTS_PBO.View
{
    public partial class HalInventaris : Form
    {
        public HalInventaris()
        {
            InitializeComponent();
            this.Load += HalInventaris_Load;
        }

        private void HalInventaris_Load(object sender, EventArgs e)
        {
            LoadDataInventaris();
        }

        private void LoadDataInventaris()
        {
            try
            {
                dataGridView1.AllowUserToAddRows = false;

                DataTable inventarisData = InventarisContext.All();
                if (inventarisData == null)
                {
                    MessageBox.Show("Error: Gagal mengambil data inventaris");
                    return;
                }

                dataGridView1.Columns.Clear();

                DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn();
                nomorColumn.HeaderText = "No";
                nomorColumn.Name = "nomor";
                dataGridView1.Columns.Add(nomorColumn);

                dataGridView1.DataSource = inventarisData;

                if (dataGridView1.Columns["id_inventaris"] != null) dataGridView1.Columns["id"].Visible = false;
                if (dataGridView1.Columns["nama_barang"] != null)
                    dataGridView1.Columns["nama_barang"].HeaderText = "Nama";
                if (dataGridView1.Columns["kategori"] != null)
                    dataGridView1.Columns["kategori"].HeaderText = "Kategori";
                if (dataGridView1.Columns["jumlah"] != null)
                    dataGridView1.Columns["jumlah"].HeaderText = "Jumlah";
                if (dataGridView1.Columns["harga"] != null)
                    dataGridView1.Columns["harga"].HeaderText = "Harga";

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["nomor"].Value = (i + 1).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error dalam Load data Inventaris : {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            HalUtama halUtama = new HalUtama();
            this.Hide();
            halUtama.Show();
        }
    }
}
