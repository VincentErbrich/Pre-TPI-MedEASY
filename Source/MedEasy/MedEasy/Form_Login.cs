/*
 *  Auteur : Vincent Erbrich
 *  Réalisé dans le cadre du projet Pré-TPI MedEasy
 *  CPNV (Centre Professionel du Nord Vaudois) Ste-Croix 2018
 */
using System;
using System.Windows.Forms;

namespace MedEasy
{
    /*
     * Cette classe gère les énènements des contrôles du Formulaire Login
     */
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
        }

        // Lorsque le bouton "btnLogin" lance l'évènement Click, execute cette méthode
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login(txtUserName.Text, txtPassword.Text); //Crée une nouvelle instance de la classe Login
            if (login.LoginIsCorrect()) // Vérifie si le login est correct avec la méthode LoginIsCorrect de la classe Login
            {
                //Instancie et montre le Formulaire principal si le login entré est correct
                Form Main = new Form_Main();
                Main.Show();
                Hide(); //Cache le formulaire Login, ne le ferme pas car c'est le seul formulaire présent dans Program.cs
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect"); //Montre un message d'erreur si le login est incorrect
            }
        }
        // Lorsque le bouton "btnCancel" lance l'évènement Click, execute cette méthode
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Quitte l'application
        }
    }
}
