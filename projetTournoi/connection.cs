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

        public void UpDataBase(TorDBDataSet ds)
        {/*
            conn = new SqlConnection();
            cmd = new SqlCommand();
            dtad = new SqlDataAdapter();
            conn.ConnectionString = Properties.Settings.Default.TorDBConnectionString;
            conn.Open();
            SqlCommandBuilder objCommandBuilder = new SqlCommandBuilder(dtad);
            dtad.Update(ds, "Equipe");*/

        }
    }


}
