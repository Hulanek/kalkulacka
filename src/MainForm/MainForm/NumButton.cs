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

        public float buttonValue = 0;

        [Category("CustomValue")]
        public float ButtonValue
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
