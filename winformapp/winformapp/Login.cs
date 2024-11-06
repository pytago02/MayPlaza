using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformapp
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            lbError.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if( txtUsename.Text == "admin" && txtPass.Text == "123")
            {
                main main = new main();
                this.Hide();
                main.Show();
            }
            else
            {
                lbError.Visible = true;
                txtPass.Clear();
            }
        }
    }
}
