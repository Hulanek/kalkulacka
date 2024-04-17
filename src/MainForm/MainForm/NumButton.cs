/**************************
* Název projektu: Kalkulačka
* Soubor: NumButton.cs
* Autor: Martin Konečný xkonecm00@stud.fit.vutbr.cz
*
* Popis: Custom tlačítko pro zadávání cifer
************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

/**
* @file NumButton.cs
*
* @brief  Custom tlačítko pro zadávání cifer
* @author Martin Konečný
*/

namespace MainForm
{
    public class NumButton : Button
    {
        //tlačítko dědí vše z default buttonu + má parametr čísla, které zastupuje
        public double buttonValue = 0;

        [Category("CustomValue")]
        public double ButtonValue
        { 
            get { return buttonValue; }

            set { buttonValue = value; }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
