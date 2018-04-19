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
            this.pnlListeRendezVous = new System.Windows.Forms.Panel();
            this.lblListeRendezvousTitre = new System.Windows.Forms.Label();
            this.tblListeRendezvous = new System.Windows.Forms.TableLayoutPanel();
            this.btnRdvConfirmer = new System.Windows.Forms.Button();
            this.btnRdvAnnuler = new System.Windows.Forms.Button();
            this.rtbRdvNotes = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbRdvPremiereConsultNon = new System.Windows.Forms.RadioButton();
            this.rdbRdvPremiereConsultOui = new System.Windows.Forms.RadioButton();
            this.grbRdvRaison = new System.Windows.Forms.GroupBox();
            this.rdbRdvRaisonPbMedical = new System.Windows.Forms.RadioButton();
            this.rdbRdvRaisonVisiteRoutine = new System.Windows.Forms.RadioButton();
            this.lblRdvNotes = new System.Windows.Forms.Label();
            this.lblRdvPremierRdv = new System.Windows.Forms.Label();
            this.lblRdvRaison = new System.Windows.Forms.Label();
            this.lblRdvDate = new System.Windows.Forms.Label();
            this.dtpRdvDate = new System.Windows.Forms.DateTimePicker();
            this.btnRdvChangerPatient = new System.Windows.Forms.Button();
            this.lblRdvCurrentPatient = new System.Windows.Forms.Label();
            this.lblRdvTitre = new System.Windows.Forms.Label();
            this.lblPatientactif = new System.Windows.Forms.Label();
            this.lblPatientactifage = new System.Windows.Forms.Label();
            this.btnDeconnecter = new System.Windows.Forms.Button();
            this.lblDeselectpatient = new System.Windows.Forms.Button();
            this.btnNotifs = new System.Windows.Forms.Button();
            this.btnSelectionnerPatient = new System.Windows.Forms.Button();
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
            this.pnlVisite = new System.Windows.Forms.Panel();
            this.btnVstAjouterService = new System.Windows.Forms.Button();
            this.lblVstServicesRendus = new System.Windows.Forms.Label();
            this.tlpVstServicesRendus = new System.Windows.Forms.TableLayoutPanel();
            this.btnVstAjouterPbMed = new System.Windows.Forms.Button();
            this.lstVstPbMed = new System.Windows.Forms.ListBox();
            this.grpVstRendezvous = new System.Windows.Forms.GroupBox();
            this.cbxVstListeRdv = new System.Windows.Forms.ComboBox();
            this.rdbVstRdvNon = new System.Windows.Forms.RadioButton();
            this.rdbVstRdvOui = new System.Windows.Forms.RadioButton();
            this.btnVstConfirmer = new System.Windows.Forms.Button();
            this.btnVstAnnuler = new System.Windows.Forms.Button();
            this.rtbVstNotes = new System.Windows.Forms.RichTextBox();
            this.lblVstNotes = new System.Windows.Forms.Label();
            this.lblVstPbMed = new System.Windows.Forms.Label();
            this.lblVisiteRendezVous = new System.Windows.Forms.Label();
            this.btnVstChangerPatientActif = new System.Windows.Forms.Button();
            this.lblVstPatientActif = new System.Windows.Forms.Label();
            this.lblVst = new System.Windows.Forms.Label();
            this.pnlRendezVous = new System.Windows.Forms.Panel();
            this.pnlValidationFacture = new System.Windows.Forms.Panel();
            this.lblVFIDConsultation = new System.Windows.Forms.Label();
            this.tlpValidationFacture = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVFConfirmer = new System.Windows.Forms.Button();
            this.btnVFAnnuler = new System.Windows.Forms.Button();
            this.lblValidationFacture = new System.Windows.Forms.Label();
            this.PatientActif = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlListeRendezVous.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbRdvRaison.SuspendLayout();
            this.pnlNouveauPatient.SuspendLayout();
            this.pnlPatients.SuspendLayout();
            this.pnlVisite.SuspendLayout();
            this.grpVstRendezvous.SuspendLayout();
            this.pnlRendezVous.SuspendLayout();
            this.pnlValidationFacture.SuspendLayout();
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
            this.tsbtnRendezvous.Size = new System.Drawing.Size(163, 53);
            this.tsbtnRendezvous.Text = "Rendez Vous";
            this.tsbtnRendezvous.Click += new System.EventHandler(this.tsbtnRendezvous_Click);
            this.tsbtnRendezvous.DoubleClick += new System.EventHandler(this.tsbtnRendezvous_Click);
            // 
            // tscbxPatients
            // 
            this.tscbxPatients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbxPatients.Items.AddRange(new object[] {
            "Patients",
            "Créer",
            "Liste"});
            this.tscbxPatients.Margin = new System.Windows.Forms.Padding(14, 0, 1, 0);
            this.tscbxPatients.Name = "tscbxPatients";
            this.tscbxPatients.Size = new System.Drawing.Size(151, 53);
            this.tscbxPatients.ToolTipText = "Patients";
            this.tscbxPatients.DropDown += new System.EventHandler(this.tscbxPatients_DropDown);
            this.tscbxPatients.DropDownClosed += new System.EventHandler(this.tscbxPatients_DropDownClosed);
            this.tscbxPatients.SelectedIndexChanged += new System.EventHandler(this.tscbxPatients_SelectedIndexChanged);
            // 
            // tscbxVisites
            // 
            this.tscbxVisites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbxVisites.Items.AddRange(new object[] {
            "Visites",
            "Nouveau Rendez-Vous",
            "Nouvelle Visite",
            "Historique"});
            this.tscbxVisites.Margin = new System.Windows.Forms.Padding(14, 0, 1, 0);
            this.tscbxVisites.Name = "tscbxVisites";
            this.tscbxVisites.Size = new System.Drawing.Size(151, 53);
            this.tscbxVisites.DropDown += new System.EventHandler(this.tscbxVisites_DropDown);
            this.tscbxVisites.DropDownClosed += new System.EventHandler(this.tscbxVisites_DropDownClosed);
            this.tscbxVisites.SelectedIndexChanged += new System.EventHandler(this.tscbxVisites_SelectedIndexChanged);
            // 
            // tscbxFacturation
            // 
            this.tscbxFacturation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbxFacturation.Items.AddRange(new object[] {
            "Facturation",
            "Validation des factures",
            "Liste des factures validées"});
            this.tscbxFacturation.Margin = new System.Windows.Forms.Padding(14, 0, 1, 0);
            this.tscbxFacturation.Name = "tscbxFacturation";
            this.tscbxFacturation.Size = new System.Drawing.Size(151, 53);
            this.tscbxFacturation.DropDown += new System.EventHandler(this.tscbxFacturation_DropDown);
            this.tscbxFacturation.DropDownClosed += new System.EventHandler(this.tscbxFacturation_DropDownClosed);
            this.tscbxFacturation.SelectedIndexChanged += new System.EventHandler(this.tscbxFacturation_SelectedIndexChanged);
            // 
            // tscbxAdministration
            // 
            this.tscbxAdministration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbxAdministration.Items.AddRange(new object[] {
            "Administration",
            "Utilisateurs",
            "Sauvegarde"});
            this.tscbxAdministration.Margin = new System.Windows.Forms.Padding(14, 0, 1, 0);
            this.tscbxAdministration.Name = "tscbxAdministration";
            this.tscbxAdministration.Size = new System.Drawing.Size(151, 53);
            this.tscbxAdministration.DropDown += new System.EventHandler(this.tscbxAdministration_DropDown);
            this.tscbxAdministration.DropDownClosed += new System.EventHandler(this.tscbxAdministration_DropDownClosed);
            this.tscbxAdministration.SelectedIndexChanged += new System.EventHandler(this.tscbxAdministration_SelectedIndexChanged);
            // 
            // lblConnecte
            // 
            this.lblConnecte.AutoSize = true;
            this.lblConnecte.BackColor = System.Drawing.SystemColors.Control;
            this.lblConnecte.Location = new System.Drawing.Point(1054, 0);
            this.lblConnecte.Name = "lblConnecte";
            this.lblConnecte.Size = new System.Drawing.Size(269, 30);
            this.lblConnecte.TabIndex = 1;
            this.lblConnecte.Text = "Connecté en tant que :";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.BackColor = System.Drawing.SystemColors.Control;
            this.lblCurrentUser.Location = new System.Drawing.Point(1054, 27);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(22, 30);
            this.lblCurrentUser.TabIndex = 2;
            this.lblCurrentUser.Text = "-";
            // 
            // pnlListeRendezVous
            // 
            this.pnlListeRendezVous.AutoScroll = true;
            this.pnlListeRendezVous.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListeRendezVous.Controls.Add(this.lblListeRendezvousTitre);
            this.pnlListeRendezVous.Controls.Add(this.tblListeRendezvous);
            this.pnlListeRendezVous.Location = new System.Drawing.Point(0, 56);
            this.pnlListeRendezVous.Name = "pnlListeRendezVous";
            this.pnlListeRendezVous.Size = new System.Drawing.Size(1265, 556);
            this.pnlListeRendezVous.TabIndex = 60;
            // 
            // lblListeRendezvousTitre
            // 
            this.lblListeRendezvousTitre.AutoSize = true;
            this.lblListeRendezvousTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeRendezvousTitre.Location = new System.Drawing.Point(32, 10);
            this.lblListeRendezvousTitre.Name = "lblListeRendezvousTitre";
            this.lblListeRendezvousTitre.Size = new System.Drawing.Size(325, 37);
            this.lblListeRendezvousTitre.TabIndex = 2;
            this.lblListeRendezvousTitre.Text = "Rendez-vous à venir";
            // 
            // tblListeRendezvous
            // 
            this.tblListeRendezvous.AutoSize = true;
            this.tblListeRendezvous.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tblListeRendezvous.ColumnCount = 7;
            this.tblListeRendezvous.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblListeRendezvous.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblListeRendezvous.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblListeRendezvous.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblListeRendezvous.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblListeRendezvous.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblListeRendezvous.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblListeRendezvous.Location = new System.Drawing.Point(36, 53);
            this.tblListeRendezvous.Name = "tblListeRendezvous";
            this.tblListeRendezvous.RowCount = 1;
            this.tblListeRendezvous.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tblListeRendezvous.Size = new System.Drawing.Size(1287, 158);
            this.tblListeRendezvous.TabIndex = 1;
            // 
            // btnRdvConfirmer
            // 
            this.btnRdvConfirmer.Location = new System.Drawing.Point(459, 843);
            this.btnRdvConfirmer.Name = "btnRdvConfirmer";
            this.btnRdvConfirmer.Size = new System.Drawing.Size(149, 43);
            this.btnRdvConfirmer.TabIndex = 62;
            this.btnRdvConfirmer.Text = "Confirmer";
            this.btnRdvConfirmer.UseVisualStyleBackColor = true;
            this.btnRdvConfirmer.Click += new System.EventHandler(this.btnRdvConfirmer_Click);
            // 
            // btnRdvAnnuler
            // 
            this.btnRdvAnnuler.Location = new System.Drawing.Point(658, 843);
            this.btnRdvAnnuler.Name = "btnRdvAnnuler";
            this.btnRdvAnnuler.Size = new System.Drawing.Size(117, 43);
            this.btnRdvAnnuler.TabIndex = 61;
            this.btnRdvAnnuler.Text = "Annuler";
            this.btnRdvAnnuler.UseVisualStyleBackColor = true;
            this.btnRdvAnnuler.Click += new System.EventHandler(this.btnRdvAnnuler_Click);
            // 
            // rtbRdvNotes
            // 
            this.rtbRdvNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbRdvNotes.Location = new System.Drawing.Point(665, 564);
            this.rtbRdvNotes.Name = "rtbRdvNotes";
            this.rtbRdvNotes.Size = new System.Drawing.Size(550, 266);
            this.rtbRdvNotes.TabIndex = 16;
            this.rtbRdvNotes.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbRdvPremiereConsultNon);
            this.groupBox1.Controls.Add(this.rdbRdvPremiereConsultOui);
            this.groupBox1.Location = new System.Drawing.Point(665, 442);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 74);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // rdbRdvPremiereConsultNon
            // 
            this.rdbRdvPremiereConsultNon.AutoSize = true;
            this.rdbRdvPremiereConsultNon.Location = new System.Drawing.Point(282, 27);
            this.rdbRdvPremiereConsultNon.Name = "rdbRdvPremiereConsultNon";
            this.rdbRdvPremiereConsultNon.Size = new System.Drawing.Size(91, 34);
            this.rdbRdvPremiereConsultNon.TabIndex = 1;
            this.rdbRdvPremiereConsultNon.TabStop = true;
            this.rdbRdvPremiereConsultNon.Text = "Non";
            this.rdbRdvPremiereConsultNon.UseVisualStyleBackColor = true;
            // 
            // rdbRdvPremiereConsultOui
            // 
            this.rdbRdvPremiereConsultOui.AutoSize = true;
            this.rdbRdvPremiereConsultOui.Location = new System.Drawing.Point(32, 27);
            this.rdbRdvPremiereConsultOui.Name = "rdbRdvPremiereConsultOui";
            this.rdbRdvPremiereConsultOui.Size = new System.Drawing.Size(84, 34);
            this.rdbRdvPremiereConsultOui.TabIndex = 0;
            this.rdbRdvPremiereConsultOui.TabStop = true;
            this.rdbRdvPremiereConsultOui.Text = "Oui";
            this.rdbRdvPremiereConsultOui.UseVisualStyleBackColor = true;
            // 
            // grbRdvRaison
            // 
            this.grbRdvRaison.Controls.Add(this.rdbRdvRaisonPbMedical);
            this.grbRdvRaison.Controls.Add(this.rdbRdvRaisonVisiteRoutine);
            this.grbRdvRaison.Location = new System.Drawing.Point(665, 326);
            this.grbRdvRaison.Name = "grbRdvRaison";
            this.grbRdvRaison.Size = new System.Drawing.Size(528, 74);
            this.grbRdvRaison.TabIndex = 14;
            this.grbRdvRaison.TabStop = false;
            // 
            // rdbRdvRaisonPbMedical
            // 
            this.rdbRdvRaisonPbMedical.AutoSize = true;
            this.rdbRdvRaisonPbMedical.Location = new System.Drawing.Point(282, 27);
            this.rdbRdvRaisonPbMedical.Name = "rdbRdvRaisonPbMedical";
            this.rdbRdvRaisonPbMedical.Size = new System.Drawing.Size(250, 34);
            this.rdbRdvRaisonPbMedical.TabIndex = 1;
            this.rdbRdvRaisonPbMedical.TabStop = true;
            this.rdbRdvRaisonPbMedical.Text = "Problème médical";
            this.rdbRdvRaisonPbMedical.UseVisualStyleBackColor = true;
            // 
            // rdbRdvRaisonVisiteRoutine
            // 
            this.rdbRdvRaisonVisiteRoutine.AutoSize = true;
            this.rdbRdvRaisonVisiteRoutine.Location = new System.Drawing.Point(32, 27);
            this.rdbRdvRaisonVisiteRoutine.Name = "rdbRdvRaisonVisiteRoutine";
            this.rdbRdvRaisonVisiteRoutine.Size = new System.Drawing.Size(227, 34);
            this.rdbRdvRaisonVisiteRoutine.TabIndex = 0;
            this.rdbRdvRaisonVisiteRoutine.TabStop = true;
            this.rdbRdvRaisonVisiteRoutine.Text = "Visite de routine";
            this.rdbRdvRaisonVisiteRoutine.UseVisualStyleBackColor = true;
            // 
            // lblRdvNotes
            // 
            this.lblRdvNotes.AutoSize = true;
            this.lblRdvNotes.BackColor = System.Drawing.SystemColors.Control;
            this.lblRdvNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRdvNotes.Location = new System.Drawing.Point(66, 543);
            this.lblRdvNotes.Name = "lblRdvNotes";
            this.lblRdvNotes.Size = new System.Drawing.Size(89, 29);
            this.lblRdvNotes.TabIndex = 12;
            this.lblRdvNotes.Text = "Notes :";
            // 
            // lblRdvPremierRdv
            // 
            this.lblRdvPremierRdv.AutoSize = true;
            this.lblRdvPremierRdv.BackColor = System.Drawing.SystemColors.Control;
            this.lblRdvPremierRdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRdvPremierRdv.Location = new System.Drawing.Point(67, 462);
            this.lblRdvPremierRdv.Name = "lblRdvPremierRdv";
            this.lblRdvPremierRdv.Size = new System.Drawing.Size(259, 29);
            this.lblRdvPremierRdv.TabIndex = 11;
            this.lblRdvPremierRdv.Text = "Première consultation :";
            // 
            // lblRdvRaison
            // 
            this.lblRdvRaison.AutoSize = true;
            this.lblRdvRaison.BackColor = System.Drawing.SystemColors.Control;
            this.lblRdvRaison.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRdvRaison.Location = new System.Drawing.Point(66, 356);
            this.lblRdvRaison.Name = "lblRdvRaison";
            this.lblRdvRaison.Size = new System.Drawing.Size(280, 29);
            this.lblRdvRaison.TabIndex = 10;
            this.lblRdvRaison.Text = "Raisons de consultation :";
            // 
            // lblRdvDate
            // 
            this.lblRdvDate.AutoSize = true;
            this.lblRdvDate.BackColor = System.Drawing.SystemColors.Control;
            this.lblRdvDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRdvDate.Location = new System.Drawing.Point(66, 250);
            this.lblRdvDate.Name = "lblRdvDate";
            this.lblRdvDate.Size = new System.Drawing.Size(75, 29);
            this.lblRdvDate.TabIndex = 9;
            this.lblRdvDate.Text = "Date :";
            // 
            // dtpRdvDate
            // 
            this.dtpRdvDate.Location = new System.Drawing.Point(665, 250);
            this.dtpRdvDate.Name = "dtpRdvDate";
            this.dtpRdvDate.Size = new System.Drawing.Size(200, 37);
            this.dtpRdvDate.TabIndex = 8;
            // 
            // btnRdvChangerPatient
            // 
            this.btnRdvChangerPatient.Location = new System.Drawing.Point(71, 126);
            this.btnRdvChangerPatient.Name = "btnRdvChangerPatient";
            this.btnRdvChangerPatient.Size = new System.Drawing.Size(117, 37);
            this.btnRdvChangerPatient.TabIndex = 7;
            this.btnRdvChangerPatient.Text = "Changer";
            this.btnRdvChangerPatient.UseVisualStyleBackColor = true;
            this.btnRdvChangerPatient.Click += new System.EventHandler(this.ChangerPatient_Click);
            // 
            // lblRdvCurrentPatient
            // 
            this.lblRdvCurrentPatient.AutoSize = true;
            this.lblRdvCurrentPatient.BackColor = System.Drawing.SystemColors.Control;
            this.lblRdvCurrentPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRdvCurrentPatient.Location = new System.Drawing.Point(66, 81);
            this.lblRdvCurrentPatient.Name = "lblRdvCurrentPatient";
            this.lblRdvCurrentPatient.Size = new System.Drawing.Size(412, 31);
            this.lblRdvCurrentPatient.TabIndex = 60;
            this.lblRdvCurrentPatient.Text = "ERREUR : Pas de patient actif";
            // 
            // lblRdvTitre
            // 
            this.lblRdvTitre.AutoSize = true;
            this.lblRdvTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRdvTitre.Location = new System.Drawing.Point(0, 0);
            this.lblRdvTitre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRdvTitre.Name = "lblRdvTitre";
            this.lblRdvTitre.Size = new System.Drawing.Size(466, 37);
            this.lblRdvTitre.TabIndex = 2;
            this.lblRdvTitre.Text = "Programmer une consultation";
            // 
            // lblPatientactif
            // 
            this.lblPatientactif.AutoSize = true;
            this.lblPatientactif.BackColor = System.Drawing.SystemColors.Control;
            this.lblPatientactif.Location = new System.Drawing.Point(872, 0);
            this.lblPatientactif.Name = "lblPatientactif";
            this.lblPatientactif.Size = new System.Drawing.Size(222, 30);
            this.lblPatientactif.TabIndex = 4;
            this.lblPatientactif.Text = "Aucun patient actif";
            // 
            // lblPatientactifage
            // 
            this.lblPatientactifage.AutoSize = true;
            this.lblPatientactifage.BackColor = System.Drawing.SystemColors.Control;
            this.lblPatientactifage.Location = new System.Drawing.Point(872, 27);
            this.lblPatientactifage.Name = "lblPatientactifage";
            this.lblPatientactifage.Size = new System.Drawing.Size(22, 30);
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
            this.lblDeselectpatient.Click += new System.EventHandler(this.lblDeselectpatient_Click);
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
            // btnSelectionnerPatient
            // 
            this.btnSelectionnerPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectionnerPatient.Location = new System.Drawing.Point(792, 25);
            this.btnSelectionnerPatient.Name = "btnSelectionnerPatient";
            this.btnSelectionnerPatient.Size = new System.Drawing.Size(74, 20);
            this.btnSelectionnerPatient.TabIndex = 8;
            this.btnSelectionnerPatient.Text = "Sélectionner";
            this.btnSelectionnerPatient.UseVisualStyleBackColor = true;
            this.btnSelectionnerPatient.Click += new System.EventHandler(this.btnSelectionnerPatient_Click);
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
            this.pnlNouveauPatient.Location = new System.Drawing.Point(0, 56);
            this.pnlNouveauPatient.Name = "pnlNouveauPatient";
            this.pnlNouveauPatient.Size = new System.Drawing.Size(1265, 556);
            this.pnlNouveauPatient.TabIndex = 5;
            // 
            // txtEmpCP
            // 
            this.txtEmpCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpCP.Location = new System.Drawing.Point(807, 739);
            this.txtEmpCP.Name = "txtEmpCP";
            this.txtEmpCP.Size = new System.Drawing.Size(93, 37);
            this.txtEmpCP.TabIndex = 59;
            // 
            // txtEmpVille
            // 
            this.txtEmpVille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpVille.Location = new System.Drawing.Point(807, 695);
            this.txtEmpVille.Name = "txtEmpVille";
            this.txtEmpVille.Size = new System.Drawing.Size(176, 37);
            this.txtEmpVille.TabIndex = 58;
            // 
            // txtEmpNom
            // 
            this.txtEmpNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpNom.Location = new System.Drawing.Point(807, 649);
            this.txtEmpNom.Name = "txtEmpNom";
            this.txtEmpNom.Size = new System.Drawing.Size(208, 37);
            this.txtEmpNom.TabIndex = 57;
            // 
            // txtInstitution
            // 
            this.txtInstitution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstitution.Location = new System.Drawing.Point(807, 536);
            this.txtInstitution.Name = "txtInstitution";
            this.txtInstitution.Size = new System.Drawing.Size(208, 37);
            this.txtInstitution.TabIndex = 56;
            // 
            // txtNumCarte
            // 
            this.txtNumCarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumCarte.Location = new System.Drawing.Point(807, 491);
            this.txtNumCarte.Name = "txtNumCarte";
            this.txtNumCarte.Size = new System.Drawing.Size(208, 37);
            this.txtNumCarte.TabIndex = 55;
            // 
            // txtTelMobile
            // 
            this.txtTelMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelMobile.Location = new System.Drawing.Point(807, 249);
            this.txtTelMobile.Name = "txtTelMobile";
            this.txtTelMobile.Size = new System.Drawing.Size(176, 37);
            this.txtTelMobile.TabIndex = 54;
            // 
            // txtVille
            // 
            this.txtVille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVille.Location = new System.Drawing.Point(807, 160);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(176, 37);
            this.txtVille.TabIndex = 53;
            // 
            // txtOrigine
            // 
            this.txtOrigine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrigine.Location = new System.Drawing.Point(807, 114);
            this.txtOrigine.Name = "txtOrigine";
            this.txtOrigine.Size = new System.Drawing.Size(208, 37);
            this.txtOrigine.TabIndex = 52;
            // 
            // dtpNaissance
            // 
            this.dtpNaissance.Location = new System.Drawing.Point(807, 70);
            this.dtpNaissance.Name = "dtpNaissance";
            this.dtpNaissance.Size = new System.Drawing.Size(208, 37);
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
            this.cbxCanton.Size = new System.Drawing.Size(208, 38);
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
            this.cbxEmpCanton.Size = new System.Drawing.Size(208, 38);
            this.cbxEmpCanton.TabIndex = 48;
            // 
            // txtEmpPays
            // 
            this.txtEmpPays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpPays.Location = new System.Drawing.Point(170, 739);
            this.txtEmpPays.Name = "txtEmpPays";
            this.txtEmpPays.Size = new System.Drawing.Size(208, 37);
            this.txtEmpPays.TabIndex = 47;
            // 
            // txtEmpAdresse
            // 
            this.txtEmpAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpAdresse.Location = new System.Drawing.Point(170, 695);
            this.txtEmpAdresse.Name = "txtEmpAdresse";
            this.txtEmpAdresse.Size = new System.Drawing.Size(282, 37);
            this.txtEmpAdresse.TabIndex = 46;
            // 
            // txtOccupation
            // 
            this.txtOccupation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOccupation.Location = new System.Drawing.Point(170, 649);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(208, 37);
            this.txtOccupation.TabIndex = 45;
            // 
            // txtNumPolice
            // 
            this.txtNumPolice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumPolice.Location = new System.Drawing.Point(170, 579);
            this.txtNumPolice.Name = "txtNumPolice";
            this.txtNumPolice.Size = new System.Drawing.Size(108, 37);
            this.txtNumPolice.TabIndex = 44;
            // 
            // txtNumOFSP
            // 
            this.txtNumOFSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumOFSP.Location = new System.Drawing.Point(170, 536);
            this.txtNumOFSP.Name = "txtNumOFSP";
            this.txtNumOFSP.Size = new System.Drawing.Size(208, 37);
            this.txtNumOFSP.TabIndex = 43;
            // 
            // txtNumAvs
            // 
            this.txtNumAvs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumAvs.Location = new System.Drawing.Point(170, 491);
            this.txtNumAvs.Name = "txtNumAvs";
            this.txtNumAvs.Size = new System.Drawing.Size(208, 37);
            this.txtNumAvs.TabIndex = 42;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(170, 424);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(208, 37);
            this.txtEmail.TabIndex = 41;
            // 
            // txtTelUrgence
            // 
            this.txtTelUrgence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelUrgence.Location = new System.Drawing.Point(170, 364);
            this.txtTelUrgence.Name = "txtTelUrgence";
            this.txtTelUrgence.Size = new System.Drawing.Size(176, 37);
            this.txtTelUrgence.TabIndex = 40;
            // 
            // txtTelPro
            // 
            this.txtTelPro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelPro.Location = new System.Drawing.Point(170, 309);
            this.txtTelPro.Name = "txtTelPro";
            this.txtTelPro.Size = new System.Drawing.Size(176, 37);
            this.txtTelPro.TabIndex = 39;
            // 
            // txtTelDomicile
            // 
            this.txtTelDomicile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelDomicile.Location = new System.Drawing.Point(170, 249);
            this.txtTelDomicile.Name = "txtTelDomicile";
            this.txtTelDomicile.Size = new System.Drawing.Size(176, 37);
            this.txtTelDomicile.TabIndex = 38;
            // 
            // txtCP
            // 
            this.txtCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCP.Location = new System.Drawing.Point(170, 203);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(98, 37);
            this.txtCP.TabIndex = 37;
            // 
            // txtAdresse
            // 
            this.txtAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdresse.Location = new System.Drawing.Point(170, 160);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(282, 37);
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
            this.cbxEtatCivil.Size = new System.Drawing.Size(163, 38);
            this.cbxEtatCivil.TabIndex = 35;
            // 
            // txtNom
            // 
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Location = new System.Drawing.Point(458, 70);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 37);
            this.txtNom.TabIndex = 34;
            // 
            // txtPrenom2
            // 
            this.txtPrenom2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrenom2.Location = new System.Drawing.Point(352, 70);
            this.txtPrenom2.Name = "txtPrenom2";
            this.txtPrenom2.Size = new System.Drawing.Size(100, 37);
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
            this.cbxTitre.Size = new System.Drawing.Size(58, 38);
            this.cbxTitre.TabIndex = 32;
            // 
            // txtPrenom
            // 
            this.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrenom.Location = new System.Drawing.Point(246, 70);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 37);
            this.txtPrenom.TabIndex = 31;
            // 
            // lblEmpCP
            // 
            this.lblEmpCP.AutoSize = true;
            this.lblEmpCP.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmpCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEmpCP.Location = new System.Drawing.Point(665, 739);
            this.lblEmpCP.Name = "lblEmpCP";
            this.lblEmpCP.Size = new System.Drawing.Size(166, 30);
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
            this.lblEmpVille.Size = new System.Drawing.Size(76, 30);
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
            this.lblEmpNom.Size = new System.Drawing.Size(150, 30);
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
            this.lblInstitution.Size = new System.Drawing.Size(135, 30);
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
            this.lblNumCarte.Size = new System.Drawing.Size(147, 60);
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
            this.lblTelMobile.Size = new System.Drawing.Size(103, 30);
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
            this.lblCanton.Size = new System.Drawing.Size(109, 30);
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
            this.lblVille.Size = new System.Drawing.Size(76, 30);
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
            this.lblOrigine.Size = new System.Drawing.Size(174, 30);
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
            this.lblNaissance.Size = new System.Drawing.Size(147, 30);
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
            this.lblEmpPays.Size = new System.Drawing.Size(84, 30);
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
            this.lblEmpCanton.Size = new System.Drawing.Size(109, 30);
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
            this.lblEmpAdresse.Size = new System.Drawing.Size(158, 60);
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
            this.lblOccupation.Size = new System.Drawing.Size(156, 30);
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
            this.lblNumPolice.Size = new System.Drawing.Size(128, 30);
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
            this.lblNumOfsp.Size = new System.Drawing.Size(196, 30);
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
            this.lblNumAvs.Size = new System.Drawing.Size(177, 30);
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
            this.lblEmail.Size = new System.Drawing.Size(92, 30);
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
            this.tblTelUrgence.Size = new System.Drawing.Size(143, 60);
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
            this.lblTelPro.Size = new System.Drawing.Size(182, 60);
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
            this.lblTelDomicile.Size = new System.Drawing.Size(133, 60);
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
            this.lblCP.Size = new System.Drawing.Size(163, 30);
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
            this.lblAdresse.Size = new System.Drawing.Size(121, 30);
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
            this.lblEtatCivil.Size = new System.Drawing.Size(129, 30);
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
            this.lblNom.Size = new System.Drawing.Size(82, 30);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Créer un nouveau Patient";
            // 
            // pnlPatients
            // 
            this.pnlPatients.AutoScroll = true;
            this.pnlPatients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPatients.Controls.Add(this.lblListePatients);
            this.pnlPatients.Controls.Add(this.tblPatients);
            this.pnlPatients.Location = new System.Drawing.Point(0, 56);
            this.pnlPatients.Name = "pnlPatients";
            this.pnlPatients.Size = new System.Drawing.Size(1265, 552);
            this.pnlPatients.TabIndex = 60;
            // 
            // lblListePatients
            // 
            this.lblListePatients.AutoSize = true;
            this.lblListePatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListePatients.Location = new System.Drawing.Point(32, 10);
            this.lblListePatients.Name = "lblListePatients";
            this.lblListePatients.Size = new System.Drawing.Size(283, 37);
            this.lblListePatients.TabIndex = 2;
            this.lblListePatients.Text = "Liste des patients";
            // 
            // tblPatients
            // 
            this.tblPatients.AutoSize = true;
            this.tblPatients.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tblPatients.ColumnCount = 6;
            this.tblPatients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPatients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPatients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPatients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPatients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPatients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPatients.Location = new System.Drawing.Point(36, 53);
            this.tblPatients.Name = "tblPatients";
            this.tblPatients.RowCount = 1;
            this.tblPatients.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tblPatients.Size = new System.Drawing.Size(1285, 156);
            this.tblPatients.TabIndex = 1;
            // 
            // pnlVisite
            // 
            this.pnlVisite.AutoScroll = true;
            this.pnlVisite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVisite.Controls.Add(this.btnVstAjouterService);
            this.pnlVisite.Controls.Add(this.lblVstServicesRendus);
            this.pnlVisite.Controls.Add(this.tlpVstServicesRendus);
            this.pnlVisite.Controls.Add(this.btnVstAjouterPbMed);
            this.pnlVisite.Controls.Add(this.lstVstPbMed);
            this.pnlVisite.Controls.Add(this.grpVstRendezvous);
            this.pnlVisite.Controls.Add(this.btnVstConfirmer);
            this.pnlVisite.Controls.Add(this.btnVstAnnuler);
            this.pnlVisite.Controls.Add(this.rtbVstNotes);
            this.pnlVisite.Controls.Add(this.lblVstNotes);
            this.pnlVisite.Controls.Add(this.lblVstPbMed);
            this.pnlVisite.Controls.Add(this.lblVisiteRendezVous);
            this.pnlVisite.Controls.Add(this.btnVstChangerPatientActif);
            this.pnlVisite.Controls.Add(this.lblVstPatientActif);
            this.pnlVisite.Controls.Add(this.lblVst);
            this.pnlVisite.Location = new System.Drawing.Point(0, 56);
            this.pnlVisite.Name = "pnlVisite";
            this.pnlVisite.Size = new System.Drawing.Size(1265, 556);
            this.pnlVisite.TabIndex = 63;
            // 
            // btnVstAjouterService
            // 
            this.btnVstAjouterService.Location = new System.Drawing.Point(1119, 939);
            this.btnVstAjouterService.Name = "btnVstAjouterService";
            this.btnVstAjouterService.Size = new System.Drawing.Size(111, 37);
            this.btnVstAjouterService.TabIndex = 68;
            this.btnVstAjouterService.Text = "Ajouter";
            this.btnVstAjouterService.UseVisualStyleBackColor = true;
            this.btnVstAjouterService.Click += new System.EventHandler(this.btnVstAjouterService_Click);
            // 
            // lblVstServicesRendus
            // 
            this.lblVstServicesRendus.AutoSize = true;
            this.lblVstServicesRendus.BackColor = System.Drawing.SystemColors.Control;
            this.lblVstServicesRendus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVstServicesRendus.Location = new System.Drawing.Point(66, 695);
            this.lblVstServicesRendus.Name = "lblVstServicesRendus";
            this.lblVstServicesRendus.Size = new System.Drawing.Size(198, 29);
            this.lblVstServicesRendus.TabIndex = 67;
            this.lblVstServicesRendus.Text = "Services rendus :";
            // 
            // tlpVstServicesRendus
            // 
            this.tlpVstServicesRendus.BackColor = System.Drawing.SystemColors.Window;
            this.tlpVstServicesRendus.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpVstServicesRendus.ColumnCount = 3;
            this.tlpVstServicesRendus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tlpVstServicesRendus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85715F));
            this.tlpVstServicesRendus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tlpVstServicesRendus.Location = new System.Drawing.Point(440, 696);
            this.tlpVstServicesRendus.Name = "tlpVstServicesRendus";
            this.tlpVstServicesRendus.RowCount = 1;
            this.tlpVstServicesRendus.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVstServicesRendus.Size = new System.Drawing.Size(790, 237);
            this.tlpVstServicesRendus.TabIndex = 0;
            // 
            // btnVstAjouterPbMed
            // 
            this.btnVstAjouterPbMed.Location = new System.Drawing.Point(1116, 638);
            this.btnVstAjouterPbMed.Name = "btnVstAjouterPbMed";
            this.btnVstAjouterPbMed.Size = new System.Drawing.Size(111, 37);
            this.btnVstAjouterPbMed.TabIndex = 65;
            this.btnVstAjouterPbMed.Text = "Ajouter";
            this.btnVstAjouterPbMed.UseVisualStyleBackColor = true;
            // 
            // lstVstPbMed
            // 
            this.lstVstPbMed.FormattingEnabled = true;
            this.lstVstPbMed.ItemHeight = 30;
            this.lstVstPbMed.Location = new System.Drawing.Point(440, 356);
            this.lstVstPbMed.Name = "lstVstPbMed";
            this.lstVstPbMed.Size = new System.Drawing.Size(790, 274);
            this.lstVstPbMed.TabIndex = 64;
            // 
            // grpVstRendezvous
            // 
            this.grpVstRendezvous.Controls.Add(this.cbxVstListeRdv);
            this.grpVstRendezvous.Controls.Add(this.rdbVstRdvNon);
            this.grpVstRendezvous.Controls.Add(this.rdbVstRdvOui);
            this.grpVstRendezvous.Location = new System.Drawing.Point(440, 228);
            this.grpVstRendezvous.Name = "grpVstRendezvous";
            this.grpVstRendezvous.Size = new System.Drawing.Size(790, 84);
            this.grpVstRendezvous.TabIndex = 63;
            this.grpVstRendezvous.TabStop = false;
            // 
            // cbxVstListeRdv
            // 
            this.cbxVstListeRdv.FormattingEnabled = true;
            this.cbxVstListeRdv.Location = new System.Drawing.Point(174, 38);
            this.cbxVstListeRdv.Name = "cbxVstListeRdv";
            this.cbxVstListeRdv.Size = new System.Drawing.Size(418, 38);
            this.cbxVstListeRdv.TabIndex = 2;
            // 
            // rdbVstRdvNon
            // 
            this.rdbVstRdvNon.AutoSize = true;
            this.rdbVstRdvNon.Location = new System.Drawing.Point(664, 34);
            this.rdbVstRdvNon.Name = "rdbVstRdvNon";
            this.rdbVstRdvNon.Size = new System.Drawing.Size(91, 34);
            this.rdbVstRdvNon.TabIndex = 1;
            this.rdbVstRdvNon.TabStop = true;
            this.rdbVstRdvNon.Text = "Non";
            this.rdbVstRdvNon.UseVisualStyleBackColor = true;
            // 
            // rdbVstRdvOui
            // 
            this.rdbVstRdvOui.AutoSize = true;
            this.rdbVstRdvOui.Location = new System.Drawing.Point(21, 35);
            this.rdbVstRdvOui.Name = "rdbVstRdvOui";
            this.rdbVstRdvOui.Size = new System.Drawing.Size(84, 34);
            this.rdbVstRdvOui.TabIndex = 0;
            this.rdbVstRdvOui.TabStop = true;
            this.rdbVstRdvOui.Text = "Oui";
            this.rdbVstRdvOui.UseVisualStyleBackColor = true;
            this.rdbVstRdvOui.CheckedChanged += new System.EventHandler(this.rdbVstRdvOui_CheckedChanged);
            // 
            // btnVstConfirmer
            // 
            this.btnVstConfirmer.Location = new System.Drawing.Point(448, 1293);
            this.btnVstConfirmer.Name = "btnVstConfirmer";
            this.btnVstConfirmer.Size = new System.Drawing.Size(149, 43);
            this.btnVstConfirmer.TabIndex = 62;
            this.btnVstConfirmer.Text = "Confirmer";
            this.btnVstConfirmer.UseVisualStyleBackColor = true;
            this.btnVstConfirmer.Click += new System.EventHandler(this.btnVstConfirmer_Click);
            // 
            // btnVstAnnuler
            // 
            this.btnVstAnnuler.Location = new System.Drawing.Point(665, 1293);
            this.btnVstAnnuler.Name = "btnVstAnnuler";
            this.btnVstAnnuler.Size = new System.Drawing.Size(117, 43);
            this.btnVstAnnuler.TabIndex = 61;
            this.btnVstAnnuler.Text = "Annuler";
            this.btnVstAnnuler.UseVisualStyleBackColor = true;
            this.btnVstAnnuler.Click += new System.EventHandler(this.btnVstAnnuler_Click);
            // 
            // rtbVstNotes
            // 
            this.rtbVstNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbVstNotes.Location = new System.Drawing.Point(437, 1016);
            this.rtbVstNotes.Name = "rtbVstNotes";
            this.rtbVstNotes.Size = new System.Drawing.Size(793, 266);
            this.rtbVstNotes.TabIndex = 16;
            this.rtbVstNotes.Text = "";
            // 
            // lblVstNotes
            // 
            this.lblVstNotes.AutoSize = true;
            this.lblVstNotes.BackColor = System.Drawing.SystemColors.Control;
            this.lblVstNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVstNotes.Location = new System.Drawing.Point(84, 1016);
            this.lblVstNotes.Name = "lblVstNotes";
            this.lblVstNotes.Size = new System.Drawing.Size(89, 29);
            this.lblVstNotes.TabIndex = 12;
            this.lblVstNotes.Text = "Notes :";
            // 
            // lblVstPbMed
            // 
            this.lblVstPbMed.AutoSize = true;
            this.lblVstPbMed.BackColor = System.Drawing.SystemColors.Control;
            this.lblVstPbMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVstPbMed.Location = new System.Drawing.Point(66, 356);
            this.lblVstPbMed.Name = "lblVstPbMed";
            this.lblVstPbMed.Size = new System.Drawing.Size(240, 29);
            this.lblVstPbMed.TabIndex = 10;
            this.lblVstPbMed.Text = "Problèmes médicaux";
            // 
            // lblVisiteRendezVous
            // 
            this.lblVisiteRendezVous.AutoSize = true;
            this.lblVisiteRendezVous.BackColor = System.Drawing.SystemColors.Control;
            this.lblVisiteRendezVous.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisiteRendezVous.Location = new System.Drawing.Point(66, 250);
            this.lblVisiteRendezVous.Name = "lblVisiteRendezVous";
            this.lblVisiteRendezVous.Size = new System.Drawing.Size(261, 29);
            this.lblVisiteRendezVous.TabIndex = 9;
            this.lblVisiteRendezVous.Text = "Visite sur rendez-vous :";
            // 
            // btnVstChangerPatientActif
            // 
            this.btnVstChangerPatientActif.Location = new System.Drawing.Point(71, 126);
            this.btnVstChangerPatientActif.Name = "btnVstChangerPatientActif";
            this.btnVstChangerPatientActif.Size = new System.Drawing.Size(134, 37);
            this.btnVstChangerPatientActif.TabIndex = 7;
            this.btnVstChangerPatientActif.Text = "Changer";
            this.btnVstChangerPatientActif.UseVisualStyleBackColor = true;
            this.btnVstChangerPatientActif.Click += new System.EventHandler(this.ChangerPatient_Click);
            // 
            // lblVstPatientActif
            // 
            this.lblVstPatientActif.AutoSize = true;
            this.lblVstPatientActif.BackColor = System.Drawing.SystemColors.Control;
            this.lblVstPatientActif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVstPatientActif.Location = new System.Drawing.Point(66, 81);
            this.lblVstPatientActif.Name = "lblVstPatientActif";
            this.lblVstPatientActif.Size = new System.Drawing.Size(412, 31);
            this.lblVstPatientActif.TabIndex = 60;
            this.lblVstPatientActif.Text = "ERREUR : Pas de patient actif";
            // 
            // lblVst
            // 
            this.lblVst.AutoSize = true;
            this.lblVst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVst.Location = new System.Drawing.Point(64, 19);
            this.lblVst.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblVst.Name = "lblVst";
            this.lblVst.Size = new System.Drawing.Size(475, 37);
            this.lblVst.TabIndex = 2;
            this.lblVst.Text = "Création d\'un rapport de visite";
            // 
            // pnlRendezVous
            // 
            this.pnlRendezVous.AutoScroll = true;
            this.pnlRendezVous.Controls.Add(this.btnRdvConfirmer);
            this.pnlRendezVous.Controls.Add(this.lblRdvTitre);
            this.pnlRendezVous.Controls.Add(this.btnRdvAnnuler);
            this.pnlRendezVous.Controls.Add(this.rtbRdvNotes);
            this.pnlRendezVous.Controls.Add(this.grbRdvRaison);
            this.pnlRendezVous.Controls.Add(this.groupBox1);
            this.pnlRendezVous.Controls.Add(this.lblRdvPremierRdv);
            this.pnlRendezVous.Controls.Add(this.lblRdvRaison);
            this.pnlRendezVous.Controls.Add(this.lblRdvDate);
            this.pnlRendezVous.Controls.Add(this.dtpRdvDate);
            this.pnlRendezVous.Controls.Add(this.btnRdvChangerPatient);
            this.pnlRendezVous.Controls.Add(this.lblRdvCurrentPatient);
            this.pnlRendezVous.Controls.Add(this.lblRdvNotes);
            this.pnlRendezVous.Location = new System.Drawing.Point(0, 56);
            this.pnlRendezVous.Name = "pnlRendezVous";
            this.pnlRendezVous.Size = new System.Drawing.Size(1265, 556);
            this.pnlRendezVous.TabIndex = 64;
            // 
            // pnlValidationFacture
            // 
            this.pnlValidationFacture.AutoScroll = true;
            this.pnlValidationFacture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlValidationFacture.Controls.Add(this.label1);
            this.pnlValidationFacture.Controls.Add(this.PatientActif);
            this.pnlValidationFacture.Controls.Add(this.lblVFIDConsultation);
            this.pnlValidationFacture.Controls.Add(this.tlpValidationFacture);
            this.pnlValidationFacture.Controls.Add(this.groupBox2);
            this.pnlValidationFacture.Controls.Add(this.btnVFConfirmer);
            this.pnlValidationFacture.Controls.Add(this.btnVFAnnuler);
            this.pnlValidationFacture.Controls.Add(this.lblValidationFacture);
            this.pnlValidationFacture.Location = new System.Drawing.Point(0, 56);
            this.pnlValidationFacture.Name = "pnlValidationFacture";
            this.pnlValidationFacture.Size = new System.Drawing.Size(1265, 556);
            this.pnlValidationFacture.TabIndex = 69;
            // 
            // lblVFIDConsultation
            // 
            this.lblVFIDConsultation.AutoSize = true;
            this.lblVFIDConsultation.BackColor = System.Drawing.SystemColors.Control;
            this.lblVFIDConsultation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVFIDConsultation.Location = new System.Drawing.Point(259, 86);
            this.lblVFIDConsultation.Name = "lblVFIDConsultation";
            this.lblVFIDConsultation.Size = new System.Drawing.Size(166, 29);
            this.lblVFIDConsultation.TabIndex = 67;
            this.lblVFIDConsultation.Text = "IdConsultation";
            // 
            // tlpValidationFacture
            // 
            this.tlpValidationFacture.BackColor = System.Drawing.SystemColors.Window;
            this.tlpValidationFacture.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpValidationFacture.ColumnCount = 4;
            this.tlpValidationFacture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpValidationFacture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpValidationFacture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpValidationFacture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpValidationFacture.Location = new System.Drawing.Point(440, 86);
            this.tlpValidationFacture.Name = "tlpValidationFacture";
            this.tlpValidationFacture.RowCount = 1;
            this.tlpValidationFacture.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpValidationFacture.Size = new System.Drawing.Size(790, 237);
            this.tlpValidationFacture.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(440, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(790, 84);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            // 
            // btnVFConfirmer
            // 
            this.btnVFConfirmer.Location = new System.Drawing.Point(448, 363);
            this.btnVFConfirmer.Name = "btnVFConfirmer";
            this.btnVFConfirmer.Size = new System.Drawing.Size(149, 43);
            this.btnVFConfirmer.TabIndex = 62;
            this.btnVFConfirmer.Text = "Valider";
            this.btnVFConfirmer.UseVisualStyleBackColor = true;
            this.btnVFConfirmer.Click += new System.EventHandler(this.btnVFConfirmer_Click);
            // 
            // btnVFAnnuler
            // 
            this.btnVFAnnuler.Location = new System.Drawing.Point(665, 363);
            this.btnVFAnnuler.Name = "btnVFAnnuler";
            this.btnVFAnnuler.Size = new System.Drawing.Size(117, 43);
            this.btnVFAnnuler.TabIndex = 61;
            this.btnVFAnnuler.Text = "Annuler";
            this.btnVFAnnuler.UseVisualStyleBackColor = true;
            this.btnVFAnnuler.Click += new System.EventHandler(this.btnVFAnnuler_Click);
            // 
            // lblValidationFacture
            // 
            this.lblValidationFacture.AutoSize = true;
            this.lblValidationFacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidationFacture.Location = new System.Drawing.Point(64, 19);
            this.lblValidationFacture.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblValidationFacture.Name = "lblValidationFacture";
            this.lblValidationFacture.Size = new System.Drawing.Size(331, 37);
            this.lblValidationFacture.TabIndex = 2;
            this.lblValidationFacture.Text = "Validation de facture";
            // 
            // PatientActif
            // 
            this.PatientActif.AutoSize = true;
            this.PatientActif.BackColor = System.Drawing.SystemColors.Control;
            this.PatientActif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientActif.Location = new System.Drawing.Point(68, 134);
            this.PatientActif.Name = "PatientActif";
            this.PatientActif.Size = new System.Drawing.Size(247, 29);
            this.PatientActif.TabIndex = 68;
            this.PatientActif.Text = "PatientActif DateVisite";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 69;
            this.label1.Text = "ID Consultation :";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 606);
            this.Controls.Add(this.pnlValidationFacture);
            this.Controls.Add(this.btnSelectionnerPatient);
            this.Controls.Add(this.btnNotifs);
            this.Controls.Add(this.lblDeselectpatient);
            this.Controls.Add(this.btnDeconnecter);
            this.Controls.Add(this.lblPatientactifage);
            this.Controls.Add(this.lblPatientactif);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.lblConnecte);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlVisite);
            this.Controls.Add(this.pnlListeRendezVous);
            this.Controls.Add(this.pnlNouveauPatient);
            this.Controls.Add(this.pnlRendezVous);
            this.Controls.Add(this.pnlPatients);
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
            this.pnlListeRendezVous.ResumeLayout(false);
            this.pnlListeRendezVous.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbRdvRaison.ResumeLayout(false);
            this.grbRdvRaison.PerformLayout();
            this.pnlNouveauPatient.ResumeLayout(false);
            this.pnlNouveauPatient.PerformLayout();
            this.pnlPatients.ResumeLayout(false);
            this.pnlPatients.PerformLayout();
            this.pnlVisite.ResumeLayout(false);
            this.pnlVisite.PerformLayout();
            this.grpVstRendezvous.ResumeLayout(false);
            this.grpVstRendezvous.PerformLayout();
            this.pnlRendezVous.ResumeLayout(false);
            this.pnlRendezVous.PerformLayout();
            this.pnlValidationFacture.ResumeLayout(false);
            this.pnlValidationFacture.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblConnecte;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Panel pnlListeRendezVous;
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
        private System.Windows.Forms.Button btnSelectionnerPatient;
        private System.Windows.Forms.Label lblListeRendezvousTitre;
        private System.Windows.Forms.TableLayoutPanel tblListeRendezvous;
        private System.Windows.Forms.Panel pnlNouveauPatient;
        private System.Windows.Forms.Panel pnlVisite;
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
        private System.Windows.Forms.RichTextBox rtbRdvNotes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbRdvPremiereConsultNon;
        private System.Windows.Forms.RadioButton rdbRdvPremiereConsultOui;
        private System.Windows.Forms.GroupBox grbRdvRaison;
        private System.Windows.Forms.RadioButton rdbRdvRaisonPbMedical;
        private System.Windows.Forms.RadioButton rdbRdvRaisonVisiteRoutine;
        private System.Windows.Forms.Label lblRdvNotes;
        private System.Windows.Forms.Label lblRdvPremierRdv;
        private System.Windows.Forms.Label lblRdvRaison;
        private System.Windows.Forms.Label lblRdvDate;
        private System.Windows.Forms.DateTimePicker dtpRdvDate;
        private System.Windows.Forms.Button btnRdvChangerPatient;
        private System.Windows.Forms.Label lblRdvCurrentPatient;
        private System.Windows.Forms.Label lblRdvTitre;
        private System.Windows.Forms.Button btnRdvConfirmer;
        private System.Windows.Forms.Button btnRdvAnnuler;
        private System.Windows.Forms.Button btnVstAjouterService;
        private System.Windows.Forms.Label lblVstServicesRendus;
        private System.Windows.Forms.TableLayoutPanel tlpVstServicesRendus;
        private System.Windows.Forms.Button btnVstAjouterPbMed;
        private System.Windows.Forms.ListBox lstVstPbMed;
        private System.Windows.Forms.GroupBox grpVstRendezvous;
        private System.Windows.Forms.ComboBox cbxVstListeRdv;
        private System.Windows.Forms.RadioButton rdbVstRdvNon;
        private System.Windows.Forms.RadioButton rdbVstRdvOui;
        private System.Windows.Forms.Button btnVstConfirmer;
        private System.Windows.Forms.Button btnVstAnnuler;
        private System.Windows.Forms.RichTextBox rtbVstNotes;
        private System.Windows.Forms.Label lblVstNotes;
        private System.Windows.Forms.Label lblVstPbMed;
        private System.Windows.Forms.Label lblVisiteRendezVous;
        private System.Windows.Forms.Button btnVstChangerPatientActif;
        private System.Windows.Forms.Label lblVstPatientActif;
        private System.Windows.Forms.Label lblVst;
        private System.Windows.Forms.Panel pnlRendezVous;
        private System.Windows.Forms.Panel pnlValidationFacture;
        private System.Windows.Forms.Label lblVFIDConsultation;
        private System.Windows.Forms.TableLayoutPanel tlpValidationFacture;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVFConfirmer;
        private System.Windows.Forms.Button btnVFAnnuler;
        private System.Windows.Forms.Label lblValidationFacture;
        private System.Windows.Forms.Label PatientActif;
        private System.Windows.Forms.Label label1;
    }
}

