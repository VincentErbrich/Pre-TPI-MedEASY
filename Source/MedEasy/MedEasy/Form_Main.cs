using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MedEasy
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        //Initialise le formulaire de login dès que la classe du formulaire principal est chargé
        Form_Login frmlogin = new Form_Login();
        Object currentuser = new Form_Login();
        

        private void Form_Main_Load(object sender, EventArgs e)
        {
            //Connexion à la base SQLite : Code trouvé sur https://www.connectionstrings.com/sqlite/
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=M:\\DB.sqlite;Version=3;");
            m_dbConnection.Open();
            //Montre le formulaire de login
            //do
            {
                frmlogin.Show();
            }
            while (!currentuser.loggedin);

        }
    }
}
