using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt101_Click(object sender, EventArgs e)
        {
            if(lb101.Text == "Trống")
            {
                bt101.FillColor = Color.Red;
                
            }
            if (lb101.Text == "Đã đặt")
            {
                bt101.FillColor = Color.Blue;
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btDat_Click(object sender, EventArgs e)
        {
            lb101.Text = "Đã đặt";
            bt101_Click(sender, e);
        }

        private void btTra_Click(object sender, EventArgs e)
        {
            lb101.Text = "Trống";
            bt101_Click(sender, e);
        }
    }
}
