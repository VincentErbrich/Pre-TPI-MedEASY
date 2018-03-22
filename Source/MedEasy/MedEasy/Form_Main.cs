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
        public Form_Main()
        {
            InitializeComponent();
        }
        private string CurrentPanel;
        private void Form_Main_Load(object sender, EventArgs e)
        {
            lblCurrentUser.Text = CurrentUser.UserID;
            BuildRendezvousTable();
        }
        private void PanelManager(string paneltoshow)
        {
            switch (paneltoshow)
            {
                case "RendezVous":
                    HideAllPanels();
                    pnlRendezvous.Visible = true;
                    break;
            }
        }
        private void HideAllPanels()
        {
            pnlRendezvous.Visible = false;
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
                MessageBox.Show(results.StepCount.ToString());
                while (results.Read())
                {
                    for(int i = 1;  i <= results.StepCount; i++)
                    {
                        Panel pnlActions = new Panel();

                        string rdvpremier;
                        if ((bool)results.GetValue(0) == true)
                        {
                            rdvpremier = "Oui";
                        }
                        else
                        {
                            rdvpremier = "Non";
                        }

                        DateTime rdvdateheure = (DateTime)results.GetValue(1);
                        string rdvidpatient = results.GetValue(2).ToString();
                        string rdvprenom = results.GetValue(3).ToString();
                        string rdvnom = results.GetValue(4).ToString();
                        int rdvid = (int)results.GetValue(5);
                        Button btnModifier = new AutoButton(rdvid);
                        btnModifier.Text = "Modifier";
                        btnModifier.Click += new EventHandler(this.btnModifier_Click);
                        pnlActions.Controls.Add(btnModifier);
                        
                        tblRendezvous.RowCount = tblRendezvous.RowCount + i;
                        tblRendezvous.Controls.Add(new Label() { Text = rdvidpatient }, 0, tblRendezvous.RowCount - 1);
                        tblRendezvous.Controls.Add(new Label() { Text = rdvnom }, 1, tblRendezvous.RowCount - 1);
                        tblRendezvous.Controls.Add(new Label() { Text = rdvprenom }, 2, tblRendezvous.RowCount - 1);
                        tblRendezvous.Controls.Add(new Label() { Text = rdvdateheure.ToString("yyyy-MM-dd") }, 3, tblRendezvous.RowCount - 1);
                        tblRendezvous.Controls.Add(new Label() { Text = rdvdateheure.ToString("HH:mm:ss") }, 4, tblRendezvous.RowCount - 1);
                        tblRendezvous.Controls.Add(new Label() { Text = rdvpremier }, 5, tblRendezvous.RowCount - 1);
                        tblRendezvous.Controls.Add(pnlActions, column: 6, row: tblRendezvous.RowCount - 1);
                    }
                }
            }
            catch (Exception)
            {
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
            Application.Restart();
        }
        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void tsbtnRendezvous_Click(object sender, EventArgs e)
        {
            PanelManager("RendezVous");
        }
        private void btnModifier_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En cours de développement", );
        }
    }
}
