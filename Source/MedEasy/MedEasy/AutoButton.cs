using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedEasy
{
    public class AutoButton : Button
    {
        public int AutoID { get; set; }

        public AutoButton(int id)
        {
            AutoID = id;
        }
    }
}
