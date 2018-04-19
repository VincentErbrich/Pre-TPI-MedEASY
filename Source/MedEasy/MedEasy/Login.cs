/*
 *  Auteur : Vincent Erbrich
 *  Réalisé dans le cadre du projet Pré-TPI MedEasy
 *  CPNV (Centre Professionel du Nord Vaudois) Ste-Croix 2018
 */
using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MedEasy
{
    /*
     * Cette classe s'occupe de vérifier les identifiants entrés en les
     * comparant avec les données contenues dans la base SQLite
     */
    class Login
    {
        //Déclaration des propriétés de Login ("get; set;" pour déclarer des propriétés read-write et non pas des simples variables)
        public string Username { get; set; }
        public string Password { get; set; }

        public static bool isadmin;

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
                MessageBox.Show("Veuillez entrer votre nom d'utilisateur"); //Affiche un message d'erreur si le nom d'utiisateur est vide
                return false;

            }
            //Vérifie si le mot de passe est vide
            else if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Veuillez entrer votre mot de passe"); //Affiche un message d'erreur si le mot de passe est vide
                return false;
            }
            //Dans ce "else" on vérifie que le nom d'utilisateur soit correct
            else
            {
                //Crée une nouvelle instance de la classe Database_Manager pour executer la requête
                Database_Manager db = new Database_Manager();
                SQLiteDataReader results = db.SqlRequest("SELECT * FROM Utilisateurs WHERE USR_ID ='" + Username + "' AND " + "USR_Password ='" + Password + "';");
                try
                {
                    // Lis la prochaine ligne des résultats de la requête tant que la ligne existe
                    while (results.Read())
                    {
                        // Sécurité supplémentaire, vérifie si le nom d'utilisateur et mot de passe sont corrects
                        if (results.GetValue(0).Equals(Username) || results.GetValue(1).Equals(Password))
                        {
                            isadmin = (bool)results.GetValue(4);
                            CurrentUser.IsAdmin = isadmin;
                            CurrentUser.UserID = results.GetValue(0).ToString();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
<<<<<<< HEAD
                    return false;
=======
                        return false;
>>>>>>> 0d5f14ff3ffaf6c1c30bc9f98d2b7444eed1cfa3

                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
<<<<<<< HEAD
                    results.Close(); //Ferme le SQLiteDataReader quand la vérification des identifiants est terminée
                }

=======
                    if (results != null) results.Close();
                }
                    
>>>>>>> 0d5f14ff3ffaf6c1c30bc9f98d2b7444eed1cfa3
            }
        }
    }
}
