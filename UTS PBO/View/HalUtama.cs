using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTS_PBO.View;

namespace UTS_PBO
{
    public partial class HalUtama : Form
    {
        public HalUtama()
        {
            InitializeComponent();
        }

        private void btnInventaris_Click(object sender, EventArgs e)
        {
            HalInventaris halInventaris = new HalInventaris();
            this.Hide();
            halInventaris.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
