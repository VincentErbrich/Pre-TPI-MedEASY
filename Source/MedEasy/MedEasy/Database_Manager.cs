/*
 *  Auteur : Vincent Erbrich
 *  Réalisé dans le cadre du projet Pré-TPI MedEasy
 *  CPNV (Centre Professionel du Nord Vaudois) Ste-Croix 2018
 */
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace MedEasy
{
    /*
     *  CLASSE DATABASE MANAGER
     *  Cette classe gère la connexion vers le fichier de base de données SQLite et 
     *  éxecute les requêtes SQL envers cette dernière. 
     *  Elle génère la dite base si elle est inexistante.
     *  
     *  SOURCES / AIDES : Remerciements à Cyril Kalbfuss, inspiré de https://blog.tigrangasparian.com/2012/02/09/getting-started-with-sqlite-in-c-part-one/ et https://www.connectionstrings.com/sqlite/
     */
    class Database_Manager
    {
        /*  
         *  METHODE CONNEXION
         *  Cette méthode crée et gère la connexion vers le fichier de base de données
         *  Elle génère la base de données si elle est inexistante
         *      
         *  RETOURNE : La connexion à la base de donnée
         */
        public SQLiteConnection Connexion()
        {

            //  Vérifie si le fichier de base de données existe
            if (!System.IO.File.Exists("M:\\DB.sqlite"))
            {
                //  Si le fichier n'existe pas, éxectute ce code :

                //Connexion à la base SQLite : Code adapté de https://www.connectionstrings.com/sqlite/

                //  Le fichier est crée
                SQLiteConnection.CreateFile("M:\\DB.sqlite");
                //  La connexion est initialisée dans une instance de l'objet SQLiteConnection
                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source= M:\\DB.sqlite");
                //  La connexion est ouverte
                m_dbConnection.Open();
                //  Une instance de l'objet SQLiteCommand est créée, contenant le script de création de la base
                /// VIRER DEUXIEME COMMANDE
                SQLiteCommand command = new SQLiteCommand("CREATE TABLE Utilisateurs (USR_ID VARCHAR(25) PRIMARY KEY NOT NULL, USR_Password VARCHAR(45) NOT NULL, USR_Nom VARCHAR(35), USR_Prenom VARCHAR(25), USR_EstAdmin BOOL NOT NULL, CONSTRAINT USR_ID_UNIQUE UNIQUE(USR_ID));", m_dbConnection);
                //  La commande est executée sans demander de retour
                command.ExecuteNonQuery();
                command = new SQLiteCommand("INSERT INTO Utilisateurs ('USR_ID','USR_Password','USR_Nom','USR_Prenom','USR_EstAdmin') VALUES('admin', 'pass', 'Bon', 'Jean', '1');", m_dbConnection);
                command.ExecuteNonQuery();
                //  La connexion est retournée et la méthode stoppée
                return m_dbConnection;
            }   
            else
            {
                //  Si le fichier existe, éxecute ce code :

                try
                {
                    //  Connexion à la base SQLite : Code adapté de https://www.connectionstrings.com/sqlite/

                    //  La connexion est initialisée dans une instance de l'objet SQLiteConnection
                    SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=M:\\DB.sqlite");
                    //  La connexion est ouverte
                    m_dbConnection.Open();
                    //  La connexion est retournée et la méthode stoppée
                    return m_dbConnection;
                }
                catch (Exception e)
                {
                    //  Exectute ce code en cas d'erreur :

                    //  Montre un message d'erreur
                    MessageBox.Show("Erreur : La base de données n'a pas pu être trouvée - Veuillez contacter le support technique " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //  Ne retourne rien
                    return null;
                }
            }
        }
        /*
         *  Méthode SQLREQUEST
         *  Execute la requête SQLite passée en entrée
         *  
         *  RETOURNE :  le résultat de la requête
         */
        public SQLiteDataReader SqlRequest(string Request)
        {
            /// A VIRER
            MessageBox.Show(Request);
            //  Initialise la commande dans une nouvelle instance de l'objet SQLiteCommand
            SQLiteCommand command = new SQLiteCommand(Request, Connexion());
            try
            {
                //  La requête est executée
                SQLiteDataReader reader = command.ExecuteReader();
                //  Retourne le résultat de la requête
                return reader;
            }
            catch(Exception e)
            {
                //  Exectute ce code en cas d'erreur :

                //  Montre un message d'erreur
                MessageBox.Show("Erreur : Requête incorrecte. "+e.Message);
                //  Ne retourne rien
                return null;
            }     

        }

    }
}
