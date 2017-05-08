using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;


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
        public Main_Forme()
        {
            InitializeComponent();
        }

        private void Main_Forme_Load(object sender, EventArgs e)
        {
            //Debut
            MainMenu_Panel.BringToFront();
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
                LT_DataGrid.Rows.Add(ds.Tables["Tournoi"].Rows[i].ItemArray.GetValue(0).ToString().Replace("''", "'"), ds.Tables["Tournoi"].Rows[i].ItemArray.GetValue(1).ToString().Replace("''", "'"), ds.Tables["Tournoi"].Rows[i].ItemArray.GetValue(2), ds.Tables["Tournoi"].Rows[i].ItemArray.GetValue(3).ToString().Replace("''", "'"));
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
            Detail_Tournoi_Panel.BringToFront();
            PreviousPanel = 6;
            CurentPanel = 8;
            BackButton.Visible = true;

        }
    }
}