using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Student_informationManagement
{
    internal class DBHelper
    {
        public static DataTable Fin(string sql)
        {
            //查
            SqlConnection conn = new SqlConnection("server=.;database=xuesheng;uid=sa;pwd=123456");
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        public static bool Eex(string sql)
        {
            //增删改
            SqlConnection conn = new SqlConnection("server=.;database=xuesheng;uid=sa;pwd=123456");
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int d = cmd.ExecuteNonQuery();
            conn.Close();
            return d > 0;
        }
    }
}
