using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    class DataProcess
    {
        public static string connectionstring = @"Data Source=.\SQLEXPRESS;Initial Catalog=quanlythuvien;Integrated Security=True";

        SqlConnection con;
        DataTable dtab;
        SqlDataAdapter da;
        SqlCommand cmd;

        public SqlConnection open()
        {
            con = new SqlConnection(connectionstring);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public SqlConnection close()
        {
            con = new SqlConnection(connectionstring);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            return con;
        }
        public DataTable truyvan(string Sql)
        {
            open();
            dtab = new DataTable();
            cmd = new SqlCommand(Sql, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dtab);
            close();
            return dtab;
        }
    }
}
