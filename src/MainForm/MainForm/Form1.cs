//hlavička

using System;
using System.Windows.Forms;

/**
* @file Form1.cs
*
* @brief Třída zpracovávající vstupy
* @author Martin Konečný
*/


namespace MainForm
{
    public partial class Form1 : Form
    {
        public double currentValue = 0;
        public string currentValueStr = "";

        public Form1()
        {
            InitializeComponent();
            PrintCurrentValue();
        }

        /**
        * Funkce pro detekci zmáčknutého tlačítka z GUI a získání jeho hodnoty
        *
        * @param value Hodnota, která se má přidat
        */
        private void ValueButtonClick(object sender, EventArgs e)
        {
            NumButton clickedButton = (NumButton)(sender);
            double clickedValue = clickedButton.ButtonValue;
            AddValue(clickedValue);
        }

        private void DecimalPointClick(object sender, EventArgs e)
        {

        }

        /**
        * Funkce pro přidání aktuální hodnoty 
        * 
        * @param value Hodnota, která se má přidat
        */
        private void AddValue(double value)
        { 
            //pridani pozadovane hodnoty jako koncovou cifru
            currentValue = currentValue * 10 + value;
            PrintCurrentValue();
        }


        /**
        * Funkce pro vypsání aktuální hodnoty
        * 
        */
        private void PrintCurrentValue()
        {
            currentValueStr = "";

            double num = currentValue;
            int numOfdigits = CountDigits(num);
            string currentValueStrRev = "";

            for (int i = 0; i < numOfdigits; i++)
            {
                if (num < 1)
                {
                    break;
                }
                currentValueStrRev += ((long)(num % 10)).ToString();
                num = num / 10;
            }

            for (int i = currentValueStrRev.Length - 1; i >= 0; i--)
            {
                currentValueStr += currentValueStrRev[i];
            }

            mainValueBox.Text = currentValueStr;
        }

        private int CountDigits(double number)
        {
            int digits = 0;
            while (number >= 1)
            {
                digits++;
                number = number / 10;
            }
            return digits;
        }


    }
}
