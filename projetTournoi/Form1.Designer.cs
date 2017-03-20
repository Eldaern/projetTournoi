namespace projetTournoi
{
    partial class Main_Forme
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Forme));
            this.Langue_EN_bt = new System.Windows.Forms.Button();
            this.Langue_FR_bt = new System.Windows.Forms.Button();
            this.MainMenu_Panel = new System.Windows.Forms.Panel();
            this.Connexion_Panel = new System.Windows.Forms.Panel();
            this.CP_BT_Inscription = new System.Windows.Forms.Button();
            this.CP_BT_Connexion = new System.Windows.Forms.Button();
            this.Cree_Tournoi_Panel = new System.Windows.Forms.Panel();
            this.CreeTour_Label_Title = new System.Windows.Forms.Label();
            this.CreeTour_Label_Nom = new System.Windows.Forms.Label();
            this.CreeTour_TextBox_Nom = new System.Windows.Forms.TextBox();
            this.CreeTour_DTPicker = new System.Windows.Forms.DateTimePicker();
            this.CreeTour_CB_Jeu = new System.Windows.Forms.ComboBox();
            this.CreeTour_CB_heure = new System.Windows.Forms.ComboBox();
            this.CreeTour_CB_Type = new System.Windows.Forms.ComboBox();
            this.CreeTour_Label_Ville = new System.Windows.Forms.Label();
            this.CreeTour_TextBox_Ville = new System.Windows.Forms.TextBox();
            this.CreeTour_Label_Num = new System.Windows.Forms.Label();
            this.CreeTour_TextBox_Num = new System.Windows.Forms.TextBox();
            this.CreeTour_Label_Rue = new System.Windows.Forms.Label();
            this.CreeTour_TextBox_Rue = new System.Windows.Forms.TextBox();
            this.CreeTour_Label_Pays = new System.Windows.Forms.Label();
            this.CreeTour_BT_Creer = new System.Windows.Forms.Button();
            this.CreeTour_ComboBox_Pays = new System.Windows.Forms.ComboBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.MainMenu_BT_CherchTour = new System.Windows.Forms.Button();
            this.MainMenu_BT_CreeOrg = new System.Windows.Forms.Button();
            this.MainMenu_BT_CreeTour = new System.Windows.Forms.Button();
            this.MainMenu_Panel.SuspendLayout();
            this.Connexion_Panel.SuspendLayout();
            this.Cree_Tournoi_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Langue_EN_bt
            // 
            this.Langue_EN_bt.AutoSize = true;
            this.Langue_EN_bt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Langue_EN_bt.BackColor = System.Drawing.Color.Transparent;
            this.Langue_EN_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Langue_EN_bt.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Langue_EN_bt.FlatAppearance.BorderSize = 0;
            this.Langue_EN_bt.ForeColor = System.Drawing.Color.Transparent;
            this.Langue_EN_bt.Image = global::projetTournoi.Properties.Resources.Flag_EN;
            this.Langue_EN_bt.Location = new System.Drawing.Point(624, 9);
            this.Langue_EN_bt.Margin = new System.Windows.Forms.Padding(0);
            this.Langue_EN_bt.Name = "Langue_EN_bt";
            this.Langue_EN_bt.Size = new System.Drawing.Size(71, 39);
            this.Langue_EN_bt.TabIndex = 1;
            this.Langue_EN_bt.UseVisualStyleBackColor = false;
            this.Langue_EN_bt.Click += new System.EventHandler(this.Langue_EN_bt_Click);
            // 
            // Langue_FR_bt
            // 
            this.Langue_FR_bt.AutoSize = true;
            this.Langue_FR_bt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Langue_FR_bt.BackColor = System.Drawing.Color.Transparent;
            this.Langue_FR_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Langue_FR_bt.Image = global::projetTournoi.Properties.Resources.Flag_FR;
            this.Langue_FR_bt.Location = new System.Drawing.Point(698, 9);
            this.Langue_FR_bt.Margin = new System.Windows.Forms.Padding(0);
            this.Langue_FR_bt.Name = "Langue_FR_bt";
            this.Langue_FR_bt.Size = new System.Drawing.Size(71, 39);
            this.Langue_FR_bt.TabIndex = 0;
            this.Langue_FR_bt.UseVisualStyleBackColor = false;
            this.Langue_FR_bt.Click += new System.EventHandler(this.Langue_FR_bt_Click);
            // 
            // MainMenu_Panel
            // 
            this.MainMenu_Panel.Controls.Add(this.MainMenu_BT_CreeTour);
            this.MainMenu_Panel.Controls.Add(this.MainMenu_BT_CreeOrg);
            this.MainMenu_Panel.Controls.Add(this.MainMenu_BT_CherchTour);
            this.MainMenu_Panel.Location = new System.Drawing.Point(12, 62);
            this.MainMenu_Panel.Name = "MainMenu_Panel";
            this.MainMenu_Panel.Size = new System.Drawing.Size(767, 303);
            this.MainMenu_Panel.TabIndex = 2;
            this.MainMenu_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMenu_Panel_Paint);
            // 
            // Connexion_Panel
            // 
            this.Connexion_Panel.Controls.Add(this.CP_BT_Inscription);
            this.Connexion_Panel.Controls.Add(this.CP_BT_Connexion);
            this.Connexion_Panel.Location = new System.Drawing.Point(13, 13);
            this.Connexion_Panel.Name = "Connexion_Panel";
            this.Connexion_Panel.Size = new System.Drawing.Size(315, 35);
            this.Connexion_Panel.TabIndex = 3;
            this.Connexion_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Connexion_Panel_Paint);
            // 
            // CP_BT_Inscription
            // 
            this.CP_BT_Inscription.Location = new System.Drawing.Point(124, 4);
            this.CP_BT_Inscription.Name = "CP_BT_Inscription";
            this.CP_BT_Inscription.Size = new System.Drawing.Size(94, 23);
            this.CP_BT_Inscription.TabIndex = 1;
            this.CP_BT_Inscription.Text = "inscription";
            this.CP_BT_Inscription.UseVisualStyleBackColor = true;
            this.CP_BT_Inscription.Click += new System.EventHandler(this.CP_BT_Inscription_Click);
            // 
            // CP_BT_Connexion
            // 
            this.CP_BT_Connexion.Location = new System.Drawing.Point(13, 4);
            this.CP_BT_Connexion.Name = "CP_BT_Connexion";
            this.CP_BT_Connexion.Size = new System.Drawing.Size(94, 23);
            this.CP_BT_Connexion.TabIndex = 0;
            this.CP_BT_Connexion.Text = "connexion";
            this.CP_BT_Connexion.UseVisualStyleBackColor = true;
            this.CP_BT_Connexion.Click += new System.EventHandler(this.CP_BT_Connexion_Click);
            // 
            // Cree_Tournoi_Panel
            // 
            this.Cree_Tournoi_Panel.Controls.Add(this.CreeTour_ComboBox_Pays);
            this.Cree_Tournoi_Panel.Controls.Add(this.CreeTour_BT_Creer);
            this.Cree_Tournoi_Panel.Controls.Add(this.CreeTour_Label_Pays);
            this.Cree_Tournoi_Panel.Controls.Add(this.CreeTour_TextBox_Rue);
            this.Cree_Tournoi_Panel.Controls.Add(this.CreeTour_Label_Rue);
            this.Cree_Tournoi_Panel.Controls.Add(this.CreeTour_TextBox_Num);
            this.Cree_Tournoi_Panel.Controls.Add(this.CreeTour_Label_Num);
            this.Cree_Tournoi_Panel.Controls.Add(this.CreeTour_TextBox_Ville);
            this.Cree_Tournoi_Panel.Controls.Add(this.CreeTour_Label_Ville);
            this.Cree_Tournoi_Panel.Controls.Add(this.CreeTour_CB_Type);
            this.Cree_Tournoi_Panel.Controls.Add(this.CreeTour_CB_heure);
            this.Cree_Tournoi_Panel.Controls.Add(this.CreeTour_CB_Jeu);
            this.Cree_Tournoi_Panel.Controls.Add(this.CreeTour_DTPicker);
            this.Cree_Tournoi_Panel.Controls.Add(this.CreeTour_TextBox_Nom);
            this.Cree_Tournoi_Panel.Controls.Add(this.CreeTour_Label_Nom);
            this.Cree_Tournoi_Panel.Controls.Add(this.CreeTour_Label_Title);
            this.Cree_Tournoi_Panel.Location = new System.Drawing.Point(12, 62);
            this.Cree_Tournoi_Panel.Name = "Cree_Tournoi_Panel";
            this.Cree_Tournoi_Panel.Size = new System.Drawing.Size(767, 303);
            this.Cree_Tournoi_Panel.TabIndex = 0;
            this.Cree_Tournoi_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Cree_Tournoi_Panel_Paint);
            // 
            // CreeTour_Label_Title
            // 
            this.CreeTour_Label_Title.AutoSize = true;
            this.CreeTour_Label_Title.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreeTour_Label_Title.Location = new System.Drawing.Point(236, 21);
            this.CreeTour_Label_Title.Name = "CreeTour_Label_Title";
            this.CreeTour_Label_Title.Size = new System.Drawing.Size(286, 41);
            this.CreeTour_Label_Title.TabIndex = 0;
            this.CreeTour_Label_Title.Text = "Créer un tournoi";
            this.CreeTour_Label_Title.Click += new System.EventHandler(this.CreeTour_Label_Title_Click);
            // 
            // CreeTour_Label_Nom
            // 
            this.CreeTour_Label_Nom.AutoSize = true;
            this.CreeTour_Label_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreeTour_Label_Nom.Location = new System.Drawing.Point(187, 87);
            this.CreeTour_Label_Nom.Name = "CreeTour_Label_Nom";
            this.CreeTour_Label_Nom.Size = new System.Drawing.Size(68, 25);
            this.CreeTour_Label_Nom.TabIndex = 1;
            this.CreeTour_Label_Nom.Text = "Nom :";
            this.CreeTour_Label_Nom.Click += new System.EventHandler(this.CreeTour_Label_Nom_Click);
            // 
            // CreeTour_TextBox_Nom
            // 
            this.CreeTour_TextBox_Nom.Location = new System.Drawing.Point(262, 91);
            this.CreeTour_TextBox_Nom.Name = "CreeTour_TextBox_Nom";
            this.CreeTour_TextBox_Nom.Size = new System.Drawing.Size(145, 20);
            this.CreeTour_TextBox_Nom.TabIndex = 2;
            this.CreeTour_TextBox_Nom.TextChanged += new System.EventHandler(this.CreeTour_TextBox_Nom_TextChanged);
            // 
            // CreeTour_DTPicker
            // 
            this.CreeTour_DTPicker.Location = new System.Drawing.Point(425, 92);
            this.CreeTour_DTPicker.Name = "CreeTour_DTPicker";
            this.CreeTour_DTPicker.Size = new System.Drawing.Size(167, 20);
            this.CreeTour_DTPicker.TabIndex = 3;
            this.CreeTour_DTPicker.ValueChanged += new System.EventHandler(this.CreeTour_DTPicker_ValueChanged);
            // 
            // CreeTour_CB_Jeu
            // 
            this.CreeTour_CB_Jeu.FormattingEnabled = true;
            this.CreeTour_CB_Jeu.Location = new System.Drawing.Point(192, 136);
            this.CreeTour_CB_Jeu.Name = "CreeTour_CB_Jeu";
            this.CreeTour_CB_Jeu.Size = new System.Drawing.Size(121, 21);
            this.CreeTour_CB_Jeu.TabIndex = 4;
            this.CreeTour_CB_Jeu.Text = "Jeu";
            this.CreeTour_CB_Jeu.SelectedIndexChanged += new System.EventHandler(this.CreeTour_CB_Jeu_SelectedIndexChanged);
            // 
            // CreeTour_CB_heure
            // 
            this.CreeTour_CB_heure.FormattingEnabled = true;
            this.CreeTour_CB_heure.Location = new System.Drawing.Point(471, 136);
            this.CreeTour_CB_heure.Name = "CreeTour_CB_heure";
            this.CreeTour_CB_heure.Size = new System.Drawing.Size(121, 21);
            this.CreeTour_CB_heure.TabIndex = 5;
            this.CreeTour_CB_heure.Text = "heure";
            this.CreeTour_CB_heure.SelectedIndexChanged += new System.EventHandler(this.CreeTour_CB_heure_SelectedIndexChanged);
            // 
            // CreeTour_CB_Type
            // 
            this.CreeTour_CB_Type.FormattingEnabled = true;
            this.CreeTour_CB_Type.Location = new System.Drawing.Point(332, 136);
            this.CreeTour_CB_Type.Name = "CreeTour_CB_Type";
            this.CreeTour_CB_Type.Size = new System.Drawing.Size(121, 21);
            this.CreeTour_CB_Type.TabIndex = 6;
            this.CreeTour_CB_Type.Text = "Type";
            this.CreeTour_CB_Type.SelectedIndexChanged += new System.EventHandler(this.CreeTour_CB_Type_SelectedIndexChanged);
            // 
            // CreeTour_Label_Ville
            // 
            this.CreeTour_Label_Ville.AutoSize = true;
            this.CreeTour_Label_Ville.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreeTour_Label_Ville.Location = new System.Drawing.Point(388, 172);
            this.CreeTour_Label_Ville.Name = "CreeTour_Label_Ville";
            this.CreeTour_Label_Ville.Size = new System.Drawing.Size(65, 25);
            this.CreeTour_Label_Ville.TabIndex = 7;
            this.CreeTour_Label_Ville.Text = "Ville :";
            this.CreeTour_Label_Ville.Click += new System.EventHandler(this.CreeTour_Label_Ville_Click);
            // 
            // CreeTour_TextBox_Ville
            // 
            this.CreeTour_TextBox_Ville.Location = new System.Drawing.Point(467, 177);
            this.CreeTour_TextBox_Ville.Name = "CreeTour_TextBox_Ville";
            this.CreeTour_TextBox_Ville.Size = new System.Drawing.Size(125, 20);
            this.CreeTour_TextBox_Ville.TabIndex = 8;
            this.CreeTour_TextBox_Ville.TextChanged += new System.EventHandler(this.CreeTour_TextBox_Ville_TextChanged);
            // 
            // CreeTour_Label_Num
            // 
            this.CreeTour_Label_Num.AutoSize = true;
            this.CreeTour_Label_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreeTour_Label_Num.Location = new System.Drawing.Point(454, 213);
            this.CreeTour_Label_Num.Name = "CreeTour_Label_Num";
            this.CreeTour_Label_Num.Size = new System.Drawing.Size(68, 25);
            this.CreeTour_Label_Num.TabIndex = 9;
            this.CreeTour_Label_Num.Text = "Num :";
            this.CreeTour_Label_Num.Click += new System.EventHandler(this.CreeTour_Label_Num_Click);
            // 
            // CreeTour_TextBox_Num
            // 
            this.CreeTour_TextBox_Num.Location = new System.Drawing.Point(521, 220);
            this.CreeTour_TextBox_Num.Name = "CreeTour_TextBox_Num";
            this.CreeTour_TextBox_Num.Size = new System.Drawing.Size(71, 20);
            this.CreeTour_TextBox_Num.TabIndex = 10;
            this.CreeTour_TextBox_Num.TextChanged += new System.EventHandler(this.CreeTour_TextBox_Num_TextChanged);
            // 
            // CreeTour_Label_Rue
            // 
            this.CreeTour_Label_Rue.AutoSize = true;
            this.CreeTour_Label_Rue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreeTour_Label_Rue.Location = new System.Drawing.Point(187, 214);
            this.CreeTour_Label_Rue.Name = "CreeTour_Label_Rue";
            this.CreeTour_Label_Rue.Size = new System.Drawing.Size(63, 25);
            this.CreeTour_Label_Rue.TabIndex = 11;
            this.CreeTour_Label_Rue.Text = "Rue :";
            this.CreeTour_Label_Rue.Click += new System.EventHandler(this.CreeTour_Label_Rue_Click);
            // 
            // CreeTour_TextBox_Rue
            // 
            this.CreeTour_TextBox_Rue.Location = new System.Drawing.Point(262, 219);
            this.CreeTour_TextBox_Rue.Name = "CreeTour_TextBox_Rue";
            this.CreeTour_TextBox_Rue.Size = new System.Drawing.Size(186, 20);
            this.CreeTour_TextBox_Rue.TabIndex = 12;
            this.CreeTour_TextBox_Rue.TextChanged += new System.EventHandler(this.CreeTour_TextBox_Rue_TextChanged);
            // 
            // CreeTour_Label_Pays
            // 
            this.CreeTour_Label_Pays.AutoSize = true;
            this.CreeTour_Label_Pays.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreeTour_Label_Pays.Location = new System.Drawing.Point(187, 172);
            this.CreeTour_Label_Pays.Name = "CreeTour_Label_Pays";
            this.CreeTour_Label_Pays.Size = new System.Drawing.Size(72, 25);
            this.CreeTour_Label_Pays.TabIndex = 13;
            this.CreeTour_Label_Pays.Text = "Pays :";
            this.CreeTour_Label_Pays.Click += new System.EventHandler(this.CreeTour_Label_Pays_Click);
            // 
            // CreeTour_BT_Creer
            // 
            this.CreeTour_BT_Creer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreeTour_BT_Creer.Location = new System.Drawing.Point(192, 263);
            this.CreeTour_BT_Creer.Name = "CreeTour_BT_Creer";
            this.CreeTour_BT_Creer.Size = new System.Drawing.Size(400, 25);
            this.CreeTour_BT_Creer.TabIndex = 15;
            this.CreeTour_BT_Creer.Text = "Créer";
            this.CreeTour_BT_Creer.UseVisualStyleBackColor = true;
            this.CreeTour_BT_Creer.Click += new System.EventHandler(this.CreeTour_BT_Creer_Click);
            // 
            // CreeTour_ComboBox_Pays
            // 
            this.CreeTour_ComboBox_Pays.FormattingEnabled = true;
            this.CreeTour_ComboBox_Pays.Location = new System.Drawing.Point(262, 177);
            this.CreeTour_ComboBox_Pays.Name = "CreeTour_ComboBox_Pays";
            this.CreeTour_ComboBox_Pays.Size = new System.Drawing.Size(116, 21);
            this.CreeTour_ComboBox_Pays.TabIndex = 16;
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(739, 371);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(33, 23);
            this.helpButton.TabIndex = 4;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // MainMenu_BT_CherchTour
            // 
            this.MainMenu_BT_CherchTour.Location = new System.Drawing.Point(208, 38);
            this.MainMenu_BT_CherchTour.Name = "MainMenu_BT_CherchTour";
            this.MainMenu_BT_CherchTour.Size = new System.Drawing.Size(314, 92);
            this.MainMenu_BT_CherchTour.TabIndex = 0;
            this.MainMenu_BT_CherchTour.Text = "Chercher un tournoi";
            this.MainMenu_BT_CherchTour.UseVisualStyleBackColor = true;
            this.MainMenu_BT_CherchTour.Click += new System.EventHandler(this.MainMenu_BT_CherchTour_Click);
            // 
            // MainMenu_BT_CreeOrg
            // 
            this.MainMenu_BT_CreeOrg.Location = new System.Drawing.Point(208, 141);
            this.MainMenu_BT_CreeOrg.Name = "MainMenu_BT_CreeOrg";
            this.MainMenu_BT_CreeOrg.Size = new System.Drawing.Size(144, 92);
            this.MainMenu_BT_CreeOrg.TabIndex = 1;
            this.MainMenu_BT_CreeOrg.Text = "Créer une organisation";
            this.MainMenu_BT_CreeOrg.UseVisualStyleBackColor = true;
            this.MainMenu_BT_CreeOrg.Click += new System.EventHandler(this.MainMenu_BT_CreeOrg_Click);
            // 
            // MainMenu_BT_CreeTour
            // 
            this.MainMenu_BT_CreeTour.Location = new System.Drawing.Point(378, 140);
            this.MainMenu_BT_CreeTour.Name = "MainMenu_BT_CreeTour";
            this.MainMenu_BT_CreeTour.Size = new System.Drawing.Size(144, 92);
            this.MainMenu_BT_CreeTour.TabIndex = 2;
            this.MainMenu_BT_CreeTour.Text = "Créer un tournoi";
            this.MainMenu_BT_CreeTour.UseVisualStyleBackColor = true;
            this.MainMenu_BT_CreeTour.Click += new System.EventHandler(this.MainMenu_BT_CreeTour_Click);
            // 
            // Main_Forme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 405);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.Connexion_Panel);
            this.Controls.Add(this.MainMenu_Panel);
            this.Controls.Add(this.Langue_EN_bt);
            this.Controls.Add(this.Langue_FR_bt);
            this.Controls.Add(this.Cree_Tournoi_Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Forme";
            this.Text = "Gestion tournoi";
            this.Load += new System.EventHandler(this.Main_Forme_Load);
            this.MainMenu_Panel.ResumeLayout(false);
            this.Connexion_Panel.ResumeLayout(false);
            this.Cree_Tournoi_Panel.ResumeLayout(false);
            this.Cree_Tournoi_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Langue_FR_bt;
        private System.Windows.Forms.Button Langue_EN_bt;
        private System.Windows.Forms.Panel MainMenu_Panel;
        private System.Windows.Forms.Panel Connexion_Panel;
        private System.Windows.Forms.Button CP_BT_Inscription;
        private System.Windows.Forms.Button CP_BT_Connexion;
        private System.Windows.Forms.Panel Cree_Tournoi_Panel;
        private System.Windows.Forms.Label CreeTour_Label_Title;
        private System.Windows.Forms.Label CreeTour_Label_Nom;
        private System.Windows.Forms.DateTimePicker CreeTour_DTPicker;
        private System.Windows.Forms.TextBox CreeTour_TextBox_Nom;
        private System.Windows.Forms.Label CreeTour_Label_Ville;
        private System.Windows.Forms.ComboBox CreeTour_CB_Type;
        private System.Windows.Forms.ComboBox CreeTour_CB_heure;
        private System.Windows.Forms.ComboBox CreeTour_CB_Jeu;
        private System.Windows.Forms.TextBox CreeTour_TextBox_Num;
        private System.Windows.Forms.Label CreeTour_Label_Num;
        private System.Windows.Forms.TextBox CreeTour_TextBox_Ville;
        private System.Windows.Forms.TextBox CreeTour_TextBox_Rue;
        private System.Windows.Forms.Label CreeTour_Label_Rue;
        private System.Windows.Forms.Label CreeTour_Label_Pays;
        private System.Windows.Forms.Button CreeTour_BT_Creer;
        private System.Windows.Forms.ComboBox CreeTour_ComboBox_Pays;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button MainMenu_BT_CreeTour;
        private System.Windows.Forms.Button MainMenu_BT_CreeOrg;
        private System.Windows.Forms.Button MainMenu_BT_CherchTour;
    }
}

