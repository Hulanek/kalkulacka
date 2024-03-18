using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace MainForm
{
    public class NumButton : Button
    {

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
