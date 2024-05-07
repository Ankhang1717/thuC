using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thu
{
    internal class functions
    {
        public static SqlConnection conn;
        public static string connstring;

        public static void ketnoi()
        {
            connstring = "Data Source=LAPTOP-HCCGS770\\ANKHANG;Initial Catalog=ontapktra;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection(connstring);
            conn.Open();
            //MessageBox.Show("Kết nối thành công");
        }

        public static DataTable GetDataTable(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter();
            Mydata.SelectCommand = new SqlCommand();
            Mydata.SelectCommand.Connection = functions.conn;
            Mydata.SelectCommand.CommandText = sql;
            DataTable table = new DataTable();
            Mydata.Fill(table);
            return table;
        }

        public static void runsql(string sql)
        {
            SqlCommand cmd;
            cmd = new SqlCommand(sql);
            cmd.Connection = functions.conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception loi)
            {
                MessageBox.Show(loi.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }

        public static bool CheckKey(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, functions.conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public static void fillcombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, functions.conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma;
            cbo.DisplayMember = ten;
        }

    }
}
