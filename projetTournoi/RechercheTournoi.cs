using System;
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
            this.nom = "any";
            this.type = "any";
            this.date = "any";
            this.jeu = "any";
            this.mode = "any";
            this.ville = "any";
        }
        
        public DataSet RechercheTournoiDS()
        {
            return ConDD.rechercheDunTournoi(this);
        }

        ~RechercheTournoi()
        {

        }
    }
}
