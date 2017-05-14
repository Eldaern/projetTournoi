using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Microsoft.VisualBasic;


namespace projetTournoi
{

    public partial class Main_Forme : Form
    {
        int CurentPanel = 1;
        int PreviousPanel = 1;
        int dureeTooltip = 10000;
        static string file = Properties.Resources.french;
        Textes textes = JsonConvert.DeserializeObject<Textes>(file);
        dataTor dataClass=new dataTor();
        connection conn = new connection();
        RechercheTournoi tournoiOBj = new RechercheTournoi();
        int NumeroTournoiSelect = 0;

        bool isConnected = false;
        UtilisateurConnecté user;
        public Main_Forme()
        {
            InitializeComponent();
        }

        private void Main_Forme_Load(object sender, EventArgs e)
        {
            //Debut
            MainMenu_Panel.BringToFront();
            Connexion_Panel.BringToFront();
            //Main_Menu_Gerer_Panel.BringToFront();
            PreviousPanel = 1;
            CurentPanel = 1;
            chargerTexte();
            BackButton.Visible = false;
            dataClass.updTor();
            CreeTour_DTPicker.Format = DateTimePickerFormat.Custom;
            CreeTour_DTPicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            ChercheTour_DTPicker.Format = DateTimePickerFormat.Custom;
            ChercheTour_DTPicker.CustomFormat = " ";

            desactiverBoutonsConnexion();
        }

        private void Langue_EN_bt_Click(object sender, EventArgs e)
        {
            file = Properties.Resources.english;
            chargerTexte();
        }

        private void Langue_FR_bt_Click(object sender, EventArgs e)
        {
            file = Properties.Resources.french;
            chargerTexte();
        }

        private void MainMenu_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Connexion_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CP_BT_Connexion_Click(object sender, EventArgs e)
        {
            Logging_Panel.BringToFront();
            PreviousPanel = 1;
            CurentPanel = 9;
            BackButton.Visible = true;
        }
       

        private void Cree_Tournoi_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreeTour_Label_Title_Click(object sender, EventArgs e)
        {

        }

        private void CreeTour_TextBox_Nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreeTour_Label_Nom_Click(object sender, EventArgs e)
        {

        }

        private void CreeTour_DTPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CreeTour_CB_Jeu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreeTour_CB_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreeTour_CB_heure_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreeTour_Label_Ville_Click(object sender, EventArgs e)
        {

        }

        private void CreeTour_TextBox_Ville_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreeTour_Label_Num_Click(object sender, EventArgs e)
        {

        }

        private void CreeTour_TextBox_Num_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreeTour_Label_Rue_Click(object sender, EventArgs e)
        {

        }

        private void CreeTour_TextBox_Rue_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreeTour_Label_Pays_Click(object sender, EventArgs e)
        {

        }

        private void CreeTour_TextBox_Pays_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreeTour_BT_Creer_Click(object sender, EventArgs e)
        {
            if (CreeTour_TextBox_Nom.Text == "" || CreeTour_CB_Jeu.SelectedIndex == -1 || CreeTour_CB_Type.SelectedIndex == -1 || CreeTour_ComboBox_Pays.SelectedIndex == -1 || CreeTour_TextBox_Ville.Text == "" || CreeTour_TextBox_Rue.Text == "" || CreeTour_TextBox_Num.Text == "")
            {
                MessageBox.Show("informations incomplètes");
            }
            else
            {
                conn.CreeTournoiUpDB(CreeTour_TextBox_Nom.Text.Replace("'", "''"), CreeTour_DTPicker.Value.ToString().Replace("'", "''"), CreeTour_CB_Type.SelectedItem.ToString().Replace("'", "''"), CreeTour_CB_Jeu.SelectedIndex + 1,0, CreeTour_TextBox_Ville.Text.Replace("'", "''"), CreeTour_ComboBox_Pays.SelectedItem.ToString().Replace("'", "''"), Int32.Parse(CreeTour_TextBox_Num.Text), CreeTour_TextBox_Rue.Text.Replace("'", "''"));
                MessageBox.Show("Tournoi créé");
            }
        }

