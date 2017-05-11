using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTournoi
{
    class UtilisateurConnecté
    {
        private string username;
        private int numéro;

        public UtilisateurConnecté(string username, int numéro)
        {
            this.username = username;
            this.numéro = numéro;
        }
    }
}
