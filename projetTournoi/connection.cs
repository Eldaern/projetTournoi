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
            TorDBDataSet ds = new TorDBDataSet();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Equipe";
            dtad.SelectCommand = cmd;
            dtad.Fill(ds, "Equipe");
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

        public void CreeTournoiUpDB(string nom, string date, string tipe, int jeu, int organisation, string Ville, string pays, int numero, string rue)
        {
            TorDBDataSet ds = UpDataSet();
            DataRow[] frows = ds.Tables["Lieu"].Select("Ville like '" + Ville + "' and Pays like '" + pays + "' and Numero = '" + numero + "' and rue like '" + rue + "'", "[N°] ASC");
            bool exist = false;
            int idLieu = 0;
            try
            {
                if (frows[0] != null)
                {
                    exist = true;
                }
            }
            catch (Exception e)
            {
                exist = false;
            }

            if (exist == false)
            {
                string cmds = "INSERT INTO Lieu ([N°],Ville,Pays,Numero,rue) VALUES (@val1, @val2, @val3, @val4, @val5 )";
                using (SqlCommand comm = new SqlCommand())
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = Properties.Settings.Default.TorDBConnectionString;
                    comm.Connection = conn;
                    comm.CommandText = cmds;
                    idLieu = ds.Tables["Lieu"].Rows.Count + 1;
                    comm.Parameters.AddWithValue("@val1", idLieu);
                    comm.Parameters.AddWithValue("@val2", Ville);
                    comm.Parameters.AddWithValue("@val3", pays);
                    comm.Parameters.AddWithValue("@val4", numero);
                    comm.Parameters.AddWithValue("@val5", rue);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {

                    }
                    conn.Close();
                }
            }
            else
            {
                idLieu = (int)frows[0].ItemArray.GetValue(0);

            }
            string cmds2 = "INSERT INTO Tournoi ([N°],Nom,DateTournoi,tipe,Jeux,Lieu) VALUES (@val1, @val2, @val3, @val4, @val5, @val6, @val7)";
            using (SqlCommand comm2 = new SqlCommand())
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = Properties.Settings.Default.TorDBConnectionString;
                comm2.Connection = conn;
                comm2.CommandText = cmds2;
                comm2.Parameters.AddWithValue("@val1", UpDataSet().Tables["Tournoi"].Rows.Count + 1);
                comm2.Parameters.AddWithValue("@val2", nom);
                comm2.Parameters.AddWithValue("@val3", date);
                comm2.Parameters.AddWithValue("@val4", tipe);
                comm2.Parameters.AddWithValue("@val5", jeu);
                comm2.Parameters.AddWithValue("@val6", idLieu);
                comm2.Parameters.AddWithValue("@val7", "null"); //Remplacer
                try
                {
                    conn.Open();
                    comm2.ExecuteNonQuery();
                }
                catch (SqlException e)
                {

                }
                conn.Close();
            }
        }

        public DataSet rechercheDunTournoi(RechercheTournoi tournoi)
        {
            DataSet ds = new DataSet();
            conn = new SqlConnection();
            cmd = new SqlCommand();
            dtad = new SqlDataAdapter();
            conn.ConnectionString = Properties.Settings.Default.TorDBConnectionString;
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "select * from jeux where [N°]="+ tournoi.jeu;
            dtad.SelectCommand = cmd;
            dtad.Fill(ds, "jeux");
            cmd.CommandText = "select * from Lieu where Ville like '" + tournoi.ville+"'";
            dtad.SelectCommand = cmd;
            dtad.Fill(ds, "lieu");
            cmd.CommandText = "select * from Tournoi where lieu.Ville like '" + tournoi.ville + "' and jeux.[N°] = " +tournoi.jeu;
            dtad.SelectCommand = cmd;
            dtad.Fill(ds, "Tournoi");
            conn.Close();
            return ds;
        }

    }


}
