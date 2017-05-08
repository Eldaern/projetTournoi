﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace projetTournoi
{
    public class RechercheTournoi
    {
        public string nom, type, date, jeu, mode, ville;
        connection ConDD=new connection();
        public RechercheTournoi()
        {
            this.nom = "%";
            this.type = "%";
            this.date = "%";
            this.jeu = "null";
            this.mode = "%";
            this.ville = "%";
        }
        
        public DataSet RechercheTournoiDS(RechercheTournoi tournoi)
        {
            return ConDD.rechercheDunTournoi(tournoi);
        }

        public DataSet DetailTournoiDS(int n)
        {
            return ConDD.DetailDunTournoi(n);
        }

        ~RechercheTournoi()
        {

        }
    }
}
