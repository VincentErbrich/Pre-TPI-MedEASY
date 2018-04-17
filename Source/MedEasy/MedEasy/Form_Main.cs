using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MedEasy
{
    public partial class Form_Main : Form
    {
        public bool IsOpened = true;
        private string CurrentPanel;
        public Form_Main()
        {
            InitializeComponent();
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            lblCurrentUser.Text = CurrentUser.UserID;
            CurrentPatient.Id = -1;
            dtpNaissance.MaxDate = DateTime.Now;
            tscbxPatients.SelectedItem = "Patients";
            tscbxVisites.SelectedItem = "Visites";
            tscbxFacturation.SelectedItem = "Facturation";
            tscbxAdministration.SelectedItem = "Administration";
            PanelManager("ListeRendezVous");
        }
        private void PanelManager(string paneltoshow)
        {
            if (CurrentPanel == "NouveauPatient")
            {
                ResetAllPanelFields(pnlNouveauPatient);
            }
            else if(CurrentPanel == "RendezVous")
            {
                ResetAllPanelFields(pnlRendezVous);
            }
            switch (paneltoshow)
            {
                case "ListeRendezVous":
                    HideAllPanels();
                    BuildRendezvousTable();
                    pnlListeRendezVous.Visible = true;
                    CurrentPanel = "ListeRendezVous";
                    break;
                case "NouveauPatient":
                    HideAllPanels();
                    pnlNouveauPatient.Visible = true;
                    CurrentPanel = "NouveauPatient";
                    break;
                case "ListePatients":
                    HideAllPanels();
                    BuildPatientsTable();
                    pnlPatients.Visible = true;
                    CurrentPanel = "ListePatients";
                    break;
                case "RendezVous":
                    HideAllPanels();
                    pnlRendezVous.Visible = true;
                    CurrentPanel = "RendezVous";
                    break;
                case "Visite":
                    HideAllPanels();
                    pnlVisite.Visible = true;
                    CurrentPanel = "Visite";
                    break;
                case "ValidationFacture":
                    HideAllPanels();
                    pnlValidationFacture.Visible = true;
                    CurrentPanel = "ValidationFacture";
                    break;
                default:
                    HideAllPanels();
                    pnlListeRendezVous.Visible = true;
                    break;
            }
        }
        private void HideAllPanels()
        {
            pnlListeRendezVous.Visible = false;
            pnlNouveauPatient.Visible = false;
            pnlPatients.Visible = false;
            pnlRendezVous.Visible = false;
            pnlVisite.Visible = false;
            pnlValidationFacture.Visible = false;
        }
        private bool BuildRendezvousTable()
        {
            tblListeRendezvous.Controls.Clear();
            tblListeRendezvous.RowCount = 1;
            tblListeRendezvous.Controls.Add(new Label() { Text = "ID Patient" }, 0, 0);
            tblListeRendezvous.Controls.Add(new Label() { Text = "Nom" }, 1, 0);
            tblListeRendezvous.Controls.Add(new Label() { Text = "Prénom" }, 2, 0);
            tblListeRendezvous.Controls.Add(new Label() { Text = "Date" }, 3, 0);
            tblListeRendezvous.Controls.Add(new Label() { Text = "Heure d'arrivée" }, 4, 0);
            tblListeRendezvous.Controls.Add(new Label() { Text = "Première consultation" }, 5, 0);
            tblListeRendezvous.Controls.Add(new Label() { Text = "Actions" }, 6, 0);

            try
            {
                Database_Manager db = new Database_Manager();

                SQLiteDataReader results = db.SqlRequest("SELECT C.CON_Premiere_Consultation, C.CON_Date_Heure, C.CON_PAT_FID, P.PAT_Prenom, P.PAT_Nom, C.CON_ID  FROM Consultation C LEFT JOIN Patient P ON C.CON_PAT_FID = P.PAT_ID WHERE C.CON_Visite_Effectuee = 'False' ORDER BY 'C.CON_DATE_HEURE';");
                while (results.Read())
                {
                    DateTime rdvdateheure = (DateTime)results.GetValue(1);

                    Panel pnlActions = BuildActionsPanel("RendezVous", Convert.ToInt32(results.GetValue(5)));
                        
                    tblListeRendezvous.RowCount = tblListeRendezvous.RowCount + 1;
                    tblListeRendezvous.Controls.Add(new Label() { Text = results.GetValue(2).ToString() }, 0, tblListeRendezvous.RowCount -1);
                    tblListeRendezvous.Controls.Add(new Label() { Text = results.GetValue(4).ToString() }, 1, tblListeRendezvous.RowCount - 1);
                    tblListeRendezvous.Controls.Add(new Label() { Text = results.GetValue(3).ToString() }, 2, tblListeRendezvous.RowCount - 1);
                    tblListeRendezvous.Controls.Add(new Label() { Text = rdvdateheure.ToString("yyyy-MM-dd") }, 3, tblListeRendezvous.RowCount - 1);
                    tblListeRendezvous.Controls.Add(new Label() { Text = rdvdateheure.ToString("HH:mm:ss") }, 4, tblListeRendezvous.RowCount - 1);
                    if ((bool)results.GetValue(0) == true)
                    {
                        tblListeRendezvous.Controls.Add(new Label() { Text = "Oui" }, 5, tblListeRendezvous.RowCount - 1);
                    }
                    else
                    {
                        tblListeRendezvous.Controls.Add(new Label() { Text = "Non" }, 5, tblListeRendezvous.RowCount - 1);
                    }
                    tblListeRendezvous.Controls.Add(pnlActions, 6, tblListeRendezvous.RowCount - 1);
                }
                results.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        private bool BuildServicesRendusTable(int idconsultation)
        {
            tlpValidationFacture.Controls.Clear();
            tlpValidationFacture.RowCount = 1;
            tlpValidationFacture.Controls.Add(new Label() { Text = "Type MedEasy" }, 0, 0);
            tlpValidationFacture.Controls.Add(new Label() { Text = "Description" }, 1, 0);
            tlpValidationFacture.Controls.Add(new Label() { Text = "Durée (minutes)" }, 2, 0);
            tlpValidationFacture.Controls.Add(new Label() { Text = "Prix à facturer" }, 3, 0);

            try
            {
                Database_Manager db = new Database_Manager();
                SQLiteDataReader reader = db.SqlRequest("SELECT SR.*, ST.SET_Chf_Minute, ST.SET_Nom FROM Service_Rendu SR INNER JOIN Service_Type ST ON SR.SER_SET_ID = ST.SET_ID WHERE SR.SER_CON_FID IS " + idconsultation);

                while(reader.Read())
                {
                    tlpValidationFacture.RowCount = tlpValidationFacture.RowCount + 1;
                    tlpValidationFacture.Controls.Add(new Label() { Text = reader.GetValue(6).ToString() }, 0, tlpValidationFacture.RowCount - 1);
                    tlpValidationFacture.Controls.Add(new Label() { Text = reader.GetValue(2).ToString() }, 1, tlpValidationFacture.RowCount - 1);
                    tlpValidationFacture.Controls.Add(new Label() { Text = reader.GetValue(1).ToString() }, 2, tlpValidationFacture.RowCount - 1);
                    float duree = Convert.ToSingle(reader.GetValue(1).ToString());
                    float prixpm = Convert.ToSingle(reader.GetValue(5).ToString());
                    float res = duree * prixpm;
                    tlpValidationFacture.Controls.Add(new Label() { Text = Convert.ToString(res) }, 3, tlpValidationFacture.RowCount - 1);
                }
                reader.Close();

                return true;
            }
            catch(Exception e)
            {
                Exception_Manager.NewException(e, "Erreur lors du calcul de la facture", false);
                //PanelManager("ListeRendezVous");
                return false;
            }
        }
        private bool BuildPatientsTable()
        {
            tblPatients.Controls.Clear();
            tblPatients.RowCount = 1;
            tblPatients.Controls.Add(new Label() { Text = "ID Patient" }, 0, 0);
            tblPatients.Controls.Add(new Label() { Text = "Nom" }, 1, 0);
            tblPatients.Controls.Add(new Label() { Text = "Prénom" }, 2, 0);
            tblPatients.Controls.Add(new Label() { Text = "Date de Naissance" }, 3, 0);
            tblPatients.Controls.Add(new Label() { Text = "Numéro AVS" }, 4, 0);
            tblPatients.Controls.Add(new Label() { Text = "Actions" }, 5, 0);

            try
            {
                Database_Manager db = new Database_Manager();

                SQLiteDataReader results = db.SqlRequest("SELECT PAT_ID, PAT_NOM, PAT_PRENOM, PAT_Date_Naissance, PAT_Ass_Numero_Avs FROM Patient");
                while (results.Read())
                {
                    tblPatients.RowCount = tblPatients.RowCount + 1;
                    tblPatients.Controls.Add(new Label() { Text = results.GetValue(0).ToString() }, 0, tblPatients.RowCount - 1);
                    tblPatients.Controls.Add(new Label() { Text = results.GetValue(1).ToString() }, 1, tblPatients.RowCount - 1);
                    tblPatients.Controls.Add(new Label() { Text = results.GetValue(2).ToString() }, 2, tblPatients.RowCount - 1);
                    tblPatients.Controls.Add(new Label() { Text = results.GetDateTime(3).ToString() }, 3, tblPatients.RowCount - 1);
                    tblPatients.Controls.Add(new Label() { Text = results.GetValue(4).ToString() }, 4, tblPatients.RowCount - 1);
                    tblPatients.Controls.Add(BuildActionsPanel("Patient", Convert.ToInt32(results.GetValue(0))), 5, tblPatients.RowCount - 1);
                }
                results.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }
        private void BuildRendezVousForm(bool modifier)
        {
            if(modifier)
            {

            }
            else
            {
                ResetAllPanelFields(pnlRendezVous);
            }
        }
        private void BuildVisiteForm(bool modifier)
        {
            if(modifier)
            {

            }
            else
            {
                rdbVstRdvNon.Checked = true;
                lblVstPatientActif.Text = CurrentPatient.Prenom + CurrentPatient.Nom;
                try
                {
                    Database_Manager db = new Database_Manager();
                    SQLiteDataReader results = db.SqlRequest("SELECT CON_ID, CON_Date_Heure FROM Consultation WHERE CON_PAT_FID IS '" + CurrentPatient.Id + "';");

                    while (results.Read())
                    {
                        cbxVstListeRdv.Items.Add("Rendez-vous " + results.GetValue(0) + " pour le " + results.GetValue(1).ToString());
                    }
                    results.Close();

                    tlpVstServicesRendus.RowCount = 1;
                    tlpVstServicesRendus.Controls.Add(new Label { Text = "Type MedEasy" }, 0, 1);
                    tlpVstServicesRendus.Controls.Add(new Label { Text = "Description" }, 1, 1);
                    tlpVstServicesRendus.Controls.Add(new Label { Text = "Durée (min)" }, 2, 1);
                }
                catch(Exception e)
                {
                    Exception_Manager.NewException(e, "", false);
                }
                cbxVstListeRdv.Enabled = false;
            }
        }
        private void btnDeconnecter_Click(object sender, EventArgs e)
        {
            IsOpened = false;
            Application.Restart();
        }
        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(IsOpened == true)
            {
                Environment.Exit(0);
            }
        }
        private void tsbtnRendezvous_Click(object sender, EventArgs e)
        {
            PanelManager("ListeRendezVous");
        }
        private void btnActions_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (Regex.IsMatch(btn.Name, "btnSelectionnerPatient*"))
            {
                try
                {
                    Database_Manager db = new Database_Manager();
                    SQLiteDataReader results = db.SqlRequest("SELECT PAT_Nom, PAT_Prenom, PAT_Date_Naissance FROM Patient WHERE PAT_ID IS " + Regex.Match(btn.Name, @"\d+$").Value);
                    if(results.Read())
                    {
                        int age = 0;
                        age = DateTime.Now.Year - Convert.ToDateTime(results.GetValue(2)).Year;
                        if (DateTime.Now.DayOfYear < Convert.ToDateTime(results.GetValue(2)).DayOfYear)
                            age--;
                        CurrentPatient.Id = Convert.ToInt32(Regex.Match(btn.Name, @"\d+$").Value);
                        lblPatientactif.Text = (CurrentPatient.Prenom = results.GetValue(1).ToString()) + " " + (CurrentPatient.Nom = results.GetValue(0).ToString());
                        lblPatientactifage.Text = Convert.ToString(CurrentPatient.Age = age);
                    }
                    results.Close();
                }
                catch(Exception ex)
                {
                    Exception_Manager.NewException(ex, "Le patient sélectionné n'a pas pu être trouvé", false);
                }
            }
            else if (Regex.IsMatch(btn.Name, "btnModifierPatient*"))
            {
                MessageBox.Show("Fonctionalitlé en cours de création");
            }
            else if (Regex.IsMatch(btn.Name, "btnSupprimmerPatient*"))
            {
                try
                {
                    Data_Handler.DeletePatient(Convert.ToInt16(Regex.Match(btn.Name, @"\d+$").Value));
                    PanelManager("ListePatients");
                }
                catch(Exception ex)
                {
                    Exception_Manager.NewException(ex, "Le patient sélectionné n'a pas pu être supprimmé", false);
                }
            }
            else if (Regex.IsMatch(btn.Name, "btnModifierRendezVous*"))
            {
                MessageBox.Show("Fonctionalitlé en cours de création");
            }
            else if (Regex.IsMatch(btn.Name, "btnSupprimmerRendezVous*"))
            {
                try
                {
                    Data_Handler.DeleteConsultationRendezVous(Convert.ToInt16(Regex.Match(btn.Name, @"\d+$").Value));
                    PanelManager("RendezVous");
                }
                catch(Exception ex)
                {
                    Exception_Manager.NewException(ex, "Le Rendez-Vous sélectionné n'a pas pu être supprimmé", false);
                }
            }
            else
            {
                Exception_Manager.NewException(new Exception("NoMatchBtnName:" + btn.Name), "L'élément sélectionné n'a pas pu être trouvé", false);
            }
        }
        private void tscbxPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscbxPatients.SelectedItem.ToString() == "Créer")
            {
                PanelManager("NouveauPatient");
            }
            if (tscbxPatients.SelectedItem.ToString() == "Liste")
            {
                PanelManager("ListePatients");
            }
            if (!tscbxPatients.Items.Contains("Patients"))
            {
                tscbxPatients.Items.Add("Patients");
                tscbxPatients.SelectedItem = "Patients";
            }
        }
        private void tscbxVisites_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscbxVisites.SelectedItem.ToString() == "Nouveau Rendez-Vous")
            {
                if (CurrentPatient.Id == -1)
                {
                    DialogResult dialogResult = MessageBox.Show("Un patient doit être sélectionné avant de créer un Rendez-vous.\n Voulez-vous sélectionner un patient ?", "Aucun Patient sélectionné,", MessageBoxButtons.YesNo);
                    if(dialogResult == DialogResult.Yes)
                    {
                        PanelManager("ListePatients");
                    }
                }
                else
                {
                    lblRdvCurrentPatient.Text = CurrentPatient.Prenom + " " + CurrentPatient.Nom;
                    BuildRendezVousForm(false);
                    PanelManager("RendezVous");
                }
            }
            if (tscbxVisites.SelectedItem.ToString() == "Nouvelle Visite")
            {
                if (CurrentPatient.Id == -1)
                {
                    DialogResult dialogResult = MessageBox.Show("Un patient doit être sélectionné avant de créer une visite.\n Voulez-vous sélectionner un patient ?", "Aucun Patient sélectionné,", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        PanelManager("ListePatients");
                    }
                }
                else
                {
                    lblRdvCurrentPatient.Text = CurrentPatient.Prenom + " " + CurrentPatient.Nom;
                    BuildVisiteForm(false);
                    PanelManager("Visite");
                }
            }
            if (!tscbxVisites.Items.Contains("Visites"))
            {
                tscbxVisites.Items.Add("Visites");
                tscbxVisites.SelectedItem = "Visites";
            }
        }
        private void tscbxFacturation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!tscbxFacturation.Items.Contains("Facturation"))
            {
                tscbxFacturation.Items.Add("Facturation");
                tscbxFacturation.SelectedItem = "Facturation";
            }
        }
        private void tscbxAdministration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!tscbxAdministration.Items.Contains("Administration"))
            {
                tscbxAdministration.Items.Add("Administration");
                tscbxAdministration.SelectedItem = "Administration";
            }
        }
        private void btnAnnulerNvPat_Click(object sender, EventArgs e)
        {
            PanelManager("RendezVous");
        }
        private void btnRdvAnnuler_Click(object sender, EventArgs e)
        {
            PanelManager("RendezVous");
        }
        private void ResetAllPanelFields(Panel pnl)
        {
            foreach (Control c in pnl.Controls)
            {
                if(c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    textBox.ResetText();
                }
                else if(c is ComboBox)
                {
                    ComboBox comboBox = c as ComboBox;
                    comboBox.SelectedItem = null;
                }
                else if(c is RadioButton)
                {
                    RadioButton rdb = c as RadioButton;
                    rdb.Checked = false;
                }
                else if (c is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = c as DateTimePicker;
                    dateTimePicker.Value = dateTimePicker.MaxDate;
                }
            }
        }
        private void btnConfirmerNvPat_Click(object sender, EventArgs e)
        {
            int emptyfieldcount = 0;
            foreach (Control c in pnlNouveauPatient.Controls)
            { 
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty && (textBox.Name == txtNom.Name || textBox.Name == txtPrenom.Name || textBox.Name == txtAdresse.Name || textBox.Name == txtCP.Name || textBox.Name == txtOrigine.Name))
                    {
                        emptyfieldcount++;
                        textBox.Focus();
                        textBox.BackColor = Color.Red;
                        if(emptyfieldcount <= 1)
                        {
                            ttpARemplir.Show("Veuillez remplir ce champ", textBox);
                        }
                    }
                    else
                    {
                        textBox.BackColor = DefaultBackColor;
                    }
                }
                if (c is ComboBox)
                {
                    ComboBox comboBox = c as ComboBox;
                    if (comboBox.SelectedItem == null && comboBox.Name != cbxEmpCanton.Name)
                    {
                        emptyfieldcount++;
                        comboBox.Focus();
                        comboBox.BackColor = Color.Red;
                        if (emptyfieldcount <= 1)
                        {
                            ttpARemplir.Show("Veuillez remplir ce champ", comboBox);
                        }
                    }
                    else
                    {
                        comboBox.BackColor = DefaultBackColor;
                    }
                }
            }
            if(emptyfieldcount > 1)
            {
                MessageBox.Show("Veuillez remplir tous les champs en rouge");
            }
            else if(emptyfieldcount == 0)
            {
                if(txtTelDomicile.Text != string.Empty && !UInt64.TryParse(txtTelDomicile.Text.Trim(), out UInt64 trash))
                {
                    ttpARemplir.Show("Veuillez rentrer un numéro valide", txtTelDomicile);
                    txtTelDomicile.BackColor = Color.Red;
                    return;
                }
                else
                {
                    txtTelDomicile.BackColor = TextBox.DefaultBackColor;
                }

                if (txtTelMobile.Text != string.Empty && !UInt64.TryParse(txtTelMobile.Text.Trim(), out trash))
                {
                    ttpARemplir.Show("Veuillez rentrer un numéro valide", txtTelMobile);
                    txtTelMobile.BackColor = Color.Red;
                    return;
                }
                else
                {
                    txtTelMobile.BackColor = TextBox.DefaultBackColor;
                }

                if (txtTelPro.Text != string.Empty && !UInt64.TryParse(txtTelPro.Text.Trim(), out trash))
                {
                    ttpARemplir.Show("Veuillez rentrer un numéro valide", txtTelPro);
                    txtTelPro.BackColor = Color.Red;
                    return;
                }
                else
                {
                    txtTelPro.BackColor = TextBox.DefaultBackColor;
                }

                if (txtTelUrgence.Text != string.Empty && !UInt64.TryParse(txtTelUrgence.Text.Trim(), out trash))
                {
                    ttpARemplir.Show("Veuillez rentrer un numéro valide", txtTelUrgence);
                    txtTelUrgence.BackColor = Color.Red;
                    return;
                }
                else
                {
                    txtTelUrgence.BackColor = TextBox.DefaultBackColor;
                }

                if (txtCP.Text != string.Empty)
                {
                    if (!Regex.IsMatch(txtCP.Text, "[0-9][0-9][0-9][0-9]$"))
                    {
                        ttpARemplir.Show("Veuillez entrer un Code Postal valide", txtCP);
                        txtCP.BackColor = Color.Red;
                        return;
                    }
                }
                else
                {
                    txtCP.BackColor = TextBox.DefaultBackColor;
                }

                if (txtEmpCP.Text != string.Empty)
                {
                    if (!Regex.IsMatch(txtEmpCP.Text, "[0-9][0-9][0-9][0-9]$"))
                    {
                        ttpARemplir.Show("Veuillez entrer un Code Postal valide", txtEmpCP);
                        txtEmpCP.BackColor = Color.Red;
                        return;
                    }
                }
                else
                {
                    txtEmpCP.BackColor = TextBox.DefaultBackColor;
                }

                if ( txtEmail.Text != string.Empty)
                {
                    try { new System.Net.Mail.MailAddress(txtEmail.Text);  }
                    catch
                    {
                        ttpARemplir.Show("Veuillez rentrer une adresse email valide", txtTelPro);
                        txtEmail.BackColor = Color.Red;
                        return;
                    }
                }
                else
                {
                    txtEmail.BackColor = TextBox.DefaultBackColor;
                }

                string canton;
                string titre;
                string etatCivil;
                string cantonEmployeur;

                try { canton = cbxCanton.SelectedItem.ToString(); }
                catch { canton = string.Empty; }

                try { titre = cbxTitre.SelectedItem.ToString(); }
                catch { titre = string.Empty; }

                try { etatCivil = cbxEtatCivil.SelectedItem.ToString(); }
                catch { etatCivil = string.Empty; }

                try { cantonEmployeur = cbxEmpCanton.SelectedItem.ToString(); }
                catch { cantonEmployeur = string.Empty; }

                try
                {
                    Data_Handler.CreatePatient(txtNom.Text.Trim(), txtPrenom.Text.Trim() + "" + txtPrenom2.Text.Trim(), dtpNaissance.Value.Date, titre, etatCivil, txtOrigine.Text.Trim(), txtAdresse.Text.Trim(), txtVille.Text.Trim(), txtCP.Text.Trim(), canton, txtTelMobile.Text.Trim(), txtTelPro.Text.Trim(), txtTelUrgence.Text.Trim(), txtEmail.Text.Trim(), txtEmpNom.Text.Trim(), txtEmpAdresse.Text.Trim(), cantonEmployeur, txtEmpVille.Text.Trim(), txtEmpCP.Text.Trim(), txtEmpPays.Text.Trim(), txtNumAvs.Text.Trim(), txtNumCarte.Text.Trim(), txtNumOFSP.Text.Trim(), txtInstitution.Text.Trim(), txtNumPolice.Text.Trim());
                }
                catch (Exception e2)
                {
                    Exception_Manager.NewException(e2, "Une erreur est survenue durant la création du patient", false);
                }
                finally
                {
                    PanelManager("ListePatients");
                }
            }
        }
        /*
         * Construit un TableLayoutPanel contenant les boutons Modifier, Supprimmer et éventuellement Selectionner
         * ENTREE
         *      string type : Le type de TableLayoutPanel à construire
         *      int id      : L'identifiant à donner aux boutons
         * RETOURNE
         *      Le TableLayoutPanel Contenant les Boutons
         */
        private TableLayoutPanel BuildActionsPanel(string type, int id)
        {
            //Initialise le Panel qui contiendras les boutons d'actions    
            TableLayoutPanel tlp = new TableLayoutPanel
            {
                Size = new Size(110, 55),
                TabIndex = 0,
            };
            //Créé le bouton Modifier et l'identifie
            Button btnModifier = new Button
            {
                //Identifie le bouton Modifier par le type et l'id de l'élément qui à executé la méthode parente dans sa propriété "Name"
                Name = string.Format("btnModifier" + type + id),
                //Règle le texte du bouton en "Modifier"
                Text = "Modifier",
                Width = 100
            };
            //Lie le gestionnaire d'évènements btnActions_Click à l'évènement "Click" de ce bouton
            btnModifier.Click += new EventHandler(btnActions_Click);
            //Ajoute le Bouton Modifier au Panel
            tlp.Controls.Add(btnModifier);

            //Créé le bouton Supprimmer et l'identifie
            Button btnSupprimmer = new Button
            {
                //Identifie le bouton Supprimmer par le type et l'id de l'élément qui à executé la méthode parente dans sa propriété "Name"
                Name = string.Format("btnSupprimmer" + type + id),
                //Règle le texte du bouton en "Supprimmer"
                Text = "Supprimmer",
                Width = 100
            };
            //Lie le gestionnaire d'évènements btnActions_Click à l'évènement "Click" de ce bouton
            btnSupprimmer.Click += new EventHandler(btnActions_Click);
            //Ajoute le Bouton Supprimmer au TableLayoutPanel
            tlp.Controls.Add(btnSupprimmer);

            //Si cette méthode est appellée depuis la méthode "BuildPatientsTable", créé le bouton "Séléctionner" et l'identifie
            if (type == "Patient")
            {
                //Initialise le bouton Selectionner
                Button btnSelectionner = new Button
                {
                    //Identifie le bouton Selectionner par le type et l'id de l'élément qui à executé la méthode parente dans sa propriété "Name"
                    Name = string.Format("btnSelectionner" + type + id),
                    //Règle le texte du bouton en "Supprimmer"
                    Text = "Sélectionner",
                    Width = 100
                };
                //Lie le gestionnaire d'évènements btnActions_Click à l'évènement "Click" de ce bouton
                btnSelectionner.Click += new EventHandler(btnActions_Click);
                //Ajoute le Bouton Selectionner au TableLayoutPanel
                tlp.Height = tlp.Height + 30;
                tlp.Controls.Add(btnSelectionner);
            }
            return tlp;
        }

        private void btnSelectionnerPatient_Click(object sender, EventArgs e)
        {
            PanelManager("ListePatients");
        }

        private void tscbxPatients_DropDown(object sender, EventArgs e)
        {
            tscbxPatients = RemoveToolStripTitle(sender, "Patients");
        }
        private void tscbxPatients_DropDownClosed(object sender, EventArgs e)
        {
            tscbxPatients = AddToolStripTitle(sender, "Patients");
        }

        private void tscbxVisites_DropDown(object sender, EventArgs e)
        {
            tscbxVisites = RemoveToolStripTitle(sender, "Visites");
        }

        private void tscbxVisites_DropDownClosed(object sender, EventArgs e)
        {
            tscbxVisites = AddToolStripTitle(sender, "Visites");
        }
        private void tscbxFacturation_DropDown(object sender, EventArgs e)
        {
            tscbxFacturation = RemoveToolStripTitle(sender, "Facturation");
        }

        private void tscbxFacturation_DropDownClosed(object sender, EventArgs e)
        {
            tscbxFacturation = AddToolStripTitle(sender, "Facturation");
        }

        private void tscbxAdministration_DropDown(object sender, EventArgs e)
        {
            tscbxAdministration = RemoveToolStripTitle(sender, "Administration");
        }

        private void tscbxAdministration_DropDownClosed(object sender, EventArgs e)
        {
            tscbxAdministration = AddToolStripTitle(sender, "Administration");
        }
        private ToolStripComboBox AddToolStripTitle(object sender, string itemtoadd)
        {
            ToolStripComboBox tscbx;
            tscbx = sender as ToolStripComboBox;
            if (tscbx.SelectedItem == null)
            {
                tscbx.Items.Add(itemtoadd);
                tscbx.SelectedItem = itemtoadd;
            }
            return tscbx;
        }
        private ToolStripComboBox RemoveToolStripTitle(object sender, string itemtoremove)
        {
            ToolStripComboBox tscbx;
            tscbx = sender as ToolStripComboBox;
            if (tscbx.Items.Contains(itemtoremove))
                tscbx.Items.Remove(itemtoremove);
            return tscbx;
        }

        private void btnRdvConfirmer_Click(object sender, EventArgs e)
        {
            bool checkedradiobutton = false;
            foreach (Control c in pnlRendezVous.Controls)
            {
                if (c is GroupBox)
                {
                    GroupBox groupBox = c as GroupBox;
                    ttpARemplir.Hide(this);
                    groupBox.BackColor = DefaultBackColor;
                    foreach (RadioButton rdb in groupBox.Controls.OfType<RadioButton>())
                    {
                        if (rdb.Checked)
                        {
                            checkedradiobutton = true;
                            break;
                        }
                        else
                        {
                            checkedradiobutton = false;
                        }

                    }
                    if (checkedradiobutton == false)
                    {
                        ttpARemplir.Show("Veuillez choisir une option", groupBox);
                        groupBox.BackColor = Color.Red;
                        break;
                    }
                }
            }
            if(checkedradiobutton)
            {
                try
                {
                    Data_Handler.CreateRendezVousConsultation(CurrentPatient.Id, rdbRdvPremiereConsultOui.Checked, rdbRdvPremiereConsultOui.Checked, dtpRdvDate.Value, rtbRdvNotes.ToString(), false);
                    PanelManager("ListeRendezVous");
                }
                catch (Exception ex)
                {
                    Exception_Manager.NewException(ex, "Le rendez-vous n'a pas pu être créé", false);
                }
            }
        }
        private void lblDeselectpatient_Click(object sender, EventArgs e)
        {
            CurrentPatient.Id = -1;
            CurrentPatient.Nom = string.Empty;
            CurrentPatient.Prenom = string.Empty;
            CurrentPatient.Age = 0;
            lblPatientactif.Text = "Aucun Patient actif";
            lblPatientactifage.Text = "-";
        }

        private void ChangerPatient_Click(object sender, EventArgs e)
        {
            PanelManager("ListePatients");
        }

        private void btnVstAnnuler_Click(object sender, EventArgs e)
        {
            PanelManager("ListeRendezVous");
        }

        private void btnVstAjouterService_Click(object sender, EventArgs e)
        {
            tlpVstServicesRendus.RowCount++;
            tlpVstServicesRendus.Controls.Add(BuildPointsTypesComboBox("none", tlpVstServicesRendus.RowCount), 0, tlpVstServicesRendus.RowCount);
            tlpVstServicesRendus.Controls.Add(new TextBox { Dock = DockStyle.Fill, Name = "btnServiceDescription" + tlpVstServicesRendus.RowCount.ToString() }, 1, tlpVstServicesRendus.RowCount);
            tlpVstServicesRendus.Controls.Add(new TextBox { Dock = DockStyle.Fill, Name = "btnServiceDuree" + tlpVstServicesRendus.RowCount.ToString() }, 2, tlpVstServicesRendus.RowCount);
        }
        private ComboBox BuildPointsTypesComboBox(string selecteditem, int row)
        {
            ComboBox cbx = new ComboBox();
            cbx.Name = "cbxServiceType" + row;
            cbx.Dock = DockStyle.Fill;
            cbx.Items.Add("Entretien / Collecte d'infos");
            cbx.Items.Add("Examen Physique");
            cbx.Items.Add("Examen Complémentaire");
            cbx.Items.Add("Vaccination / Prise de sang");
            cbx.Items.Add("Chirurgie");
            if (selecteditem != "none")
                cbx.SelectedItem = selecteditem;
            return cbx;
        }

        private void rdbVstRdvOui_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbVstRdvOui.Checked)
            {
                cbxVstListeRdv.Enabled = true;
            }
            else
            {
                cbxVstListeRdv.Enabled = false;
            }
        }

        private void btnVstConfirmer_Click(object sender, EventArgs e)
        {
            int[] id = new int[tlpVstServicesRendus.RowCount];
            string[] description = new string[tlpVstServicesRendus.RowCount];
            int[] minutes = new int[tlpVstServicesRendus.RowCount];
            int i = 0;
            bool error = false;
            int idconsultation;

            foreach (ComboBox c in tlpVstServicesRendus.Controls.OfType<ComboBox>())
            {
                ComboBox cbx = c as ComboBox;
                switch (cbx.SelectedItem)
                {
                    case "Entretien / Collecte d'infos":
                        id[i] = 1;
                        cbx.BackColor = DefaultBackColor;
                        break;
                    case "Examen Physique":
                        id[i] = 2;
                        cbx.BackColor = DefaultBackColor;
                        break;
                    case "Examen Complémentaire":
                        id[i] = 3;
                        cbx.BackColor = DefaultBackColor;
                        break;
                    case "Vaccination / Prise de sang":
                        id[i] = 4;
                        cbx.BackColor = DefaultBackColor;
                        break;
                    case "Chirurgie":
                        id[i] = 5;
                        cbx.BackColor = DefaultBackColor;
                        break;
                    default:
                        error = true;
                        cbx.Focus();
                        ttpARemplir.Show("Veuillez choisir un type", cbx);
                        cbx.BackColor = Color.Red;
                        break;
                }
                i++;
            }
            i = 0;

            foreach (TextBox c in tlpVstServicesRendus.Controls.OfType<TextBox>())
            {
                if (Regex.IsMatch(c.Name, "btnServiceDescription*"))
                {
                    description[i] = c.Text.Trim();
                }
                else
                {
                    try
                    {
                        minutes[i] = Convert.ToInt32(c.Text.Trim());
                        i++;
                    }
                    catch(Exception)
                    {
                        error = true;
                        c.Focus();
                        ttpARemplir.Show("Veuillez entrer un nombre en format numérique", c);
                    }
                }
            }
            if(!error)
            {
                if(rdbVstRdvNon.Checked)
                {
                    SQLiteDataReader reader = Data_Handler.CreateRendezVousConsultation(CurrentPatient.Id, false, false, DateTime.Now, rtbVstNotes.Text, true);
                    reader.Read();
                    idconsultation = Convert.ToInt32(reader.GetValue(0).ToString());
                    reader.Close();
                }
                else
                {
                    Data_Handler.UpdateRendezVousToConsultation(idconsultation = Convert.ToInt32(Regex.Match(cbxVstListeRdv.SelectedItem.ToString(), "(^|\\s)([0-9]+)($|\\s)").ToString()), lblVstNotes.Text.Trim());
                }
                i = 0;
                foreach (int row in id)
                {
                    if(description[i] != null && minutes[i] != 0)
                        Data_Handler.AddServiceToConsultation(row, description[i], minutes[i], idconsultation);
                    i++;
                }
                PanelManager("ValidationFacture");
                BuildServicesRendusTable(idconsultation);
                lblVFIDConsultation.Text = idconsultation.ToString();
                lblVstPatientActif.Text = CurrentPatient.Prenom + CurrentPatient.Nom;
            }
        }

        private void btnVFAnnuler_Click(object sender, EventArgs e)
        {
            PanelManager("ListeRendezVous");
        }

        private void btnVFConfirmer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette fonctionalité n'est pas encore implémentée");
            //Invoice_Generator invoice_Generator = new Invoice_Generator();
            //invoice_Generator.GeneratePdf(Convert.ToInt32(lblVFIDConsultation.Text));
            //PanelManager("ListeRendezVous");
        }
    }
}
