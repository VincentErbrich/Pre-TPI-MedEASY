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

        //Initialise le formulaire de login dès que la classe du formulaire principal est chargé
        Form_Login frmlogin = new Form_Login();
        Object currentuser = new Form_Login();
        

        private void Form_Main_Load(object sender, EventArgs e)
        {
            //Montre le formulaire de login
            //do
            //{
                frmlogin.Show();
            //}
            //while()
            

        }
    }
}