        private void MainMenu_BT_CherchTour_Click(object sender, EventArgs e)
        {
            Chercher_Tournoi_Panel.BringToFront();
            PreviousPanel = 1;
            CurentPanel = 2;
            BackButton.Visible = true;
            ChercheTour_ComboBox_Jeu.Items.Clear();
            int nbr = dataClass.torDS.Tables["jeux"].Rows.Count;
            for (int cpt = 0; cpt < nbr; cpt++)
            {
                string nom = (string)dataClass.torDS.Tables["jeux"].Rows[cpt].ItemArray.GetValue(1);
                ChercheTour_ComboBox_Jeu.Items.Add(nom);
            }
        }

        private void MainMenu_BT_CreeOrg_Click(object sender, EventArgs e)
        {
            CreeOrg_Panel.BringToFront();
            PreviousPanel = 1;
            CurentPanel = 3;
            BackButton.Visible = true;
        }

        private void MainMenu_BT_CreeTour_Click(object sender, EventArgs e)
        {
            PreviousPanel = 1;
            creationTournoi();
            
         }

        private void helpButton_Click(object sender, EventArgs e)
        {
            textes = JsonConvert.DeserializeObject<Textes>(file);
            Help_ToolTip_langage.Show(textes.Help_langage , Langue_EN_bt, dureeTooltip);
            Help_Tooltip_Connexion.Show(textes.Help_connexion, CP_BT_Connexion, dureeTooltip);
            Help_Tooltip_Refresh.Show(textes.Help_BT_refresh, BT_Rafraîchir, dureeTooltip);
            if (CurentPanel != 1){
                Help_Tooltip_Retour.Show(textes.Help_retour, BackButton, dureeTooltip);
            }
            switch (CurentPanel)
            {
                case 1:
                    Help_toolTip_1.Show(textes.Help_chercher, MainMenu_BT_CherchTour, dureeTooltip);
                    Help_tooltip_2.Show(textes.Help_créerOrg, MainMenu_BT_CreeOrg, dureeTooltip);
                    Help_tooltip_3.Show(textes.Help_créerTour,MainMenu_BT_CreeTour, dureeTooltip);
                    break;
                case 2:
                    Help_toolTip_1.Show(textes.Help_rafraîchir, ChercheTour_BT_Rafraîchir, dureeTooltip);
                    Help_tooltip_2.Show(textes.Help_LancerRecherche, ChercheTour_BT_Chercher, dureeTooltip);
                    break;
                case 6:
                    Help_toolTip_1.Show(textes.Help_BT_choisir, LT_BT_choisir,dureeTooltip);
                    break;
                case 8:
                    Help_toolTip_1.Show(textes.Help_inscrireJ, Detail_Tour_BT_InscrireJoueur, dureeTooltip);
                    Help_tooltip_2.Show(textes.Help_inscrireE, Detail_Tour_BT_InscrireTeam, dureeTooltip);
                    break;
            }
        }

        private void Chercher_Tournoi_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChercheTour_TextBox_Nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChercheTour_Label_Nom_Click(object sender, EventArgs e)
        {

        }

        private void ChercheTour_Label_Type_Click(object sender, EventArgs e)
        {

        }

        private void ChercheTour_Label_Jeu_Click(object sender, EventArgs e)
        {

        }

        private void ChercheTour_DTPicker_ValueChanged(object sender, EventArgs e)
        {
            ChercheTour_DTPicker.Format = DateTimePickerFormat.Custom;
            ChercheTour_DTPicker.CustomFormat = "yyyy-MM-dd";
        }

        private void ChercheTour_Label_Mode_Click(object sender, EventArgs e)
        {

        }

        private void ChercheTour_Label_Ville_Click(object sender, EventArgs e)
        {

        }

        private void ChercheTour_TextBox_Ville_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChercheTour_BT_Rafraîchir_Click(object sender, EventArgs e)
        {
            ChercheTour_ComboBox_Jeu.SelectedIndex = -1;
            ChercheTour_ComboBox_Mode.SelectedIndex = -1;
            ChercheTour_TextBox_Nom.Clear();
            ChercheTour_ComboBox_Type.SelectedIndex = -1;
            ChercheTour_TextBox_Ville.Clear();
            ChercheTour_DTPicker.Format = DateTimePickerFormat.Custom;
            ChercheTour_DTPicker.CustomFormat = " ";
        }

