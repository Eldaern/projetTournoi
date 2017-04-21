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
        public Main_Forme()
        {
            InitializeComponent();
        }

        private void Main_Forme_Load(object sender, EventArgs e)
        {
            //Debut
            MainMenu_Panel.BringToFront();
            PreviousPanel = CurentPanel;
            CurentPanel = 1;
            chargerTexte();
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

        private void CP_BT_Inscription_Click(object sender, EventArgs e)
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

        }

        private void MainMenu_BT_CherchTour_Click(object sender, EventArgs e)
        {
            Chercher_Tournoi_Panel.BringToFront();
            PreviousPanel = CurentPanel;
            CurentPanel = 2;
        }

        private void MainMenu_BT_CreeOrg_Click(object sender, EventArgs e)
        {
            CreeOrg_Panel.BringToFront();
            PreviousPanel = CurentPanel;
            CurentPanel = 3;
        }

        private void MainMenu_BT_CreeTour_Click(object sender, EventArgs e)
        {
            Cree_Tournoi_Panel.BringToFront();
            PreviousPanel = CurentPanel;
            CurentPanel = 4;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            textes = JsonConvert.DeserializeObject<Textes>(file);
            Help_ToolTip_langage.Show(textes.Help_langage , Langue_EN_bt, dureeTooltip);
            Help_Tooltip_Connexion.Show(textes.Help_connexion, CP_BT_Connexion, dureeTooltip);
            Help_Tooltip_Retour.Show(textes.Help_retour, BackButton, dureeTooltip);
            switch (CurentPanel)
            {
                case 1:
                    Help_toolTip_1.Show(textes.Help_chercher, MainMenu_BT_CherchTour, dureeTooltip);
                    Help_tooltip_2.Show(textes.Help_créerOrg, MainMenu_BT_CreeOrg, dureeTooltip);
                    Help_tooltip_3.Show(textes.Help_créerTour,MainMenu_BT_CreeTour, dureeTooltip);
                    break;
                case 2:

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

        private void ChercheTour_TextBox_Type_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChercheTour_Label_Jeu_Click(object sender, EventArgs e)
        {

        }

        private void ChercheTour_DTPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ChercheTour_TextBox_Jeu_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChercheTour_Label_Mode_Click(object sender, EventArgs e)
        {

        }

        private void ChercheTour_TextBox_Mode_TextChanged(object sender, EventArgs e)
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
            ChercheTour_TextBox_Jeu.Clear();
            ChercheTour_TextBox_Mode.Clear();
            ChercheTour_TextBox_Nom.Clear();
            ChercheTour_TextBox_Type.Clear();
            ChercheTour_TextBox_Ville.Clear();
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
            PreviousPanel = CurentPanel;
            CurentPanel = 2;
        }

        private void MNG_BT_CreeTour_Click(object sender, EventArgs e)
        {
            Cree_Tournoi_Panel.BringToFront();
            PreviousPanel = CurentPanel;
            CurentPanel = 4;
        }

        private void MNG_BT_GererOrg_Click(object sender, EventArgs e)
        {
            Gerer_Org_Panel.BringToFront();
            PreviousPanel = CurentPanel;
            CurentPanel = 5;
        }

        private void Gerer_Org_BT_Chercher_Click(object sender, EventArgs e)
        {

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
            CreeTour_CB_heure.Text = textes.Heure;
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
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            switch (PreviousPanel)
            {
                case 1:
                    MainMenu_Panel.BringToFront();
                    PreviousPanel = CurentPanel;
                    CurentPanel = 1;
                    break;
                case 2:
                    Chercher_Tournoi_Panel.BringToFront();
                    PreviousPanel = CurentPanel;
                    CurentPanel = 2;
                    break;
                case 3:
                    CreeOrg_Panel.BringToFront();
                    PreviousPanel = CurentPanel;
                    CurentPanel = 3;
                    break;
                case 4:
                    Cree_Tournoi_Panel.BringToFront();
                    PreviousPanel = CurentPanel;
                    CurentPanel = 4;
                    break;
                case 5:
                    Gerer_Org_Panel.BringToFront();
                    PreviousPanel = CurentPanel;
                    CurentPanel = 5;
                    break;
            }
        }
    }
}
