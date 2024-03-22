using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;


namespace MainForm
{
    public class OperationButton : Button
    {


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
