//hlavička

using System;
using System.Windows.Forms;

/**
* @file Form1.cs
*
* @brief Třída zpracovávající vstupy
* @author Martin Konečný
*/



/**
* Enum obsahující všechny matematické operace.
* Sčítání, odčítání, dělení, násobení
*/
public enum OperationType
{
    add, sub, div, mul
}

namespace MainForm
{

    public partial class Form1 : Form
    {
        //maximalni pocet cifer ktere muze cislo obsahovat
        //pro double je to 15
        public int maxNumOfDigits = 15; 

        public double currentValue = 0;
        public string currentValueStr = "0";

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
            if (!currentValueStr.Contains(","))
            {
                currentValueStr += ",";
            }
            PrintCurrentValue();
        }

        /**
        * Funkce pro přidání aktuální hodnoty 
        * 
        * @param value Hodnota, která se má přidat
        */
        private void AddValue(double value)
        {
            if (currentValueStr.Length < maxNumOfDigits)
            {
                if (currentValue == 0)
                {
                    currentValueStr = value.ToString();
                }
                else
                { 
                    currentValueStr += value.ToString();
                    //pridani pozadovane hodnoty jako koncovou cifru
                }
                PrintCurrentValue();
            }
            else
            { 
                //presahnuto dovoleny pocet cifer
                //nejakym zpuobem vypis chyby
            }
        }


        /**
        * Funkce pro vypsání aktuální hodnoty
        * 
        */
        private void PrintCurrentValue()
        {
            mainValueBox.Text = currentValueStr;
            currentValue = Convert.ToDouble(currentValueStr);
            label1.Text = currentValue.ToString();
        }

        private void OperationButtonClick(object sender, EventArgs e)
        {
            OperationButton clickedButton = (OperationButton)(sender);
            OperationType operation = (OperationType)clickedButton.operation;



            //na rychlo
            if (operation == OperationType.add)
            {
                label1.Text = "+";
            }
            if (operation == OperationType.sub)
            {
                label1.Text = "-";
            }
            if (operation == OperationType.mul)
            {
                label1.Text = "*";
            }
            if (operation == OperationType.div)
            {
                label1.Text = "/";
            }
        }
    }
}