        private void CO_Button_Creer_Click(object sender, EventArgs e)
        {

        }

        private void CO_RTB_Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void CO_Textbox_Nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void MNG_BT_CherchTour_Click(object sender, EventArgs e)
        {
            Chercher_Tournoi_Panel.BringToFront();
            PreviousPanel = 7;
            CurentPanel = 2;
            BackButton.Visible = true;
        }

        private void MNG_BT_CreeTour_Click(object sender, EventArgs e)
        {
            PreviousPanel = 7;
            creationTournoi();
        }

        private void MNG_BT_GererOrg_Click(object sender, EventArgs e)
        {
            Gerer_Org_Panel.BringToFront();
            PreviousPanel = 7;
            CurentPanel = 5;
            BackButton.Visible = true;
        }

        private void Gerer_Org_BT_Chercher_Click(object sender, EventArgs e)
        {
            Gerer_Org_ListBox.Items.Clear();
            string rechercheNom="any";
            rechercheNom = Gerer_Org_TextBox_Nom.Text.ToString().Replace("'", "''");
            int nbr = 0;
            DataSet tmp=new DataSet();
            tmp.Merge(dataClass.torDS.Tables["Utilisateur"].Select("LoginU like '%" + rechercheNom+"%'" ,"[N°] ASC"));
            try
            {
                nbr = tmp.Tables["Utilisateur"].Rows.Count;
            }
            catch(Exception ex)
            {
                Gerer_Org_ListBox.Items.Clear();
                MessageBox.Show("Utilisater inconnu");
            }
            for (int cpt = 0; cpt < nbr; cpt++)
            {
             string nomAdd = (string)tmp.Tables["Utilisateur"].Rows[cpt].ItemArray.GetValue(6);
                Gerer_Org_ListBox.Items.Add(nomAdd);
            }
        }

        private void Gerer_Org_BT_Ajouter_Click(object sender, EventArgs e)
        {
        }

