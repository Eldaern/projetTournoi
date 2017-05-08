using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace projetTournoi
{
    class connection
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter dtad;
        public TorDBDataSet UpDataSet()
        {
            TorDBDataSet ds = new TorDBDataSet();
            try { 
            conn = new SqlConnection();
            cmd = new SqlCommand();
            dtad = new SqlDataAdapter();
            conn.ConnectionString = Properties.Settings.Default.TorDBConnectionString;
            conn.Open();
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
            }
            catch(Exception e) {
                MessageBox.Show("Impossible de contacter la base de donnée");
            }
            return ds;
        }

        public void CreeTournoiUpDB(string nom, string date, string tipe, int jeu, int organisation, string Ville, string pays, int numero, string rue)
        {
            TorDBDataSet ds = UpDataSet();
            try { 
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
            string cmds2 = "INSERT INTO Tournoi ([N°],Nom,DateTournoi,tipe,Jeux,Lieu) VALUES (@val1, @val2, @val3, @val4, @val5, @val6)";
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
                //comm2.Parameters.AddWithValue("@val7", "null"); //Remplacer
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
            catch (Exception e)
            {
                MessageBox.Show("Impossible de contacter la base de donnée");
                MessageBox.Show(e.ToString());
            }
        }

        public DataSet rechercheDunTournoi(RechercheTournoi tournoi)
        {
            DataSet ds = new DataSet();
            try { 
            conn = new SqlConnection();
            cmd = new SqlCommand();
            dtad = new SqlDataAdapter();
            conn.ConnectionString = Properties.Settings.Default.TorDBConnectionString;
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "select jeux.nom, tournoi.Nom, tournoi.DateTournoi, Lieu.Ville from Tournoi, Lieu, jeux where Lieu.[N°]=Tournoi.Lieu and jeux.[N°]=Tournoi.Jeux and lieu.Ville like '%" + tournoi.ville + "%' and jeux.[N°]= ISNULL(" +tournoi.jeu+ ",jeux.[N°]) and Tournoi.Nom like '%"+ tournoi.nom +"%' and Tournoi.tipe like '"+tournoi.type+"' and jeux.Genre like '"+tournoi.mode+"' and Tournoi.DateTournoi like '"+tournoi.date+"%'";
            dtad.SelectCommand = cmd;
            dtad.Fill(ds, "Tournoi");
            conn.Close();

        }
            catch(Exception e) {
                MessageBox.Show("Impossible de contacter la base de donnée");
            }
            return ds;
        }

    }


}
