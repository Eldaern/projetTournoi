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
            conn.ConnectionString = Properties.Settings.Default.TorDBConnectionString;
            conn.Open();
            TorDBDataSet ds=new TorDBDataSet();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Equipe";
            dtad.SelectCommand = cmd;
            dtad.Fill(ds,"Equipe");
            cmd.CommandText = "select * from EquipeTournoi";
            dtad.SelectCommand = cmd;
            dtad.Fill(ds, "Equipe-Tournoi");
            cmd.CommandText = "select * from Equipeutlisateur";
            dtad.SelectCommand = cmd;
            dtad.Fill(ds, "Equipe-utlisateur");
            cmd.CommandText = "select * from jeux";
            dtad.SelectCommand = cmd;
            dtad.Fill(ds, "jeux");
            cmd.CommandText = "select * from Lieu";
            dtad.SelectCommand = cmd;
            dtad.Fill(ds, "Lieu");
            cmd.CommandText = "select * from Organisation";
            dtad.SelectCommand = cmd;
            dtad.Fill(ds, "Organisation");
            cmd.CommandText = "select * from Resultat";
            dtad.SelectCommand = cmd;
            dtad.Fill(ds, "Resultat");
            cmd.CommandText = "select * from Tournoi";
            dtad.SelectCommand = cmd;
            dtad.Fill(ds, "Tournoi");
            cmd.CommandText = "select * from Utilisateur";
            dtad.SelectCommand = cmd;
            dtad.Fill(ds, "Utilisateur");
            conn.Close();
            return ds;
        }

        public void CreeTournoiUpDB(string nom, string date, string tipe, int jeu, string heure, string organisation,string Ville, string pays, int numero, string rue)
        {
            TorDBDataSet ds= UpDataSet();
            DataRow[] frows = ds.Tables["Lieu"].Select("Ville like '" + Ville + "' and Pays like '" + pays + "' and Numero like '" + numero + "' and rue like '" + rue + "'", "[N°] ASC");
            bool exist=false;
            try//cause wtf
            {
                if (frows[0] != null)
                {
                    exist = true;
                }
            }
            catch(Exception e)
            {
                exist = false;
            }

            if (exist==false)
            {
                string cmds = "INSERT INTO Lieu ([N°],Ville,Pays,Numero,rue) VALUES (@val1, @val2, @val3, @val4, @val5 )";
                using (SqlCommand comm = new SqlCommand())
                {
                    SqlConnection conn=new SqlConnection();
                    conn.ConnectionString = Properties.Settings.Default.TorDBConnectionString;
                    comm.Connection = conn;
                    comm.CommandText = cmds;
                    comm.Parameters.AddWithValue("@val1", ds.Tables["Lieu"].Rows.Count + 1);
                    comm.Parameters.AddWithValue("@val2", Ville);
                    comm.Parameters.AddWithValue("@val3", pays);
                    comm.Parameters.AddWithValue("@val4", numero);
                    comm.Parameters.AddWithValue("@val5", rue);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch(SqlException e)
                    {
                        
                    }
                    conn.Close();
                }
            }
            else
            {
                //int idLieu = (int)frows[0].ItemArray.GetValue(0);
            }
        }
    }


}
