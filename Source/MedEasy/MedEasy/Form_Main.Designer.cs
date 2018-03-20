namespace MedEasy
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsbtnRendezvous = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbxPatients = new System.Windows.Forms.ToolStripComboBox();
            this.tscbxVisites = new System.Windows.Forms.ToolStripComboBox();
            this.tscbxFacturation = new System.Windows.Forms.ToolStripComboBox();
            this.tscbxAdministration = new System.Windows.Forms.ToolStripComboBox();
            this.lblConnecte = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.pnlRendezvous = new System.Windows.Forms.Panel();
            this.lblPatientactif = new System.Windows.Forms.Label();
            this.lblPatientactifage = new System.Windows.Forms.Label();
            this.btnDeconnecter = new System.Windows.Forms.Button();
            this.lblDeselectpatient = new System.Windows.Forms.Button();
            this.btnNotifs = new System.Windows.Forms.Button();
            this.btnSelectionnerpatient = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.menuStrip1.SuspendLayout();
            this.pnlRendezvous.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnRendezvous,
            this.tscbxPatients,
            this.tscbxVisites,
            this.tscbxFacturation,
            this.tscbxAdministration});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1265, 57);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mst_TopMenu";
            // 
            // tsbtnRendezvous
            // 
            this.tsbtnRendezvous.CheckOnClick = true;
            this.tsbtnRendezvous.Name = "tsbtnRendezvous";
            this.tsbtnRendezvous.Size = new System.Drawing.Size(86, 53);
            this.tsbtnRendezvous.Text = "Rendez Vous";
            // 
            // tscbxPatients
            // 
            this.tscbxPatients.Items.AddRange(new object[] {
            "Créer",
            "Liste / Recherche"});
            this.tscbxPatients.Margin = new System.Windows.Forms.Padding(14, 0, 1, 0);
            this.tscbxPatients.Name = "tscbxPatients";
            this.tscbxPatients.Size = new System.Drawing.Size(151, 53);
            this.tscbxPatients.Text = "Patients";
            // 
            // tscbxVisites
            // 
            this.tscbxVisites.Items.AddRange(new object[] {
            "Nouveau Rendez-Vous",
            "Nouvelle Visite",
            "Historique"});
            this.tscbxVisites.Margin = new System.Windows.Forms.Padding(14, 0, 1, 0);
            this.tscbxVisites.Name = "tscbxVisites";
            this.tscbxVisites.Size = new System.Drawing.Size(151, 53);
            this.tscbxVisites.Text = "Visites";
            // 
            // tscbxFacturation
            // 
            this.tscbxFacturation.Items.AddRange(new object[] {
            "Validation des factures",
            "Liste des factures validées"});
            this.tscbxFacturation.Margin = new System.Windows.Forms.Padding(14, 0, 1, 0);
            this.tscbxFacturation.Name = "tscbxFacturation";
            this.tscbxFacturation.Size = new System.Drawing.Size(151, 53);
            this.tscbxFacturation.Text = "Facturation";
            // 
            // tscbxAdministration
            // 
            this.tscbxAdministration.Items.AddRange(new object[] {
            "Utilisateurs",
            "Sauvegarde"});
            this.tscbxAdministration.Margin = new System.Windows.Forms.Padding(14, 0, 1, 0);
            this.tscbxAdministration.Name = "tscbxAdministration";
            this.tscbxAdministration.Size = new System.Drawing.Size(151, 53);
            this.tscbxAdministration.Text = "Administration";
            // 
            // lblConnecte
            // 
            this.lblConnecte.AutoSize = true;
            this.lblConnecte.BackColor = System.Drawing.SystemColors.Control;
            this.lblConnecte.Location = new System.Drawing.Point(1054, 0);
            this.lblConnecte.Name = "lblConnecte";
            this.lblConnecte.Size = new System.Drawing.Size(139, 16);
            this.lblConnecte.TabIndex = 1;
            this.lblConnecte.Text = "Connecté en tant que :";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.BackColor = System.Drawing.SystemColors.Control;
            this.lblCurrentUser.Location = new System.Drawing.Point(1054, 27);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(12, 16);
            this.lblCurrentUser.TabIndex = 2;
            this.lblCurrentUser.Text = "-";
            // 
            // pnlRendezvous
            // 
            this.pnlRendezvous.Controls.Add(this.vScrollBar1);
            this.pnlRendezvous.Location = new System.Drawing.Point(0, 51);
            this.pnlRendezvous.Name = "pnlRendezvous";
            this.pnlRendezvous.Size = new System.Drawing.Size(1265, 530);
            this.pnlRendezvous.TabIndex = 3;
            // 
            // lblPatientactif
            // 
            this.lblPatientactif.AutoSize = true;
            this.lblPatientactif.BackColor = System.Drawing.SystemColors.Control;
            this.lblPatientactif.Location = new System.Drawing.Point(872, 0);
            this.lblPatientactif.Name = "lblPatientactif";
            this.lblPatientactif.Size = new System.Drawing.Size(115, 16);
            this.lblPatientactif.TabIndex = 4;
            this.lblPatientactif.Text = "Aucun patient actif";
            // 
            // lblPatientactifage
            // 
            this.lblPatientactifage.AutoSize = true;
            this.lblPatientactifage.BackColor = System.Drawing.SystemColors.Control;
            this.lblPatientactifage.Location = new System.Drawing.Point(872, 27);
            this.lblPatientactifage.Name = "lblPatientactifage";
            this.lblPatientactifage.Size = new System.Drawing.Size(12, 16);
            this.lblPatientactifage.TabIndex = 5;
            this.lblPatientactifage.Text = "-";
            // 
            // btnDeconnecter
            // 
            this.btnDeconnecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnecter.Location = new System.Drawing.Point(1022, 10);
            this.btnDeconnecter.Name = "btnDeconnecter";
            this.btnDeconnecter.Size = new System.Drawing.Size(26, 20);
            this.btnDeconnecter.TabIndex = 0;
            this.btnDeconnecter.Text = "X";
            this.btnDeconnecter.UseVisualStyleBackColor = true;
            this.btnDeconnecter.Click += new System.EventHandler(this.btnDeconnecter_Click);
            // 
            // lblDeselectpatient
            // 
            this.lblDeselectpatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeselectpatient.Location = new System.Drawing.Point(840, 0);
            this.lblDeselectpatient.Name = "lblDeselectpatient";
            this.lblDeselectpatient.Size = new System.Drawing.Size(26, 20);
            this.lblDeselectpatient.TabIndex = 6;
            this.lblDeselectpatient.Text = "X";
            this.lblDeselectpatient.UseVisualStyleBackColor = true;
            // 
            // btnNotifs
            // 
            this.btnNotifs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifs.Location = new System.Drawing.Point(1188, 10);
            this.btnNotifs.Name = "btnNotifs";
            this.btnNotifs.Size = new System.Drawing.Size(77, 20);
            this.btnNotifs.TabIndex = 7;
            this.btnNotifs.Text = "Notifications";
            this.btnNotifs.UseVisualStyleBackColor = true;
            // 
            // btnSelectionnerpatient
            // 
            this.btnSelectionnerpatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectionnerpatient.Location = new System.Drawing.Point(792, 25);
            this.btnSelectionnerpatient.Name = "btnSelectionnerpatient";
            this.btnSelectionnerpatient.Size = new System.Drawing.Size(74, 20);
            this.btnSelectionnerpatient.TabIndex = 8;
            this.btnSelectionnerpatient.Text = "Sélectionner";
            this.btnSelectionnerpatient.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1246, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(16, 530);
            this.vScrollBar1.TabIndex = 0;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 606);
            this.Controls.Add(this.btnSelectionnerpatient);
            this.Controls.Add(this.btnNotifs);
            this.Controls.Add(this.lblDeselectpatient);
            this.Controls.Add(this.btnDeconnecter);
            this.Controls.Add(this.lblPatientactifage);
            this.Controls.Add(this.lblPatientactif);
            this.Controls.Add(this.pnlRendezvous);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.lblConnecte);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medical Management Made Easy";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlRendezvous.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblConnecte;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Panel pnlRendezvous;
        private System.Windows.Forms.ToolStripMenuItem tsbtnRendezvous;
        private System.Windows.Forms.ToolStripComboBox tscbxPatients;
        private System.Windows.Forms.ToolStripComboBox tscbxVisites;
        private System.Windows.Forms.ToolStripComboBox tscbxFacturation;
        private System.Windows.Forms.ToolStripComboBox tscbxAdministration;
        private System.Windows.Forms.Label lblPatientactif;
        private System.Windows.Forms.Label lblPatientactifage;
        private System.Windows.Forms.Button btnDeconnecter;
        private System.Windows.Forms.Button lblDeselectpatient;
        private System.Windows.Forms.Button btnNotifs;
        private System.Windows.Forms.Button btnSelectionnerpatient;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

