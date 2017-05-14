using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTournoi
{
    public class UtilisateurConnecté
    {
        public string username,mail;

        public UtilisateurConnecté(string username, string mail)
        {
            this.username = username;
            this.mail = mail;
        }
    }
}
