/**************************
* Název projektu: Kalkulačka
* Soubor: NumButton.cs
* Autor: Martin Konečný xkonecm00@stud.fit.vutbr.cz
*
* Popis: Custom tlačítko pro zadávání operací
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
* @brief  Custom tlačítko pro operace
* @author Martin Konečný
*/
namespace MainForm
{
    public class OperationButton : Button
    {
        //tlačítko dědí vše z default buttonu + má parametr operace, které zastupuje


        public OperationType operation;

        [Category("Operation")]
        public OperationType Operation
        {
            get { return operation; }

            set { operation = value; }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
