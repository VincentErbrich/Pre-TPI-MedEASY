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
                try
                {
                    SQLiteConnection.CreateFile("M:\\DB.sqlite");
                    //  La connexion est initialisée dans une instance de l'objet SQLiteConnection
                    SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source= M:\\DB.sqlite");
                    //  La connexion est ouverte
                    m_dbConnection.Open();
                    //  Une instance de l'objet SQLiteCommand est créée, contenant le script de création de la base
                    /// VIRER DEUXIEME COMMANDE
                    //SQLiteCommand command = new SQLiteCommand("CREATE TABLE Utilisateurs (USR_ID VARCHAR(25) PRIMARY KEY NOT NULL, USR_Password VARCHAR(45) NOT NULL, USR_Nom VARCHAR(35), USR_Prenom VARCHAR(25), USR_EstAdmin BOOL NOT NULL, CONSTRAINT USR_ID_UNIQUE UNIQUE(USR_ID));", m_dbConnection);
                    SQLiteCommand command = new SQLiteCommand("CREATE TABLE 'Patient'(  'PAT_ID' INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,  'PAT_Nom' VARCHAR(30) NOT NULL,  'PAT_Prenom' VARCHAR(30) NOT NULL,  'PAT_Date_Naissance' DATE NOT NULL,  'PAT_Titre' VARCHAR(6),  'PAT_Etat_Civil' VARCHAR(10),  'PAT_Origine' VARCHAR(25),  'PAT_Adresse' VARCHAR(45),  'PAT_Ville' VARCHAR(25),  'PAT_Code_Postal' VARCHAR(4),  'PAT_Canton' VARCHAR(20),  'PAT_Telephone_Mobile' VARCHAR(14),  'PAT_Telephone_Professionnel' VARCHAR(14),  'PAT_Telephone_Urgence' VARCHAR(14),  'PAT_Email' VARCHAR(14),  'PAT_Emp_Titre' VARCHAR(45),  'PAT_Emp_Adresse' VARCHAR(45),  'PAT_Emp_Canton' VARCHAR(20),  'PAT_Emp_Ville' VARCHAR(25),  'PAT_Emp_Code_Postal' VARCHAR(4),  'PAT_Emp_Pays' VARCHAR(20),  'PAT_Ass_Numero_Avs' VARCHAR(13),  'PAT_Ass_Numero_Carte' VARCHAR(20),  'PAT_Ass_Numero_OFSP' VARCHAR(45),  'PAT_Ass_Institution' VARCHAR(15),  'PAT_Ass_Police' VARCHAR(20),  CONSTRAINT 'IDPatient_UNIQUE'    UNIQUE('PAT_ID'));CREATE TABLE 'Consultation'(  'CON_Visite_Routine' INTEGER,  'CON_ID' INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,  'CON_Date_Heure' DATETIME NOT NULL,  'CON_PAT_FID' INTEGER NOT NULL,  'CON_Premiere_Consultation' BOOL NOT NULL,  'CON_Notes' LONGTEXT,  'CON_Facture_Validee' BOOL NOT NULL,  'CON_Facture_Payee' BOOL NOT NULL,  'CON_Facture_Pdf' BLOB,  CONSTRAINT 'CON_ID_Consultation_UNIQUE'    UNIQUE('CON_ID'),  CONSTRAINT 'fk_Consultation_Patient'    FOREIGN KEY('CON_PAT_FID')    REFERENCES 'Patient'('PAT_ID'));CREATE INDEX 'Consultation.fk_Consultation_Patient' ON 'Consultation' ('CON_PAT_FID');CREATE TABLE 'CIM10'(  'CIM_ID' INTEGER PRIMARY KEY NOT NULL,  'CIM_Description' LONGTEXT,  CONSTRAINT 'CIM_ID_UNIQUE'    UNIQUE('CIM_ID'));CREATE TABLE 'Service_Type'(  'SET_ID' INTEGER PRIMARY KEY NOT NULL,  'SET_Nom' VARCHAR(15),  'SET_Chf_Minute' FLOAT);CREATE TABLE 'Utilisateurs'(  'USR_ID' VARCHAR(25) PRIMARY KEY NOT NULL,  'USR_Password' VARCHAR(45) NOT NULL,  'USR_Nom' VARCHAR(35),  'USR_Prenom' VARCHAR(25),  'USR_EstAdmin' BOOL NOT NULL,  CONSTRAINT 'USR_ID_UNIQUE'    UNIQUE('USR_ID'));INSERT INTO 'Utilisateurs'('USR_ID','USR_Password','USR_Nom','USR_Prenom','USR_EstAdmin') VALUES('admin', 'pass', 'Bon', 'Jean', 1);CREATE TABLE 'Probleme'(  'PRB_ID' INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,  'PRB_Titre' VARCHAR(35) NOT NULL,  'PRB_Type' VARCHAR(15) NOT NULL,  'PRB_Description' LONGTEXT,  'PRB_Date_Debut' DATE,  'PRB_Date_Fin' DATE,  'PRB_Occurence' VARCHAR(20),  'PRB_PAT_FID' INTEGER NOT NULL,  CONSTRAINT 'PRB_ID_UNIQUE'    UNIQUE('PRB_ID'),  CONSTRAINT 'fk_Probleme_Patient1'    FOREIGN KEY('PRB_PAT_FID')    REFERENCES 'Patient'('PAT_ID'));CREATE INDEX 'Probleme.fk_Probleme_Patient' ON 'Probleme' ('PRB_PAT_FID');CREATE TABLE 'Consultation_Problemes'(  'COPB_CON_ID' INTEGER NOT NULL,  'Probleme_PRB_ID' INTEGER NOT NULL,  PRIMARY KEY('COPB_CON_ID','Probleme_PRB_ID'),  CONSTRAINT 'fk_Consultations_Problemes_Consultation1'    FOREIGN KEY('COPB_CON_ID')    REFERENCES 'Consultation'('CON_ID'),  CONSTRAINT 'fk_Consultations_Problemes_Probleme1'    FOREIGN KEY('Probleme_PRB_ID')    REFERENCES 'Probleme'('PRB_ID'));CREATE INDEX 'Consultation_Problemes.fk_COPB_Consultation' ON 'Consultation_Problemes' ('COPB_CON_ID');CREATE INDEX 'Consultation_Problemes.fk_COPB_Probleme' ON 'Consultation_Problemes' ('Probleme_PRB_ID');CREATE TABLE 'Service_Rendu'(  'SER_ID' INTEGER NOT NULL,  'SER_Duree' INTEGER NOT NULL,  'SER_Description' LONGTEXT,  'SER_CON_FID' INTEGER NOT NULL,  'SER_SET_ID' INTEGER NOT NULL,  PRIMARY KEY('SER_ID','SER_SET_ID'),  CONSTRAINT 'SER_ID_UNIQUE'    UNIQUE('SER_ID'),  CONSTRAINT 'fk_Service_Rendu_Consultation1'    FOREIGN KEY('SER_CON_FID')    REFERENCES 'Consultation'('CON_ID'),  CONSTRAINT 'fk_Service_Rendu_Service_Type1'    FOREIGN KEY('SER_SET_ID')    REFERENCES 'Service_Type'('SET_ID'));CREATE INDEX 'Service_Rendu.fk_Service_Rendu_Consultation1_idx' ON 'Service_Rendu' ('SER_CON_FID');CREATE INDEX 'Service_Rendu.fk_Service_Rendu_Service_Type1_idx' ON 'Service_Rendu' ('SER_SET_ID');CREATE TABLE 'Probleme_CIM10'(  'PBCI_PRB_ID' INTEGER NOT NULL,  'PBCI_CIM_ID' INTEGER PRIMARY KEY NOT NULL,  CONSTRAINT 'fk_Probleme_CIM10_Probleme1'    FOREIGN KEY('PBCI_PRB_ID')    REFERENCES 'Probleme'('PRB_ID'),  CONSTRAINT 'fk_Probleme_CIM10_CIM101'    FOREIGN KEY('PBCI_CIM_ID')    REFERENCES 'CIM10'('CIM_ID'));CREATE INDEX 'Probleme_CIM10.fk_Probleme_CIM10_Probleme1_idx' ON 'Probleme_CIM10' ('PBCI_PRB_ID');CREATE INDEX 'Probleme_CIM10.fk_Probleme_CIM10_CIM101_idx' ON 'Probleme_CIM10' ('PBCI_CIM_ID');", m_dbConnection);
                    //  La commande est executée sans demander de retour
                    command.ExecuteNonQuery();
                    //  La connexion est retournée et la méthode stoppée
                    return m_dbConnection;
                }
                catch(Exception e)
                {
                    MessageBox.Show("Erreur : La base de données n'a pas pu être créée : Vérifiez la disponibilité du partage M:\n" + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    return null;
                }
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
