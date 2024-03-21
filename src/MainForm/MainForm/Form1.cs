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

        public double lastValue = 0; //v operacích vystupuje jako první operand
        public double currentValue = 0; // tato hodnota se zobrazuje v text boxu
                                        // v operacích vystupuje jako druhý operand

        public string currentValueStr = "0";
        OperationType currentOperation;
        

        public Form1()
        {
            InitializeComponent();
            PrintCurrentValue();
        }

        /**
        * Funkce pro detekci zmáčknutého číselného tlačítka z GUI a získání jeho hodnoty
        */
        private void ValueButtonClick(object sender, EventArgs e)
        {
            NumButton clickedButton = (NumButton)(sender);
            double clickedValue = clickedButton.ButtonValue;
            AddValue(clickedValue);
        }

        /**
        * Funkce pro detekci zmáčknutého tlačítka s operací z GUI a získání jeho hodnoty (resp. operace)
        */
        private void OperationButtonClick(object sender, EventArgs e)
        {
            //execute operation ktera byla pred tim
            OperationButton clickedButton = (OperationButton)(sender);
            currentOperation = clickedButton.operation;
            AddOperation();
        }

        /**
        * Funkce pro detekci zmáčknutého tlačítka s desetinnou čárkou z GUI a získání jeho hodnoty (resp. operace)
        */
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

        private void AddOperation()
        {
            lastValue = currentValue;
            currentValue = 0;
            if (currentOperation == OperationType.add)
            {
                //operationButton_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
                mainValueBox.Text = "+";
            }
            else if (currentOperation == OperationType.sub)
            {
                //operationButton_sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
                mainValueBox.Text = "-";
            }
        }
        /**
        * Funkce pro vypsání aktuální hodnoty
        */
        private void PrintCurrentValue()
        {
            mainValueBox.Text = currentValueStr;
            currentValue = Convert.ToDouble(currentValueStr);
            label1.Text = currentValue.ToString();
        }
    }
}
