using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            PanelManager("RendezVous");
        }
        private void PanelManager(string paneltoshow)
        {
            switch (paneltoshow)
            {
                case "RendezVous" :
                    HideAllPanels();
                    pnlRendezvous.Visible = true;
                    break;
            }
        }
        private void HideAllPanels()
        {
            pnlRendezvous.Visible = false;
        }

        private void btnDeconnecter_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
