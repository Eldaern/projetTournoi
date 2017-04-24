using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace projetTournoi
{
    class connection
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter dtad;
        public TorDBDataSet UpDataSet()
        {
            conn = new SqlConnection();
            cmd = new SqlCommand();
            dtad = new SqlDataAdapter();
            cmd.CommandText = "select * from *";
            conn.ConnectionString = Properties.Settings.Default.TorDBConnectionString;
            conn.Open();
            TorDBDataSet ds=new TorDBDataSet();
            cmd.Connection = conn;
            dtad.SelectCommand = cmd;
            dtad.Fill(ds);
            conn.Close();
            return ds;
        }
    }


}
