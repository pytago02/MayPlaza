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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelError.Visible = false;
            
            txtTaikhoan.TabIndex = 0;
            txtMatkhau.TabIndex = 1;

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (txtTaikhoan.Text == "admin" && txtMatkhau.Text == "123")
            {
                this.Hide();

                quanly ql = new quanly();
                ql.Show();
            }
            if(txtTaikhoan.Text == "nhanvien" && txtMatkhau.Text == "123")
            {
                this.Hide();

                nhanvien nv = new nhanvien();
                nv.Show();
            }
            else
            {
                labelError.Visible = true;
                txtMatkhau.Clear();
            }
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnThunho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtTaikhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter)
            {
                btnDangnhap.PerformClick();
            }
            
        }

        private void txtMatkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangnhap.PerformClick();
            }
        }

        
    }
}