        private void chargerTexte()
        {
            textes = JsonConvert.DeserializeObject<Textes>(file);
            CP_BT_Connexion.Text = textes.connexion;
            CP_BT_Inscription.Text = textes.inscription;
            BackButton.Text = textes.retour;
            BT_Rafraîchir.Text = textes.rafraichir;

            MainMenu_BT_CherchTour.Text = textes.Cherch_Tour;
            MainMenu_BT_CreeOrg.Text = textes.Créer_Org;
            MainMenu_BT_CreeTour.Text = textes.Créer_Tour;

            ChercheTour_Label_Title.Text = textes.Cherch_Tour;
            ChercheTour_Label_Nom.Text = textes.Nom + " :";
            ChercheTour_Label_Type.Text = textes.Type + " :";
            ChercheTour_Label_Jeu.Text = textes.Jeu + " :";
            ChercheTour_Label_Mode.Text = textes.Mode + " :";
            ChercheTour_Label_Ville.Text = textes.Ville + " :";
            ChercheTour_BT_Rafraîchir.Text = textes.Rafraîchir;
            ChercheTour_BT_Chercher.Text = textes.Chercher;

            CreeTour_Label_Title.Text = textes.Créer_Tour;
            CreeTour_Label_Nom.Text = textes.Nom+" :";
            CreeTour_CB_Jeu.Text = textes.Jeu;
            CreeTour_CB_Type.Text = textes.Type;
            CreeTour_Label_Pays.Text = textes.Pays+" :";
            CreeTour_Label_Ville.Text = textes.Ville + " :";
            CreeTour_Label_Rue.Text = textes.Rue + " :";
            CreeTour_Label_Num.Text = textes.Num + " :";
            CreeTour_BT_Creer.Text = textes.Créer;

            CO_Label_Title.Text = textes.Créer_Org;
            CO_Label_Nom.Text = textes.Nom+" :";
            CO_Label_Description.Text = textes.Description + " :";
            CO_Button_Creer.Text = textes.Créer;

            Gerer_Org_Label_Title.Text = textes.Gérer_org;
            Gerer_Org_Label_Nom.Text = textes.Nom + " :";
            Gerer_Org_BT_Chercher.Text = textes.Chercher;
            Gerer_Org_BT_Ajouter.Text = textes.Ajouter;

            MNG_BT_CherchTour.Text = textes.Cherch_Tour;
            MNG_BT_GererOrg.Text = textes.Gérer_org;
            MNG_BT_CreeTour.Text = textes.Créer_Tour;

            LT_BT_choisir.Text = textes.choisir;

            Detail_Tour_BT_InscrireJoueur.Text = textes.inscrireJ;
            Detail_Tour_BT_InscrireTeam.Text = textes.inscrireE;

            LP_Label_Username.Text = textes.username;
            LP_Label_Password.Text = textes.password;
            LP_BT_Valider.Text = textes.valider;

            IP_Label_NomdeCompte.Text = textes.username;
            IP_Label_Nom.Text = textes.nomdeFamille;
            IP_Label_Prénom.Text = textes.prénom;
            IP_Label_motdepasse.Text = textes.password;
            IP_BT_valider.Text = textes.valider;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            switch (PreviousPanel)
            {
                case 1:
                    MainMenu_Panel.BringToFront();
                    PreviousPanel = 1;
                    CurentPanel = 1;
                    BackButton.Visible = false;
                    break;
                case 2:
                    Chercher_Tournoi_Panel.BringToFront();
                    PreviousPanel = 1;
                    CurentPanel = 2;
                    BackButton.Visible = true;
                    break;
                case 3:
                    CreeOrg_Panel.BringToFront();
                    PreviousPanel = 1;
                    CurentPanel = 3;
                    BackButton.Visible = true;
                    break;
                case 4:
                    PreviousPanel = 1;
                    creationTournoi();
                    break;
                case 5:
                    Gerer_Org_Panel.BringToFront();
                    PreviousPanel = 7;
                    CurentPanel = 5;
                    BackButton.Visible = true;
                    break;
                case 6:
                    List_Tournoi_panel.BringToFront();
                    PreviousPanel = 2;
                    CurentPanel = 6;
                    BackButton.Visible = true;
                    break;
                case 7:
                    Main_Menu_Gerer_Panel.BringToFront();
                    PreviousPanel = 7;
                    CurentPanel = 7;
                    BackButton.Visible = false;
                    break;
                case 8:
                    Detail_Tournoi_Panel.BringToFront();
                    PreviousPanel = 6;
                    CurentPanel = 8;
                    BackButton.Visible = true;
                    break;
                case 9:
                    Logging_Panel.BringToFront();
                    PreviousPanel = 1;
                    CurentPanel = 9;
                    BackButton.Visible = true;
                    break;
                case 10:
                    Inscription_Panel.BringToFront();
                    PreviousPanel = 1;
                    CurentPanel = 10;
                    BackButton.Visible = true;
                    break;
            }
        }

