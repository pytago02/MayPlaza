using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace demo01.All_Use_Control
{
    public partial class UC_AddRoom : UserControl
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=DESKTOP-HI307AE;Initial Catalog=mayplaza01;Integrated Security=True;TrustServerCertificate=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable(); 


        void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Phong";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DataGridView1.DataSource = table;

            LabelThongtinkhonghople.Visible = false;
            LabelXacnhan.Visible = false;
            CheckBoxXacnhan.Checked = false;
        }
        public UC_AddRoom()
        {
            InitializeComponent();
            LabelThongtinkhonghople.Visible = false;
            LabelXacnhan.Visible = false;
        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
            
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtSophong.ReadOnly = true;
            int i;
            i = DataGridView1.CurrentRow.Index;
            txtSophong.Text = DataGridView1.Rows[i].Cells[0].Value.ToString();
            cbLoaiphong.Text = DataGridView1.Rows[i].Cells[1].Value.ToString();
            cbLoaigiuong.Text = DataGridView1.Rows[i].Cells[2].Value.ToString();
            txtGiatien.Text = DataGridView1.Rows[i].Cells[3].Value.ToString();
            
        }

        private void btnThemphong_Click(object sender, EventArgs e)
        {
            if( txtSophong.Text != "" && cbLoaiphong.Text != "" && cbLoaigiuong.Text != "" && txtGiatien.Text != "")
            {
                if (CheckBoxXacnhan.Checked)
                {
                    command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO Phong VALUES ('" + txtSophong.Text + "', '" + cbLoaiphong.Text + "', '" + cbLoaigiuong.Text + "', '" + txtGiatien.Text + "') ";
                    command.ExecuteNonQuery();
                    LoadData();
                }
                else
                {
                    LabelXacnhan.Visible = true;
                }
            }
            else
            {
                LabelThongtinkhonghople.Visible = true;
            }
           
        }

        private void CheckBoxXacnhan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSophong.Clear();
            cbLoaiphong.Text = null;
            cbLoaigiuong.Text = null;
            txtGiatien.Clear();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (txtSophong.Text != "" && cbLoaiphong.Text != "" && cbLoaigiuong.Text != "" && txtGiatien.Text != "")
            {
                if (CheckBoxXacnhan.Checked)
                {
                    command = connection.CreateCommand();
                    command.CommandText = "DELETE FROM Phong WHERE  maPhong = '"+ txtSophong.Text + "' ";
                    command.ExecuteNonQuery();
                    LoadData();
                }
                else
                {
                    LabelXacnhan.Visible = true;
                }
            }
            else
            {
                LabelThongtinkhonghople.Visible = true;
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (txtSophong.Text != "" && cbLoaiphong.Text != "" && cbLoaigiuong.Text != "" && txtGiatien.Text != "")
            {
                if (CheckBoxXacnhan.Checked)
                {
                    command = connection.CreateCommand();
                    command.CommandText = "UPDATE Phong SET maPhong = '" + txtSophong.Text + "', loaiPhong = '"+cbLoaiphong.Text+"', loaiGiuong = '"+cbLoaigiuong.Text+"', giaTien = '"+txtGiatien.Text+ "' WHERE  maPhong = '"+ txtSophong.Text + "' ";
                    command.ExecuteNonQuery();
                    LoadData();
                }
                else
                {
                    LabelXacnhan.Visible = true;
                }
            }
            else
            {
                LabelThongtinkhonghople.Visible = true;
            }
        }
    }
}
