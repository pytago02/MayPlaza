using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace demo01
{
    internal class funcion
    {
        protected SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Vapas_Kkmt\\Documents\\dbDemo01.mdf;Integrated Security=True;Connect Timeout=30";
            return conn;

        }

        public DataSet GetData(String querry)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = querry;
            SqlDataAdapter da = new SqlDataAdapter(cmd); 
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        public void setData(String querry, String message)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = querry;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public SqlDataReader getForCombo(String querry)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand(querry, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
    }
}
