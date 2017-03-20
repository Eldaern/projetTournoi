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
            this.Langue_EN_bt.Location = new System.Drawing.Point(624, 9);
            this.Langue_EN_bt.Margin = new System.Windows.Forms.Padding(0);
            this.Langue_EN_bt.Name = "Langue_EN_bt";
            this.Langue_EN_bt.Size = new System.Drawing.Size(71, 39);
            this.Langue_EN_bt.TabIndex = 1;
            this.Langue_EN_bt.UseVisualStyleBackColor = false;
            // 
            // Langue_FR_bt
            // 
            this.Langue_FR_bt.AutoSize = true;
            this.Langue_FR_bt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Langue_FR_bt.BackColor = System.Drawing.Color.Transparent;
            this.Langue_FR_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Langue_FR_bt.Location = new System.Drawing.Point(704, 9);
            this.Langue_FR_bt.Margin = new System.Windows.Forms.Padding(0);
            this.Langue_FR_bt.Name = "Langue_FR_bt";
            this.Langue_FR_bt.Size = new System.Drawing.Size(71, 39);
            this.Langue_FR_bt.TabIndex = 0;
            this.Langue_FR_bt.UseVisualStyleBackColor = false;
            // 
            // Main_Forme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 405);
            this.Controls.Add(this.Langue_EN_bt);
            this.Controls.Add(this.Langue_FR_bt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Forme";
            this.Text = "Gestion tournoi";
            this.Load += new System.EventHandler(this.Main_Forme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Langue_FR_bt;
        private System.Windows.Forms.Button Langue_EN_bt;
    }
}

