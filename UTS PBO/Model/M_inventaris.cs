using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_PBO.Model
{
    public class M_inventaris
    {
        public string id_inventaris { get; set; }
        public string nama_barang { get; set; }
        public string kategori { get; set; }
        public int jumlah { get; set; }
        public int harga { get; set; }
    }
}
