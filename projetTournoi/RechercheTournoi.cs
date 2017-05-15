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
        public int organisation;
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

        public void CreateEquipeTounroi(int n,string nom, UtilisateurConnecté use)
        {
            ConDD.CreateTeam(nom,n,use);
        }

        public void CreateUtilisateurEquipe(int n, string nom, UtilisateurConnecté use)
        {
            ConDD.AjoutUtilisateurEquipe(nom, n, use);
        }

        public DataSet EquipeTournoi(int n)
        {
            return ConDD.EquipeDUNTournoi(n);
        }

        public DataSet JoueurEquipe(int n, string nom)
        {
            return ConDD.JoueurDUNEEquipe(n,nom);
        }
        public DataSet OrganisationCherche()
        {
            return ConDD.Organisation();
        }

        public void OrganisationCree(string nom, string description, UtilisateurConnecté user)
        {
            ConDD.OrganisationCree(nom, description, user);
        }

        public void OrganisationModifier(int n, string description)
        {
            ConDD.OrganisationModifier(n, description);
        }

        public void CreeResultat(String nom, int tournoi, int position)
        {
            ConDD.CreeResultat(nom, tournoi, position);
        }

        public DataSet afficheResultat(int n)
        {
            return ConDD.AfficheResultat(n);
        }

        ~RechercheTournoi()
        {

        }
    }
}
