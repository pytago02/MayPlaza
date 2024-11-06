using demo01.All_Use_Control;
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
    public partial class quanly : Form
    {
        public quanly()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void quanly_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = false;
            uC_DangKiKhach1.Visible = false;
            uC_QuanLyNhanVien1.Visible = false;
            uC_QuanLyNhanVien1.Visible = false;

            btnQlPhong.PerformClick();
        }

        private void btnThunho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnQlkhach_Click(object sender, EventArgs e)
        {
            uC_DangKiKhach1.Visible = true;
            uC_DangKiKhach1.BringToFront();
        }

        private void tbnThanhtoan_Click(object sender, EventArgs e)
        {
            uC_QuanLyNhanVien1.Visible = true;
            uC_QuanLyNhanVien1.BringToFront();
        }

        private void btnQlikhach_Click(object sender, EventArgs e)
        {
            uC_QuanLyNhanVien1.Visible=true;
            uC_QuanLyNhanVien1.BringToFront();
        }

        private void btnQlDichvu_Click(object sender, EventArgs e)
        {
            uC_QuanLyDichVu1.Visible = true;
            uC_QuanLyDichVu1.BringToFront();
        }

        private void btnQlPhong_Click(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        private void labelDangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 dn = new Form1();
            dn.ShowDialog();
        }

        private void labelGiaodiennhanvien_Click(object sender, EventArgs e)
        {
            this.Hide();
            nhanvien nv = new nhanvien();
            nv.ShowDialog();
        }
    }
}