        private void ChercheTour_BT_Chercher_Click(object sender, EventArgs e)
        {
            RechercheTournoi tournoi = new RechercheTournoi();
            if (ChercheTour_TextBox_Nom.Text != "")
            {
                tournoi.nom = ChercheTour_TextBox_Nom.Text.ToString().Replace("'","''");
            }
            if (ChercheTour_ComboBox_Type.SelectedIndex != -1)
            {
                tournoi.type = ChercheTour_ComboBox_Type.SelectedItem.ToString().Replace("'", "''");
            }
            if (ChercheTour_ComboBox_Jeu.SelectedIndex != -1)
            {
                int tnj = ChercheTour_ComboBox_Jeu.SelectedIndex + 1;
                tournoi.jeu = tnj.ToString();
            }
            if (ChercheTour_ComboBox_Mode.SelectedIndex != -1)
            {
                tournoi.mode = ChercheTour_ComboBox_Mode.SelectedItem.ToString().Replace("'", "''");
            }
            if (ChercheTour_TextBox_Ville.Text != "")
            {
                tournoi.ville = ChercheTour_TextBox_Ville.Text.ToString().Replace("'", "''");
            }
            if (ChercheTour_DTPicker.CustomFormat != " ")
            {
                tournoi.date = ChercheTour_DTPicker.Value.Date.ToString("yyyy-MM-dd");
            }
            List_Tournoi_panel.BringToFront();
            PreviousPanel = 1;
            CurentPanel = 6;
            DataSet ds = tournoiOBj.RechercheTournoiDS(tournoi);
            int cpt= ds.Tables["Tournoi"].Rows.Count;
            LT_DataGrid.Rows.Clear();
            LT_DataGrid.Refresh();
            for (int i=0; i<cpt; i++)
            {
                LT_DataGrid.Rows.Add(ds.Tables["Tournoi"].Rows[i].ItemArray.GetValue(0).ToString().Replace("''", "'"), ds.Tables["Tournoi"].Rows[i].ItemArray.GetValue(1).ToString().Replace("''", "'"), ds.Tables["Tournoi"].Rows[i].ItemArray.GetValue(2), ds.Tables["Tournoi"].Rows[i].ItemArray.GetValue(3).ToString().Replace("''", "'"), ds.Tables["Tournoi"].Rows[i].ItemArray.GetValue(4));
            }
            BackButton.Visible = true;

        }

        public void creationTournoi()
        {
            Cree_Tournoi_Panel.BringToFront();
            CurentPanel = 4;
            BackButton.Visible = true;
            CreeTour_CB_Jeu.Items.Clear();
            int nbr = dataClass.torDS.Tables["jeux"].Rows.Count;
            for (int cpt = 0; cpt < nbr; cpt++)
            {
                string nom = (string)dataClass.torDS.Tables["jeux"].Rows[cpt].ItemArray.GetValue(1);
                CreeTour_CB_Jeu.Items.Add(nom);
            }
            CreeTour_CB_Jeu.SelectedIndex = 0;
            CreeTour_CB_Type.SelectedIndex = 0;
            CreeTour_ComboBox_Pays.SelectedIndex = 0;
        }

        private void BT_Rafraîchir_Click(object sender, EventArgs e)
        {
            dataClass.updTor();
        }

        private void LT_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void LT_BT_choisir_Click(object sender, EventArgs e)
        {
            Detail_Tour_Listbox_Description.Items.Clear();
            Detail_Tournoi_Panel.BringToFront();
            PreviousPanel = 6;
            CurentPanel = 8;
            BackButton.Visible = true;
            NumeroTournoiSelect = (int)LT_DataGrid.CurrentRow.Cells["numéro"].Value;
            DataSet ds =tournoiOBj.DetailTournoiDS(NumeroTournoiSelect);
            Detail_Tour_PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Detail_Tour_PictureBox.Load(ds.Tables["Tournoi"].Rows[0].ItemArray.GetValue(8).ToString());
            Detail_Tour_Label_Nom.Text = ds.Tables["Tournoi"].Rows[0].ItemArray.GetValue(7).ToString().Replace("''", "'");
            Detail_Tour_Listbox_Description.Items.Add(ds.Tables["Tournoi"].Rows[0].ItemArray.GetValue(0).ToString().Replace("''", "'"));
            Detail_Tour_Listbox_Description.Items.Add(ds.Tables["Tournoi"].Rows[0].ItemArray.GetValue(1).ToString().Replace("''", "'"));
            Detail_Tour_Listbox_Description.Items.Add(ds.Tables["Tournoi"].Rows[0].ItemArray.GetValue(2).ToString().Replace("''", "'")+", "+ ds.Tables["Tournoi"].Rows[0].ItemArray.GetValue(3).ToString().Replace("''", "'")+" | "+ ds.Tables["Tournoi"].Rows[0].ItemArray.GetValue(4).ToString().Replace("''", "'")+" | "+ds.Tables["Tournoi"].Rows[0].ItemArray.GetValue(5).ToString().Replace("''", "'"));
            Detail_Tour_Listbox_Description.Items.Add(ds.Tables["Tournoi"].Rows[0].ItemArray.GetValue(6).ToString().Replace("''", "'"));
        }

