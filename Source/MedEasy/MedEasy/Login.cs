using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MedEasy
{
    class Login
    {
        //Déclaration des propriétés de Login ("get; set;" pour déclarer des propriétés read-write et non pas des simples variables)
        public string Username { get; set; }
        public string Password { get; set; }

        public Login(string user, string pass)
        {
            this.Username = user;
            this.Password = pass;
        }
        //Vérifie si l'utilisateur peut être identifié
        internal bool LoginIsCorrect()
        {
            //Vérifie si le nom d'utilisateur est vide
            if (string.IsNullOrEmpty(Username))
            {
                //Affiche un message d'erreur
                MessageBox.Show("Veuillez entrer votre nom d'utilisateur");
                return false;

            }
            //Dans ce "else" on vérifie que le nom d'utilisateur soit correct
            else
            {
                Database_Manager db = new Database_Manager();
                db.Connexion();
                SQLiteDataReader results = db.SqlRequest("SELECT * FROM Utilisateurs WHERE USR_ID = '" + Username + "' AND " + "USR_Password = '" + Password + "'");
                
                if (results != null)
                {
                    MessageBox.Show("Success");
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }
}
