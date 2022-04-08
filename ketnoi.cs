using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_GS25
{
    class ketnoi
    {       
        public static String ConnectString = @"Data Source=DESKTOP-NHAT11T\SQLEXPRESS;Initial Catalog=QL NT;Integrated Security=True"; 
        //-- dùng để thực thi câu lệnh select
        public static DataTable SelectDB(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectString))
            {
                using (SqlDataAdapter dad = new SqlDataAdapter(sql, con))
                {
                    using (DataSet dst = new DataSet())
                    {
                        dad.Fill(dst);
                        return dst.Tables[0];
                    }
                }
            }
        }
        // dùng để thực thi các câu lệnh update - insert - delete		
        public static void UpInsDelDB(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectString))
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                con.Close();
                con.Dispose();
            }
        }
    }
}