        private void Detail_Tour_BT_InscrireTeam_Click(object sender, EventArgs e)
        {
            String nom;
            nom = Interaction.InputBox("Nom de la team?", "coucou", "", 200, 200);
            tournoiOBj.CreateEquipeTounroi(NumeroTournoiSelect, nom);
        }

        private void LP_BT_Valider_Click(object sender, EventArgs e)
        {
            try
            {
                string nomCompte = "", motDePasse = "";
                nomCompte = LP_TextBox_Username.Text;
                motDePasse = LP_TextBox_Password.Text;
                DirectoryEntry Ldap = new DirectoryEntry("LDAP://192.168.140.133", nomCompte, motDePasse);
                DirectorySearcher searcher = new DirectorySearcher(Ldap);
                searcher.Filter = "(SAMAccountName=" + nomCompte + ")";
                foreach (SearchResult result in searcher.FindAll())

                {
                    DirectoryEntry DirEntry = result.GetDirectoryEntry();
                    MessageBox.Show("Bonjour " + DirEntry.Properties["SAMAccountName"].Value +", vous êtes bien connecté");
                    MainMenu_Panel.BringToFront();
                    Connecté_Panel.BringToFront();
                    PreviousPanel = 1;
                    CurentPanel = 1;
                    BackButton.Visible = false;
                    isConnected = true;
                    activerBoutonsConnexion();
                }
                user = new UtilisateurConnecté(nomCompte, motDePasse);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void IP_Label_Nom_Click(object sender, EventArgs e)
        {

        }

        private void CP_BT_Inscription_Click(object sender, EventArgs e)
        {
                Inscription_Panel.BringToFront();
                PreviousPanel = 1;
                CurentPanel = 10;
                BackButton.Visible = true;
            
        }

        private void IP_BT_valider_Click(object sender, EventArgs e)
        {
            try
            {

                string nomComplet, nom, prenom, motDePasse, mail;
                nomComplet = IP_TextBox_NomdeCompte.Text;
                nom = IP_TextBox_Nom.Text;
                prenom = IP_TextBox_Prénom.Text;
                motDePasse = IP_TextBox_motdepasse.Text;
                mail = IP_TextBox_mail.Text;
                DirectoryEntry Ldap = new DirectoryEntry("LDAP://192.168.140.133", "Administrateur", "e11T22u33+");
                DirectoryEntry user2 = Ldap.Children.Add("cn=" + nomComplet, "user");

                user2.Properties["SAMAccountName"].Add(nomComplet);

                user2.Properties["sn"].Add(prenom);

                user2.Properties["givenName"].Add(nom);

                user2.Properties["description"].Add("Compte utilisateur");

                user2.CommitChanges();

                user2.Invoke("SetPassword", new object[] { motDePasse });

                user2.Properties["userAccountControl"].Value = 0x0200;

                user2.CommitChanges();

                user = new UtilisateurConnecté(nomComplet, mail);
                conn.CreateUser(user);

                MessageBox.Show("Utilisateur créé");
                MainMenu_Panel.BringToFront();
                Connecté_Panel.BringToFront();
                PreviousPanel = 1;
                CurentPanel = 1;
                BackButton.Visible = false;
                isConnected = true;
                activerBoutonsConnexion();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void ConnP_BT_Déco_Click(object sender, EventArgs e)
        {
            isConnected = false;
            Connexion_Panel.BringToFront();
            desactiverBoutonsConnexion();
        }

        private void activerBoutonsConnexion()
        {
            MainMenu_BT_CreeOrg.Enabled = true;
            Detail_Tour_BT_InscrireJoueur.Enabled = true;
            Detail_Tour_BT_InscrireTeam.Enabled = true;
        }

        private void desactiverBoutonsConnexion()
        {
            MainMenu_BT_CreeOrg.Enabled = false;
            MainMenu_BT_CreeTour.Enabled = false;
            Detail_Tour_BT_InscrireJoueur.Enabled = false;
            Detail_Tour_BT_InscrireTeam.Enabled = false;
        }
    }
}