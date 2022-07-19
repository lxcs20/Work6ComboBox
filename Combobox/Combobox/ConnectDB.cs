using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combobox
{
    class ConnectDB
    {
        string strcon = @"Data Source=helloxyt;Initial Catalog=dbCombo;Integrated Security=True";

        public SqlConnection Conn;
        public SqlDataAdapter Adapter;
        public DataSet ds;

        public void Query(String sql)
        {
            Conn = new SqlConnection(strcon);
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
            Conn.Open();
            try
            {
                Adapter = new SqlDataAdapter(sql, Conn);
                ds = new DataSet();
                Adapter.Fill(ds, "data");
                Conn.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("Error");
            }
        }
    }
}
