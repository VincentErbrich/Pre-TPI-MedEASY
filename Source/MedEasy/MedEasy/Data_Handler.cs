using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace MedEasy
{
    public class Data_Handler
    {
        public static void CreatePatient(string nom, string prenom, DateTime date_naissance, string titre, string etat_civil,  string origine,  string adresse,  string ville, string code_postal,  string canton,  string telephone_mobile, string telephone_professionnel,  string telephone_urgence,  string email, string emp_titre, string emp_adresse, string emp_canton, string emp_ville,  string emp_code_postal, string emp_pays, string ass_numero_avs, string ass_numero_carte, string ass_numero_ofsp, string ass_institution, string ass_police)
        {
            Database_Manager db = new Database_Manager();
            db.SqlRequest("INSERT INTO Patient('PAT_Nom',  'PAT_Prenom',  'PAT_Date_Naissance',  'PAT_Titre',  'PAT_Etat_Civil',  'PAT_Origine',  'PAT_Adresse',  'PAT_Ville',  'PAT_Code_Postal',  'PAT_Canton',  'PAT_Telephone_Mobile',  'PAT_Telephone_Professionnel',  'PAT_Telephone_Urgence',  'PAT_Email',  'PAT_Emp_Titre',  'PAT_Emp_Adresse',  'PAT_Emp_Canton',  'PAT_Emp_Ville',  'PAT_Emp_Code_Postal',  'PAT_Emp_Pays',  'PAT_Ass_Numero_Avs',  'PAT_Ass_Numero_Carte',  'PAT_Ass_Numero_OFSP',  'PAT_Ass_Institution',  'PAT_Ass_Police') VALUES('" + nom + "', '" + prenom + "', '" + date_naissance.ToString("yyyy-MM-dd") + "', '" + titre + "', '" + etat_civil + "', '" + origine + "', '" + adresse + "', '" + ville + "', '" + code_postal + "', '" + canton + "', '" + telephone_mobile + "', '" + telephone_professionnel + "', '" + telephone_urgence + "', '" + email + "', '" + emp_titre + "', '" + emp_adresse + "', '" + emp_canton + "', '" + emp_ville + "', '" + emp_code_postal + "', '" + emp_pays + "', '" + ass_numero_avs + "', '" + ass_numero_carte + "', '" + ass_numero_ofsp + "', '" + ass_institution + "', '" + ass_police + "')");
        }
        public static void ModifyPatient()
        {
        }
        public static void DeletePatient(int id)
        {
            Database_Manager db = new Database_Manager();
            db.SqlRequest("DELETE FROM Patient WHERE PAT_ID = '" + id + "'");
        }
        public static SQLiteDataReader CreateRendezVousConsultation(int idpatient, bool visiteroutine, bool premierevisite, DateTime dateheurevisite, string notes, bool visiteeffectuee)
        {
            Database_Manager db = new Database_Manager();
            db.SqlRequest("INSERT INTO Consultation('CON_PAT_FID', 'CON_Visite_Routine', 'CON_Premiere_Consultation', 'CON_Date_Heure', 'CON_Notes', 'CON_Facture_Validee', 'CON_Facture_Payee', 'CON_Visite_Effectuee') VALUES('" + idpatient + "', '" + visiteroutine + "', '" + premierevisite + "', '" + dateheurevisite.ToString("yyyy-MM-dd") + "', '" + notes + "', '" + false + "', '" + false + "', '" + visiteeffectuee + "')");
            return db.SqlRequest("SELECT LAST_INSERT_ROWID()");
        }
        public static void UpdateRendezVousToConsultation(int idconsultation, string notes)
        {
            Database_Manager db = new Database_Manager();
            db.SqlRequest("UPDATE 'Consultation' SET 'CON_Date_Heure' = '" + DateTime.Now.ToString("yyyy-MM-dd") + "', 'CON_Notes' = '" + notes + "', 'CON_Visite_Effectuee' = 'True' WHERE 'CON_ID' = '" + idconsultation + "';");
        }
        public static void DeleteConsultationRendezVous(int id)
        {
            Database_Manager db = new Database_Manager();
            db.SqlRequest("DELETE FROM Consultation WHERE CON_ID = '" + id + "'");
        }
        public static void AddServiceToConsultation(int idtype, string description, int duree, int idconsultation)
        {
            Database_Manager db = new Database_Manager();
            SQLiteDataReader reader = db.SqlRequest("SELECT * FROM 'Service_Rendu'");
            try
            {
                if (reader.HasRows)
                {
                    int idlstservice = 1;
                    while (reader.Read())
                    {
                        try { idlstservice = Convert.ToInt32(reader.GetValue(0)); }
                        catch { }
                    }
                    idlstservice = idlstservice + 1;
                    db.SqlRequest("INSERT INTO Service_Rendu(SER_ID ,SER_Duree, SER_Description, SER_CON_FID, SER_SET_ID) VALUES('" + idlstservice + "', '" + duree + "', '" + description + "', '" + idconsultation + "', '" + idtype + "');");
                }
                reader.Close();
            }
            catch(Exception)
            {
                db.SqlRequest("INSERT INTO Service_Rendu(SER_ID ,SER_Duree, SER_Description, SER_CON_FID, SER_SET_ID) VALUES('" + 1 + "', '" + duree + "', '" + description + "', '" + idconsultation + "', '" + idtype + "');");
                reader.Close();
            }
        }
    }
}
