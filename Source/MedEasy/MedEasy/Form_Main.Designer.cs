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
            this.components = new System.ComponentModel.Container();
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
            this.label1 = new System.Windows.Forms.Label();
            this.tblRendezvous = new System.Windows.Forms.TableLayoutPanel();
            this.lblPatientactif = new System.Windows.Forms.Label();
            this.lblPatientactifage = new System.Windows.Forms.Label();
            this.btnDeconnecter = new System.Windows.Forms.Button();
            this.lblDeselectpatient = new System.Windows.Forms.Button();
            this.btnNotifs = new System.Windows.Forms.Button();
            this.btnSelectionnerpatient = new System.Windows.Forms.Button();
            this.pnlNouveauPatient = new System.Windows.Forms.Panel();
            this.txtEmpCP = new System.Windows.Forms.TextBox();
            this.txtEmpVille = new System.Windows.Forms.TextBox();
            this.txtEmpNom = new System.Windows.Forms.TextBox();
            this.txtInstitution = new System.Windows.Forms.TextBox();
            this.txtNumCarte = new System.Windows.Forms.TextBox();
            this.txtTelMobile = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtOrigine = new System.Windows.Forms.TextBox();
            this.dtpNaissance = new System.Windows.Forms.DateTimePicker();
            this.cbxCanton = new System.Windows.Forms.ComboBox();
            this.cbxEmpCanton = new System.Windows.Forms.ComboBox();
            this.txtEmpPays = new System.Windows.Forms.TextBox();
            this.txtEmpAdresse = new System.Windows.Forms.TextBox();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.txtNumPolice = new System.Windows.Forms.TextBox();
            this.txtNumOFSP = new System.Windows.Forms.TextBox();
            this.txtNumAvs = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelUrgence = new System.Windows.Forms.TextBox();
            this.txtTelPro = new System.Windows.Forms.TextBox();
            this.txtTelDomicile = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.cbxEtatCivil = new System.Windows.Forms.ComboBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom2 = new System.Windows.Forms.TextBox();
            this.cbxTitre = new System.Windows.Forms.ComboBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblEmpCP = new System.Windows.Forms.Label();
            this.lblEmpVille = new System.Windows.Forms.Label();
            this.lblEmpNom = new System.Windows.Forms.Label();
            this.lblInstitution = new System.Windows.Forms.Label();
            this.lblNumCarte = new System.Windows.Forms.Label();
            this.lblTelMobile = new System.Windows.Forms.Label();
            this.lblCanton = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblOrigine = new System.Windows.Forms.Label();
            this.lblNaissance = new System.Windows.Forms.Label();
            this.btnAnnulerNvPat = new System.Windows.Forms.Button();
            this.btnConfirmerNvPat = new System.Windows.Forms.Button();
            this.lblEmpPays = new System.Windows.Forms.Label();
            this.lblEmpCanton = new System.Windows.Forms.Label();
            this.lblEmpAdresse = new System.Windows.Forms.Label();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.lblNumPolice = new System.Windows.Forms.Label();
            this.lblNumOfsp = new System.Windows.Forms.Label();
            this.lblNumAvs = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tblTelUrgence = new System.Windows.Forms.Label();
            this.lblTelPro = new System.Windows.Forms.Label();
            this.lblTelDomicile = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblEtatCivil = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ttpARemplir = new System.Windows.Forms.ToolTip(this.components);
            this.pnlPatients = new System.Windows.Forms.Panel();
            this.lblListePatients = new System.Windows.Forms.Label();
            this.tblPatients = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.pnlRendezvous.SuspendLayout();
            this.pnlNouveauPatient.SuspendLayout();
            this.pnlPatients.SuspendLayout();
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
            this.tsbtnRendezvous.Click += new System.EventHandler(this.tsbtnRendezvous_Click);
            this.tsbtnRendezvous.DoubleClick += new System.EventHandler(this.tsbtnRendezvous_Click);
            // 
            // tscbxPatients
            // 
            this.tscbxPatients.Items.AddRange(new object[] {
            "Créer",
            "Liste"});
            this.tscbxPatients.Margin = new System.Windows.Forms.Padding(14, 0, 1, 0);
            this.tscbxPatients.Name = "tscbxPatients";
            this.tscbxPatients.Size = new System.Drawing.Size(151, 53);
            this.tscbxPatients.Text = "Patient";
            this.tscbxPatients.TextChanged += new System.EventHandler(this.tscbxPatients_TextChanged);
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
            this.pnlRendezvous.AutoScroll = true;
            this.pnlRendezvous.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRendezvous.Controls.Add(this.label1);
            this.pnlRendezvous.Controls.Add(this.tblRendezvous);
            this.pnlRendezvous.Location = new System.Drawing.Point(0, 51);
            this.pnlRendezvous.Name = "pnlRendezvous";
            this.pnlRendezvous.Size = new System.Drawing.Size(1265, 556);
            this.pnlRendezvous.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rendez-vous à venir";
            // 
            // tblRendezvous
            // 
            this.tblRendezvous.AutoSize = true;
            this.tblRendezvous.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tblRendezvous.ColumnCount = 7;
            this.tblRendezvous.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblRendezvous.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblRendezvous.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblRendezvous.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblRendezvous.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblRendezvous.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblRendezvous.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblRendezvous.Location = new System.Drawing.Point(36, 53);
            this.tblRendezvous.Name = "tblRendezvous";
            this.tblRendezvous.RowCount = 1;
            this.tblRendezvous.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tblRendezvous.Size = new System.Drawing.Size(1156, 112);
            this.tblRendezvous.TabIndex = 1;
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
            // pnlNouveauPatient
            // 
            this.pnlNouveauPatient.AutoScroll = true;
            this.pnlNouveauPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNouveauPatient.Controls.Add(this.txtEmpCP);
            this.pnlNouveauPatient.Controls.Add(this.txtEmpVille);
            this.pnlNouveauPatient.Controls.Add(this.txtEmpNom);
            this.pnlNouveauPatient.Controls.Add(this.txtInstitution);
            this.pnlNouveauPatient.Controls.Add(this.txtNumCarte);
            this.pnlNouveauPatient.Controls.Add(this.txtTelMobile);
            this.pnlNouveauPatient.Controls.Add(this.txtVille);
            this.pnlNouveauPatient.Controls.Add(this.txtOrigine);
            this.pnlNouveauPatient.Controls.Add(this.dtpNaissance);
            this.pnlNouveauPatient.Controls.Add(this.cbxCanton);
            this.pnlNouveauPatient.Controls.Add(this.cbxEmpCanton);
            this.pnlNouveauPatient.Controls.Add(this.txtEmpPays);
            this.pnlNouveauPatient.Controls.Add(this.txtEmpAdresse);
            this.pnlNouveauPatient.Controls.Add(this.txtOccupation);
            this.pnlNouveauPatient.Controls.Add(this.txtNumPolice);
            this.pnlNouveauPatient.Controls.Add(this.txtNumOFSP);
            this.pnlNouveauPatient.Controls.Add(this.txtNumAvs);
            this.pnlNouveauPatient.Controls.Add(this.txtEmail);
            this.pnlNouveauPatient.Controls.Add(this.txtTelUrgence);
            this.pnlNouveauPatient.Controls.Add(this.txtTelPro);
            this.pnlNouveauPatient.Controls.Add(this.txtTelDomicile);
            this.pnlNouveauPatient.Controls.Add(this.txtCP);
            this.pnlNouveauPatient.Controls.Add(this.txtAdresse);
            this.pnlNouveauPatient.Controls.Add(this.cbxEtatCivil);
            this.pnlNouveauPatient.Controls.Add(this.txtNom);
            this.pnlNouveauPatient.Controls.Add(this.txtPrenom2);
            this.pnlNouveauPatient.Controls.Add(this.cbxTitre);
            this.pnlNouveauPatient.Controls.Add(this.txtPrenom);
            this.pnlNouveauPatient.Controls.Add(this.lblEmpCP);
            this.pnlNouveauPatient.Controls.Add(this.lblEmpVille);
            this.pnlNouveauPatient.Controls.Add(this.lblEmpNom);
            this.pnlNouveauPatient.Controls.Add(this.lblInstitution);
            this.pnlNouveauPatient.Controls.Add(this.lblNumCarte);
            this.pnlNouveauPatient.Controls.Add(this.lblTelMobile);
            this.pnlNouveauPatient.Controls.Add(this.lblCanton);
            this.pnlNouveauPatient.Controls.Add(this.lblVille);
            this.pnlNouveauPatient.Controls.Add(this.lblOrigine);
            this.pnlNouveauPatient.Controls.Add(this.lblNaissance);
            this.pnlNouveauPatient.Controls.Add(this.btnAnnulerNvPat);
            this.pnlNouveauPatient.Controls.Add(this.btnConfirmerNvPat);
            this.pnlNouveauPatient.Controls.Add(this.lblEmpPays);
            this.pnlNouveauPatient.Controls.Add(this.lblEmpCanton);
            this.pnlNouveauPatient.Controls.Add(this.lblEmpAdresse);
            this.pnlNouveauPatient.Controls.Add(this.lblOccupation);
            this.pnlNouveauPatient.Controls.Add(this.lblNumPolice);
            this.pnlNouveauPatient.Controls.Add(this.lblNumOfsp);
            this.pnlNouveauPatient.Controls.Add(this.lblNumAvs);
            this.pnlNouveauPatient.Controls.Add(this.lblEmail);
            this.pnlNouveauPatient.Controls.Add(this.tblTelUrgence);
            this.pnlNouveauPatient.Controls.Add(this.lblTelPro);
            this.pnlNouveauPatient.Controls.Add(this.lblTelDomicile);
            this.pnlNouveauPatient.Controls.Add(this.lblCP);
            this.pnlNouveauPatient.Controls.Add(this.lblAdresse);
            this.pnlNouveauPatient.Controls.Add(this.lblEtatCivil);
            this.pnlNouveauPatient.Controls.Add(this.lblNom);
            this.pnlNouveauPatient.Controls.Add(this.label2);
            this.pnlNouveauPatient.Location = new System.Drawing.Point(0, 51);
            this.pnlNouveauPatient.Name = "pnlNouveauPatient";
            this.pnlNouveauPatient.Size = new System.Drawing.Size(1265, 556);
            this.pnlNouveauPatient.TabIndex = 5;
            // 
            // txtEmpCP
            // 
            this.txtEmpCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpCP.Location = new System.Drawing.Point(807, 739);
            this.txtEmpCP.Name = "txtEmpCP";
            this.txtEmpCP.Size = new System.Drawing.Size(93, 22);
            this.txtEmpCP.TabIndex = 59;
            // 
            // txtEmpVille
            // 
            this.txtEmpVille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpVille.Location = new System.Drawing.Point(807, 695);
            this.txtEmpVille.Name = "txtEmpVille";
            this.txtEmpVille.Size = new System.Drawing.Size(176, 22);
            this.txtEmpVille.TabIndex = 58;
            // 
            // txtEmpNom
            // 
            this.txtEmpNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpNom.Location = new System.Drawing.Point(807, 649);
            this.txtEmpNom.Name = "txtEmpNom";
            this.txtEmpNom.Size = new System.Drawing.Size(208, 22);
            this.txtEmpNom.TabIndex = 57;
            // 
            // txtInstitution
            // 
            this.txtInstitution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstitution.Location = new System.Drawing.Point(807, 536);
            this.txtInstitution.Name = "txtInstitution";
            this.txtInstitution.Size = new System.Drawing.Size(208, 22);
            this.txtInstitution.TabIndex = 56;
            // 
            // txtNumCarte
            // 
            this.txtNumCarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumCarte.Location = new System.Drawing.Point(807, 491);
            this.txtNumCarte.Name = "txtNumCarte";
            this.txtNumCarte.Size = new System.Drawing.Size(208, 22);
            this.txtNumCarte.TabIndex = 55;
            // 
            // txtTelMobile
            // 
            this.txtTelMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelMobile.Location = new System.Drawing.Point(807, 249);
            this.txtTelMobile.Name = "txtTelMobile";
            this.txtTelMobile.Size = new System.Drawing.Size(176, 22);
            this.txtTelMobile.TabIndex = 54;
            // 
            // txtVille
            // 
            this.txtVille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVille.Location = new System.Drawing.Point(807, 160);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(176, 22);
            this.txtVille.TabIndex = 53;
            // 
            // txtOrigine
            // 
            this.txtOrigine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrigine.Location = new System.Drawing.Point(807, 114);
            this.txtOrigine.Name = "txtOrigine";
            this.txtOrigine.Size = new System.Drawing.Size(208, 22);
            this.txtOrigine.TabIndex = 52;
            // 
            // dtpNaissance
            // 
            this.dtpNaissance.Location = new System.Drawing.Point(807, 70);
            this.dtpNaissance.Name = "dtpNaissance";
            this.dtpNaissance.Size = new System.Drawing.Size(208, 22);
            this.dtpNaissance.TabIndex = 51;
            // 
            // cbxCanton
            // 
            this.cbxCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCanton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCanton.FormattingEnabled = true;
            this.cbxCanton.Items.AddRange(new object[] {
            "Appenzell Rhodes-Extérieures",
            "Appenzell Rhodes-Intérieures",
            "Argovie",
            "Bâle-Campagne",
            "Bâle-Ville",
            "Berne",
            "Fribourg",
            "Genève",
            "Glaris",
            "Grisons",
            "Jura",
            "Lucerne",
            "Neuchâtel",
            "Nidwald",
            "Obwald",
            "Saint-Gall",
            "Schaffhouse",
            "Schwytz",
            "Soleure",
            "Tessin",
            "Thurgovie",
            "Uri",
            "Valais",
            "Vaud",
            "Wildspitz",
            "Schnebelhorn"});
            this.cbxCanton.Location = new System.Drawing.Point(807, 202);
            this.cbxCanton.Name = "cbxCanton";
            this.cbxCanton.Size = new System.Drawing.Size(208, 24);
            this.cbxCanton.TabIndex = 49;
            // 
            // cbxEmpCanton
            // 
            this.cbxEmpCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmpCanton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEmpCanton.FormattingEnabled = true;
            this.cbxEmpCanton.Items.AddRange(new object[] {
            "Appenzell Rhodes-Extérieures",
            "Appenzell Rhodes-Intérieures",
            "Argovie",
            "Bâle-Campagne",
            "Bâle-Ville",
            "Berne",
            "Fribourg",
            "Genève",
            "Glaris",
            "Grisons",
            "Jura",
            "Lucerne",
            "Neuchâtel",
            "Nidwald",
            "Obwald",
            "Saint-Gall",
            "Schaffhouse",
            "Schwytz",
            "Soleure",
            "Tessin",
            "Thurgovie",
            "Uri",
            "Valais",
            "Vaud",
            "Wildspitz",
            "Schnebelhorn"});
            this.cbxEmpCanton.Location = new System.Drawing.Point(170, 778);
            this.cbxEmpCanton.Name = "cbxEmpCanton";
            this.cbxEmpCanton.Size = new System.Drawing.Size(208, 24);
            this.cbxEmpCanton.TabIndex = 48;
            // 
            // txtEmpPays
            // 
            this.txtEmpPays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpPays.Location = new System.Drawing.Point(170, 739);
            this.txtEmpPays.Name = "txtEmpPays";
            this.txtEmpPays.Size = new System.Drawing.Size(208, 22);
            this.txtEmpPays.TabIndex = 47;
            // 
            // txtEmpAdresse
            // 
            this.txtEmpAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpAdresse.Location = new System.Drawing.Point(170, 695);
            this.txtEmpAdresse.Name = "txtEmpAdresse";
            this.txtEmpAdresse.Size = new System.Drawing.Size(282, 22);
            this.txtEmpAdresse.TabIndex = 46;
            // 
            // txtOccupation
            // 
            this.txtOccupation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOccupation.Location = new System.Drawing.Point(170, 649);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(208, 22);
            this.txtOccupation.TabIndex = 45;
            // 
            // txtNumPolice
            // 
            this.txtNumPolice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumPolice.Location = new System.Drawing.Point(170, 579);
            this.txtNumPolice.Name = "txtNumPolice";
            this.txtNumPolice.Size = new System.Drawing.Size(108, 22);
            this.txtNumPolice.TabIndex = 44;
            // 
            // txtNumOFSP
            // 
            this.txtNumOFSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumOFSP.Location = new System.Drawing.Point(170, 536);
            this.txtNumOFSP.Name = "txtNumOFSP";
            this.txtNumOFSP.Size = new System.Drawing.Size(208, 22);
            this.txtNumOFSP.TabIndex = 43;
            // 
            // txtNumAvs
            // 
            this.txtNumAvs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumAvs.Location = new System.Drawing.Point(170, 491);
            this.txtNumAvs.Name = "txtNumAvs";
            this.txtNumAvs.Size = new System.Drawing.Size(208, 22);
            this.txtNumAvs.TabIndex = 42;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(170, 424);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(208, 22);
            this.txtEmail.TabIndex = 41;
            // 
            // txtTelUrgence
            // 
            this.txtTelUrgence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelUrgence.Location = new System.Drawing.Point(170, 364);
            this.txtTelUrgence.Name = "txtTelUrgence";
            this.txtTelUrgence.Size = new System.Drawing.Size(176, 22);
            this.txtTelUrgence.TabIndex = 40;
            // 
            // txtTelPro
            // 
            this.txtTelPro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelPro.Location = new System.Drawing.Point(170, 309);
            this.txtTelPro.Name = "txtTelPro";
            this.txtTelPro.Size = new System.Drawing.Size(176, 22);
            this.txtTelPro.TabIndex = 39;
            // 
            // txtTelDomicile
            // 
            this.txtTelDomicile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelDomicile.Location = new System.Drawing.Point(170, 249);
            this.txtTelDomicile.Name = "txtTelDomicile";
            this.txtTelDomicile.Size = new System.Drawing.Size(176, 22);
            this.txtTelDomicile.TabIndex = 38;
            // 
            // txtCP
            // 
            this.txtCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCP.Location = new System.Drawing.Point(170, 203);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(98, 22);
            this.txtCP.TabIndex = 37;
            // 
            // txtAdresse
            // 
            this.txtAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdresse.Location = new System.Drawing.Point(170, 160);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(282, 22);
            this.txtAdresse.TabIndex = 36;
            // 
            // cbxEtatCivil
            // 
            this.cbxEtatCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEtatCivil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEtatCivil.FormattingEnabled = true;
            this.cbxEtatCivil.Items.AddRange(new object[] {
            "Inassigné",
            "Célibataire",
            "Partenaire Domestique",
            "Marrié-e",
            "Spéparé-e",
            "Veuve / Veuf"});
            this.cbxEtatCivil.Location = new System.Drawing.Point(170, 113);
            this.cbxEtatCivil.Name = "cbxEtatCivil";
            this.cbxEtatCivil.Size = new System.Drawing.Size(163, 24);
            this.cbxEtatCivil.TabIndex = 35;
            // 
            // txtNom
            // 
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Location = new System.Drawing.Point(458, 70);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 22);
            this.txtNom.TabIndex = 34;
            // 
            // txtPrenom2
            // 
            this.txtPrenom2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrenom2.Location = new System.Drawing.Point(352, 70);
            this.txtPrenom2.Name = "txtPrenom2";
            this.txtPrenom2.Size = new System.Drawing.Size(100, 22);
            this.txtPrenom2.TabIndex = 33;
            // 
            // cbxTitre
            // 
            this.cbxTitre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTitre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTitre.FormattingEnabled = true;
            this.cbxTitre.Items.AddRange(new object[] {
            "Mme",
            "Mlle",
            "M",
            "Dr",
            "Prf",
            "Mjr",
            "Cpt",
            "Col"});
            this.cbxTitre.Location = new System.Drawing.Point(170, 69);
            this.cbxTitre.Name = "cbxTitre";
            this.cbxTitre.Size = new System.Drawing.Size(58, 24);
            this.cbxTitre.TabIndex = 32;
            // 
            // txtPrenom
            // 
            this.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrenom.Location = new System.Drawing.Point(246, 70);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 22);
            this.txtPrenom.TabIndex = 31;
            // 
            // lblEmpCP
            // 
            this.lblEmpCP.AutoSize = true;
            this.lblEmpCP.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmpCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEmpCP.Location = new System.Drawing.Point(665, 739);
            this.lblEmpCP.Name = "lblEmpCP";
            this.lblEmpCP.Size = new System.Drawing.Size(88, 16);
            this.lblEmpCP.TabIndex = 30;
            this.lblEmpCP.Text = "Code Postal :";
            // 
            // lblEmpVille
            // 
            this.lblEmpVille.AutoSize = true;
            this.lblEmpVille.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmpVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEmpVille.Location = new System.Drawing.Point(665, 695);
            this.lblEmpVille.Name = "lblEmpVille";
            this.lblEmpVille.Size = new System.Drawing.Size(40, 16);
            this.lblEmpVille.TabIndex = 29;
            this.lblEmpVille.Text = "Ville :";
            // 
            // lblEmpNom
            // 
            this.lblEmpNom.AutoSize = true;
            this.lblEmpNom.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmpNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEmpNom.Location = new System.Drawing.Point(664, 649);
            this.lblEmpNom.Name = "lblEmpNom";
            this.lblEmpNom.Size = new System.Drawing.Size(79, 16);
            this.lblEmpNom.TabIndex = 28;
            this.lblEmpNom.Text = "Employeur :";
            // 
            // lblInstitution
            // 
            this.lblInstitution.AutoSize = true;
            this.lblInstitution.BackColor = System.Drawing.SystemColors.Control;
            this.lblInstitution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblInstitution.Location = new System.Drawing.Point(665, 536);
            this.lblInstitution.Name = "lblInstitution";
            this.lblInstitution.Size = new System.Drawing.Size(68, 16);
            this.lblInstitution.TabIndex = 27;
            this.lblInstitution.Text = "Institution :";
            // 
            // lblNumCarte
            // 
            this.lblNumCarte.AutoSize = true;
            this.lblNumCarte.BackColor = System.Drawing.SystemColors.Control;
            this.lblNumCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNumCarte.Location = new System.Drawing.Point(665, 491);
            this.lblNumCarte.Name = "lblNumCarte";
            this.lblNumCarte.Size = new System.Drawing.Size(78, 32);
            this.lblNumCarte.TabIndex = 26;
            this.lblNumCarte.Text = "Numéro de \r\nla carte :";
            // 
            // lblTelMobile
            // 
            this.lblTelMobile.AutoSize = true;
            this.lblTelMobile.BackColor = System.Drawing.SystemColors.Control;
            this.lblTelMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTelMobile.Location = new System.Drawing.Point(665, 249);
            this.lblTelMobile.Name = "lblTelMobile";
            this.lblTelMobile.Size = new System.Drawing.Size(55, 16);
            this.lblTelMobile.TabIndex = 25;
            this.lblTelMobile.Text = "Mobile :";
            // 
            // lblCanton
            // 
            this.lblCanton.AutoSize = true;
            this.lblCanton.BackColor = System.Drawing.SystemColors.Control;
            this.lblCanton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblCanton.Location = new System.Drawing.Point(665, 203);
            this.lblCanton.Name = "lblCanton";
            this.lblCanton.Size = new System.Drawing.Size(56, 16);
            this.lblCanton.TabIndex = 24;
            this.lblCanton.Text = "Canton :";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.BackColor = System.Drawing.SystemColors.Control;
            this.lblVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblVille.Location = new System.Drawing.Point(665, 160);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(40, 16);
            this.lblVille.TabIndex = 23;
            this.lblVille.Text = "Ville :";
            // 
            // lblOrigine
            // 
            this.lblOrigine.AutoSize = true;
            this.lblOrigine.BackColor = System.Drawing.SystemColors.Control;
            this.lblOrigine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblOrigine.Location = new System.Drawing.Point(665, 114);
            this.lblOrigine.Name = "lblOrigine";
            this.lblOrigine.Size = new System.Drawing.Size(91, 16);
            this.lblOrigine.TabIndex = 22;
            this.lblOrigine.Text = "Originaire de :";
            // 
            // lblNaissance
            // 
            this.lblNaissance.AutoSize = true;
            this.lblNaissance.BackColor = System.Drawing.SystemColors.Control;
            this.lblNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNaissance.Location = new System.Drawing.Point(665, 70);
            this.lblNaissance.Name = "lblNaissance";
            this.lblNaissance.Size = new System.Drawing.Size(79, 16);
            this.lblNaissance.TabIndex = 21;
            this.lblNaissance.Text = "Naissance :";
            // 
            // btnAnnulerNvPat
            // 
            this.btnAnnulerNvPat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnulerNvPat.Location = new System.Drawing.Point(667, 824);
            this.btnAnnulerNvPat.Name = "btnAnnulerNvPat";
            this.btnAnnulerNvPat.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerNvPat.TabIndex = 20;
            this.btnAnnulerNvPat.Text = "Annuler";
            this.btnAnnulerNvPat.UseVisualStyleBackColor = true;
            this.btnAnnulerNvPat.Click += new System.EventHandler(this.btnAnnulerNvPat_Click);
            // 
            // btnConfirmerNvPat
            // 
            this.btnConfirmerNvPat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmerNvPat.Location = new System.Drawing.Point(377, 825);
            this.btnConfirmerNvPat.Name = "btnConfirmerNvPat";
            this.btnConfirmerNvPat.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmerNvPat.TabIndex = 19;
            this.btnConfirmerNvPat.Text = "Confirmer";
            this.btnConfirmerNvPat.UseVisualStyleBackColor = true;
            this.btnConfirmerNvPat.Click += new System.EventHandler(this.btnConfirmerNvPat_Click);
            // 
            // lblEmpPays
            // 
            this.lblEmpPays.AutoSize = true;
            this.lblEmpPays.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmpPays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEmpPays.Location = new System.Drawing.Point(33, 739);
            this.lblEmpPays.Name = "lblEmpPays";
            this.lblEmpPays.Size = new System.Drawing.Size(45, 16);
            this.lblEmpPays.TabIndex = 18;
            this.lblEmpPays.Text = "Pays :";
            // 
            // lblEmpCanton
            // 
            this.lblEmpCanton.AutoSize = true;
            this.lblEmpCanton.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmpCanton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEmpCanton.Location = new System.Drawing.Point(33, 779);
            this.lblEmpCanton.Name = "lblEmpCanton";
            this.lblEmpCanton.Size = new System.Drawing.Size(56, 16);
            this.lblEmpCanton.TabIndex = 17;
            this.lblEmpCanton.Text = "Canton :";
            // 
            // lblEmpAdresse
            // 
            this.lblEmpAdresse.AutoSize = true;
            this.lblEmpAdresse.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmpAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEmpAdresse.Location = new System.Drawing.Point(33, 687);
            this.lblEmpAdresse.Name = "lblEmpAdresse";
            this.lblEmpAdresse.Size = new System.Drawing.Size(84, 32);
            this.lblEmpAdresse.TabIndex = 16;
            this.lblEmpAdresse.Text = "Adresse de\r\nl\'employeur :";
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.BackColor = System.Drawing.SystemColors.Control;
            this.lblOccupation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblOccupation.Location = new System.Drawing.Point(33, 649);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(82, 16);
            this.lblOccupation.TabIndex = 15;
            this.lblOccupation.Text = "Occupation :";
            // 
            // lblNumPolice
            // 
            this.lblNumPolice.AutoSize = true;
            this.lblNumPolice.BackColor = System.Drawing.SystemColors.Control;
            this.lblNumPolice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNumPolice.Location = new System.Drawing.Point(33, 579);
            this.lblNumPolice.Name = "lblNumPolice";
            this.lblNumPolice.Size = new System.Drawing.Size(68, 16);
            this.lblNumPolice.TabIndex = 14;
            this.lblNumPolice.Text = "Police N\' :";
            // 
            // lblNumOfsp
            // 
            this.lblNumOfsp.AutoSize = true;
            this.lblNumOfsp.BackColor = System.Drawing.SystemColors.Control;
            this.lblNumOfsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNumOfsp.Location = new System.Drawing.Point(33, 536);
            this.lblNumOfsp.Name = "lblNumOfsp";
            this.lblNumOfsp.Size = new System.Drawing.Size(101, 16);
            this.lblNumOfsp.TabIndex = 13;
            this.lblNumOfsp.Text = "Numéro OFSP :";
            // 
            // lblNumAvs
            // 
            this.lblNumAvs.AutoSize = true;
            this.lblNumAvs.BackColor = System.Drawing.SystemColors.Control;
            this.lblNumAvs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNumAvs.Location = new System.Drawing.Point(33, 491);
            this.lblNumAvs.Name = "lblNumAvs";
            this.lblNumAvs.Size = new System.Drawing.Size(92, 16);
            this.lblNumAvs.TabIndex = 12;
            this.lblNumAvs.Text = "Numéro AVS :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEmail.Location = new System.Drawing.Point(33, 424);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 16);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email :";
            // 
            // tblTelUrgence
            // 
            this.tblTelUrgence.AutoSize = true;
            this.tblTelUrgence.BackColor = System.Drawing.SystemColors.Control;
            this.tblTelUrgence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tblTelUrgence.Location = new System.Drawing.Point(33, 364);
            this.tblTelUrgence.Name = "tblTelUrgence";
            this.tblTelUrgence.Size = new System.Drawing.Size(77, 32);
            this.tblTelUrgence.TabIndex = 10;
            this.tblTelUrgence.Text = "Téléphone\r\nd\'Urgence :";
            // 
            // lblTelPro
            // 
            this.lblTelPro.AutoSize = true;
            this.lblTelPro.BackColor = System.Drawing.SystemColors.Control;
            this.lblTelPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTelPro.Location = new System.Drawing.Point(33, 309);
            this.lblTelPro.Name = "lblTelPro";
            this.lblTelPro.Size = new System.Drawing.Size(96, 32);
            this.lblTelPro.TabIndex = 9;
            this.lblTelPro.Text = "Téléphone\r\nProfessionnel :";
            // 
            // lblTelDomicile
            // 
            this.lblTelDomicile.AutoSize = true;
            this.lblTelDomicile.BackColor = System.Drawing.SystemColors.Control;
            this.lblTelDomicile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTelDomicile.Location = new System.Drawing.Point(33, 249);
            this.lblTelDomicile.Name = "lblTelDomicile";
            this.lblTelDomicile.Size = new System.Drawing.Size(74, 32);
            this.lblTelDomicile.TabIndex = 8;
            this.lblTelDomicile.Text = "Téléphone\r\nDomicile :";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.BackColor = System.Drawing.SystemColors.Control;
            this.lblCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblCP.Location = new System.Drawing.Point(33, 203);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(87, 16);
            this.lblCP.TabIndex = 7;
            this.lblCP.Text = "Code postal :";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.BackColor = System.Drawing.SystemColors.Control;
            this.lblAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblAdresse.Location = new System.Drawing.Point(33, 160);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(65, 16);
            this.lblAdresse.TabIndex = 6;
            this.lblAdresse.Text = "Adresse :";
            // 
            // lblEtatCivil
            // 
            this.lblEtatCivil.AutoSize = true;
            this.lblEtatCivil.BackColor = System.Drawing.SystemColors.Control;
            this.lblEtatCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEtatCivil.Location = new System.Drawing.Point(33, 114);
            this.lblEtatCivil.Name = "lblEtatCivil";
            this.lblEtatCivil.Size = new System.Drawing.Size(65, 16);
            this.lblEtatCivil.TabIndex = 5;
            this.lblEtatCivil.Text = "Etat Civil :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.SystemColors.Control;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNom.Location = new System.Drawing.Point(33, 70);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(43, 16);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Créer un nouveau Patient";
            // 
            // pnlPatients
            // 
            this.pnlPatients.AutoScroll = true;
            this.pnlPatients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPatients.Controls.Add(this.lblListePatients);
            this.pnlPatients.Controls.Add(this.tblPatients);
            this.pnlPatients.Location = new System.Drawing.Point(0, 51);
            this.pnlPatients.Name = "pnlPatients";
            this.pnlPatients.Size = new System.Drawing.Size(1265, 556);
            this.pnlPatients.TabIndex = 60;
            // 
            // lblListePatients
            // 
            this.lblListePatients.AutoSize = true;
            this.lblListePatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListePatients.Location = new System.Drawing.Point(32, 10);
            this.lblListePatients.Name = "lblListePatients";
            this.lblListePatients.Size = new System.Drawing.Size(152, 20);
            this.lblListePatients.TabIndex = 2;
            this.lblListePatients.Text = "Liste des patients";
            // 
            // tblPatients
            // 
            this.tblPatients.AutoSize = true;
            this.tblPatients.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tblPatients.ColumnCount = 5;
            this.tblPatients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPatients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPatients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPatients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPatients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPatients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPatients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPatients.Location = new System.Drawing.Point(36, 53);
            this.tblPatients.Name = "tblPatients";
            this.tblPatients.RowCount = 1;
            this.tblPatients.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tblPatients.Size = new System.Drawing.Size(1156, 112);
            this.tblPatients.TabIndex = 1;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 606);
            this.Controls.Add(this.pnlPatients);
            this.Controls.Add(this.pnlNouveauPatient);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlRendezvous.ResumeLayout(false);
            this.pnlRendezvous.PerformLayout();
            this.pnlNouveauPatient.ResumeLayout(false);
            this.pnlNouveauPatient.PerformLayout();
            this.pnlPatients.ResumeLayout(false);
            this.pnlPatients.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tblRendezvous;
        private System.Windows.Forms.Panel pnlNouveauPatient;
        private System.Windows.Forms.TextBox txtEmpCP;
        private System.Windows.Forms.TextBox txtEmpVille;
        private System.Windows.Forms.TextBox txtEmpNom;
        private System.Windows.Forms.TextBox txtInstitution;
        private System.Windows.Forms.TextBox txtNumCarte;
        private System.Windows.Forms.TextBox txtTelMobile;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtOrigine;
        private System.Windows.Forms.DateTimePicker dtpNaissance;
        private System.Windows.Forms.ComboBox cbxCanton;
        private System.Windows.Forms.ComboBox cbxEmpCanton;
        private System.Windows.Forms.TextBox txtEmpPays;
        private System.Windows.Forms.TextBox txtEmpAdresse;
        private System.Windows.Forms.TextBox txtOccupation;
        private System.Windows.Forms.TextBox txtNumPolice;
        private System.Windows.Forms.TextBox txtNumOFSP;
        private System.Windows.Forms.TextBox txtNumAvs;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelUrgence;
        private System.Windows.Forms.TextBox txtTelPro;
        private System.Windows.Forms.TextBox txtTelDomicile;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.ComboBox cbxEtatCivil;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom2;
        private System.Windows.Forms.ComboBox cbxTitre;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblEmpCP;
        private System.Windows.Forms.Label lblEmpVille;
        private System.Windows.Forms.Label lblEmpNom;
        private System.Windows.Forms.Label lblInstitution;
        private System.Windows.Forms.Label lblNumCarte;
        private System.Windows.Forms.Label lblTelMobile;
        private System.Windows.Forms.Label lblCanton;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblOrigine;
        private System.Windows.Forms.Label lblNaissance;
        private System.Windows.Forms.Button btnAnnulerNvPat;
        private System.Windows.Forms.Button btnConfirmerNvPat;
        private System.Windows.Forms.Label lblEmpPays;
        private System.Windows.Forms.Label lblEmpCanton;
        private System.Windows.Forms.Label lblEmpAdresse;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.Label lblNumPolice;
        private System.Windows.Forms.Label lblNumOfsp;
        private System.Windows.Forms.Label lblNumAvs;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label tblTelUrgence;
        private System.Windows.Forms.Label lblTelPro;
        private System.Windows.Forms.Label lblTelDomicile;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblEtatCivil;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip ttpARemplir;
        private System.Windows.Forms.Panel pnlPatients;
        private System.Windows.Forms.Label lblListePatients;
        private System.Windows.Forms.TableLayoutPanel tblPatients;
    }
}

