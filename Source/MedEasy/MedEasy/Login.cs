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

namespace MedEasy
{
    class Login
    {
        //Déclaration des propriétés de Login ("get; set;" pour déclarer des propriétés read-write et non pas des simples variables)
        public string Username { get; set; }
        public string Password { get; set; }

        //Initialisation des variables avec les valeurs passée en entrée de la fonction
        public Login(string user, string pass)
        {
            this.Username = user;
            this.Password = pass;
        }
    }
}
