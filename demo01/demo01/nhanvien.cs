using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo01
{
    public partial class nhanvien : Form
    {
        public nhanvien()
        {
            InitializeComponent();
        }

        private void nhanvien_Load(object sender, EventArgs e)
        {

        }


        private void btnDong_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThunho_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void labelDangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 dn = new Form1();
            dn.ShowDialog();
        }
    }
}
