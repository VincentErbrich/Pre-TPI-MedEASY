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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            //PanelCreationEnvironnement panel = new PanelCreationEnvironnement();
            //panel.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login(txtUserName.Text, txtPassword.Text);
            if(login.LoginIsCorrect())
            {
                Form Main = new Form_Main();
                Main.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
