using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;


namespace MedEasy
{
    public partial class Form_Main : Form
    {
        public bool opened = true;
        public Form_Main()
        {
            InitializeComponent();
        }
        private string CurrentPanel;
        private void Form_Main_Load(object sender, EventArgs e)
        {
            lblCurrentUser.Text = CurrentUser.UserID;
            this.dtpNaissance.MaxDate = DateTime.Now;
            BuildRendezvousTable();
            PanelManager("RendezVous");
        }
        private void PanelManager(string paneltoshow)
        {
            switch (paneltoshow)
            {
                case "RendezVous":
                    HideAllPanels();
                    pnlRendezvous.Visible = true;
                    break;
                case "NouveauPatient":
                    HideAllPanels();
                    pnlNouveauPatient.Visible = true;
                    break;
                default:
                    HideAllPanels();
                    pnlRendezvous.Visible = true;
                    break;
            }
        }
        private void HideAllPanels()
        {
            pnlRendezvous.Visible = false;
            pnlNouveauPatient.Visible = false;
        }
        private bool BuildRendezvousTable()
        {
            tblRendezvous.ResetText();
            tblRendezvous.Controls.Add(new Label() { Text = "ID Patient" }, 0, 0);
            tblRendezvous.Controls.Add(new Label() { Text = "Nom" }, 1, 0);
            tblRendezvous.Controls.Add(new Label() { Text = "Prénom" }, 2, 0);
            tblRendezvous.Controls.Add(new Label() { Text = "Date" }, 3, 0);
            tblRendezvous.Controls.Add(new Label() { Text = "Heure d'arrivée" }, 4, 0);
            tblRendezvous.Controls.Add(new Label() { Text = "Première consultation" }, 5, 0);
            tblRendezvous.Controls.Add(new Label() { Text = "Actions" }, 6, 0);

            Database_Manager db = new Database_Manager();
            db.Connexion();

            SQLiteDataReader results = db.SqlRequest("SELECT C.CON_Premiere_Consultation, C.CON_Date_Heure, C.CON_PAT_FID, P.PAT_Prenom, P.PAT_Nom, C.CON_ID  FROM Consultation C LEFT JOIN Patient P ON C.CON_PAT_FID = P.PAT_ID WHERE C.CON_Visite_Effectuee = 'false' ORDER BY 'C.CON_DATE_HEURE';");
            try
            {
                while (results.Read())
                {
                    for(int i = 1;  i <= results.StepCount; i++)
                    {
                        DateTime rdvdateheure = (DateTime)results.GetValue(1);
                        string rdvidpatient = results.GetValue(2).ToString();
                        string rdvprenom = results.GetValue(3).ToString();
                        string rdvnom = results.GetValue(4).ToString();
                        int rdvid = results.GetInt32(5);
                        string rdvpremier;
                        if ((bool)results.GetValue(0) == true)
                        {
                            rdvpremier = "Oui";
                        }
                        else
                        {
                            rdvpremier = "Non";
                        }

                        Button btnModifier = new Button();
                        btnModifier.Name = string.Format("Bouton{0}", rdvid);
                        btnModifier.Text = "Modifier";
                        btnModifier.Click += new EventHandler(this.btnModifier_Click);
                        Panel pnlActions = new Panel();
                        pnlActions.Controls.Add(btnModifier);
                        
                        tblRendezvous.RowCount = tblRendezvous.RowCount + 1;
                        tblRendezvous.Controls.Add(new Label() { Text = rdvidpatient }, 0, tblRendezvous.RowCount -1);
                        tblRendezvous.Controls.Add(new Label() { Text = rdvnom }, 1, tblRendezvous.RowCount - 1);
                        tblRendezvous.Controls.Add(new Label() { Text = rdvprenom }, 2, tblRendezvous.RowCount - 1);
                        tblRendezvous.Controls.Add(new Label() { Text = rdvdateheure.ToString("yyyy-MM-dd") }, 3, tblRendezvous.RowCount - 1);
                        tblRendezvous.Controls.Add(new Label() { Text = rdvdateheure.ToString("HH:mm:ss") }, 4, tblRendezvous.RowCount - 1);
                        tblRendezvous.Controls.Add(new Label() { Text = rdvpremier }, 5, tblRendezvous.RowCount - 1);
                        tblRendezvous.Controls.Add(pnlActions, 6, tblRendezvous.RowCount - 1);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                results.Close();
                PanelManager("RendezVous");
            }
            return true;
        }
        private void btnDeconnecter_Click(object sender, EventArgs e)
        {
            opened = false;
            Application.Restart();
        }
        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(opened == true)
            {
                Environment.Exit(0);
            }
        }

        private void tsbtnRendezvous_Click(object sender, EventArgs e)
        {
            PanelManager("RendezVous");
        }
        private void btnModifier_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show(btn.Name);
        }

        private void tscbxPatients_TextChanged(object sender, EventArgs e)
        {
            if (tscbxPatients.Text == "Créer")
            {
                PanelManager("NouveauPatient");
            }
        }

        private void btnAnnulerNvPat_Click(object sender, EventArgs e)
        {
            PanelManager("RendezVous");
        }

        private void btnConfirmerNvPat_Click(object sender, EventArgs e)
        {
            try
            {
                Database_Manager db = new Database_Manager();
                db.Connexion();
                SQLiteDataReader results = db.SqlRequest("INSERT INTO Patients('PAT_Nom',  'PAT_Prenom',  'PAT_Date_Naissance',  'PAT_Titre',  'PAT_Etat_Civil',  'PAT_Origine',  'PAT_Adresse',  'PAT_Ville',  'PAT_Code_Postal',  'PAT_Canton',  'PAT_Telephone_Mobile',  'PAT_Telephone_Professionnel',  'PAT_Telephone_Urgence',  'PAT_Email',  'PAT_Emp_Titre',  'PAT_Emp_Adresse',  'PAT_Emp_Canton',  'PAT_Emp_Ville',  'PAT_Emp_Code_Postal',  'PAT_Emp_Pays',  'PAT_Ass_Numero_Avs',  'PAT_Ass_Numero_Carte',  'PAT_Ass_Numero_OFSP',  'PAT_Ass_Institution',  'PAT_Ass_Police') VALUES(" + txtNom.Text.Trim() + ", " + txtPrenom.Text.Trim() + " " + txtPrenom2.Text.Trim() + ", " + dtpNaissance.ToString() + ", " + cbxTitre.SelectedItem.ToString() + ", " + cbxEtatCivil.SelectedItem.ToString() + ", " + txtOrigine.Text.Trim() 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue durant la création du patient\n" + ex.Message);
            }
            finally
            {

            }
        }
    }
}
