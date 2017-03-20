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
            this.CP_BT_Connexion = new System.Windows.Forms.Button();
            this.CP_BT_Inscription = new System.Windows.Forms.Button();
            this.Connexion_Panel.SuspendLayout();
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
            // Main_Forme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 405);
            this.Controls.Add(this.Connexion_Panel);
            this.Controls.Add(this.MainMenu_Panel);
            this.Controls.Add(this.Langue_EN_bt);
            this.Controls.Add(this.Langue_FR_bt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Forme";
            this.Text = "Gestion tournoi";
            this.Load += new System.EventHandler(this.Main_Forme_Load);
            this.Connexion_Panel.ResumeLayout(false);
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
    }
}

