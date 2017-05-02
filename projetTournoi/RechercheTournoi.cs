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
            this.nom = "%";
            this.type = "%";
            this.date = "%";
            this.jeu = "is not null";
            this.mode = "%";
            this.ville = "%";
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
