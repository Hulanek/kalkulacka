using System;
using System.Windows.Forms;


namespace MainForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ValueButtonClick(object sender, EventArgs e)
        {
            NumButton clickedButton = (NumButton)(sender);

            mainValueBox.Text = clickedButton.ButtonValue.ToString();
            
        }


    }
}
