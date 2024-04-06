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

/**
* Enum obsahující aktuální stav
* aktuální stav odpovídá zobrazované položce v hlavním okně
*/
public enum CurrentState
{ 
    number, //stav při zadávání hodnoty
    operation, //stav při zadávání operace
    result, //stav při výpisu výsledku
    error //stav při výpisu chyby
}

namespace MainForm
{

    public partial class Form1 : Form
    {
        //maximalni pocet cifer ktere muze cislo obsahovat
        //pro double je to 15
        public int maxNumOfDigits = 15;
        public double maxDisplayableVal = 999999999999999; //maximální hodnota pro 15 cifer


        public double lastValue; //v operacích vystupuje jako první operand
        public double currentValue; // tato hodnota se zobrazuje v text boxu
                                    // v operacích vystupuje jako druhý operand
        public string currentValueStr;
        
        OperationType currentOperation;
        OperationType lastOperation;

        static Operations operations = new Operations();
        static CurrentState currentState = new CurrentState();

        string errorMessage = "";

        public Form1()
        {
            InitializeComponent();
            PrintCurrentValue();
            ResetValues();
        }

        /**
        * Funkce pro resetování hodnot do základního stavu
        */
        public void ResetValues()
        {
            currentState = CurrentState.number;
            currentOperation = OperationType.add;
            lastOperation = OperationType.add;
            lastValue = 0;
            currentValue = 0;
            currentValueStr = "0";
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
            OperationButton clickedButton = (OperationButton)(sender);
            AddOperation(clickedButton.operation);
        }

        /**
        * Funkce pro detekci zmáčknutého tlačítka s desetinnou čárkou z GUI a získání jeho hodnoty (resp. operace)
        */
        private void DecimalButtonClick(object sender, EventArgs e)
        {
            AddDecimal();
        }

        /**
        * Funkce pro detekci zmáčknutí tlačítka rovnosti z GUI a získání jeho hodnoty (resp. operace)
        */
        public void EqualButtonClick(object sender, EventArgs e)
        {
            Result();
        }

        /**
        * Funkce pro přidání aktuální hodnoty 
        * 
        * @param value Hodnota, která se má přidat
        */
        private void AddValue(double value)
        {
            if (currentState == CurrentState.result || currentState == CurrentState.error)//nový výpočet po zobrazení výsledku nebo chyby
            {
                ResetValues();
            }
            
            if (currentState != CurrentState.number)//vynulovaní string hodnoty pokud napíšeme první číslici
            {
                currentValueStr = "0";
            }

            if (currentValueStr.Length < maxNumOfDigits)
            {
                if (currentValueStr == "0")
                {
                    currentValueStr = value.ToString();
                }
                else
                { 
                    currentValueStr += value.ToString();
                    //přidání požadované hodnoty jako poslední cifru
                }
                PrintCurrentValue();
                currentValue = Convert.ToDouble(currentValueStr);
            }
            else
            { 
                //presahnuto dovoleny pocet cifer
                //nejakym zpuobem vypis chyby
            }
            currentState = CurrentState.number;
        }

        /**
        * Funkce pro přidání desetinné čárky 
        */
        private void AddDecimal()
        {
            if (currentState == CurrentState.number)
            {
                if (!currentValueStr.Contains(","))
                {
                    currentValueStr += ",";
                }
                PrintCurrentValue();
            }
            else
            { 
                //pokud chceme pridat desetinnou carku po zadani operace
                //  bud chyba nebo se nestane nic
            }
        }

        /**
        * Funkce pro nastavení a zobrazení operace k provedení
        * Pokud je před touto operací potřeba provést operaci předcházející, provede ji
        * @param operationToAdd Operace, která se má přidat
        */
        private void AddOperation(OperationType operationToAdd)
        {
            if (currentState == CurrentState.error)//při zobrazení erroru nelze zadat operace
            {
                return;
            }
            if (currentState == CurrentState.number)
            {
                if (ExecuteOperation(lastOperation))//provedení předcházející operace
                {
                    lastOperation = currentOperation;
                }
                else
                {
                    return;
                }
            }

            currentOperation = operationToAdd;

            if (currentOperation == OperationType.add)
            {
                mainValueBox.Text = "+";
            }
            else if (currentOperation == OperationType.sub)
            {
                mainValueBox.Text = "-";
            }
            else if (currentOperation == OperationType.div)
            {
                mainValueBox.Text = "/";
            }
            else if (currentOperation == OperationType.mul)
            {
                mainValueBox.Text = "*";
            }
            currentState = CurrentState.operation;
        }

        /**
        * Funkce pro vykonání operace
        * Funkce pracuje s instancí matematické třídy Operations
        * @param operation Operace, která se má vykonat
        * @return if execution was successful
        */
        public bool ExecuteOperation(OperationType operation)
        {

            if (operation == OperationType.add)
            {
                currentValue = operations.Add(lastValue, currentValue);
            }
            else if (operation == OperationType.sub)
            {
                currentValue = operations.Sub(lastValue, currentValue);
            }
            else if (operation == OperationType.div)
            {
                currentValue = operations.Div(lastValue, currentValue);
            }
            else if (operation == OperationType.mul)
            {
                currentValue = operations.Mul(lastValue, currentValue);
            }

            if (currentValue > maxDisplayableVal || currentValue < -maxDisplayableVal)
            {
                currentState = CurrentState.error;
                errorMessage = "Přetečení";
                PrintErrorMessage();
                return false;
            }

            lastValue = currentValue;
            currentValue = 0;
            return true;
        }

        /**
        * Funkce pro vypsání aktuální hodnoty
        */
        private void PrintCurrentValue()
        {
            mainValueBox.Text = currentValueStr;
        }

        /**
        * Funkce pro vypsání chyby
        */
        private void PrintErrorMessage()
        {
            mainValueBox.Text = errorMessage;
        }


        /**
        * Funkce pro vypsání výsledku - lastValue
        */
        private void Result()
        {
            if (currentState == CurrentState.number)
            {
                if (ExecuteOperation(currentOperation))
                {
                    mainValueBox.Text = lastValue.ToString();
                    currentState = CurrentState.result;
                }
                else
                {
                    return;
                }
            }
            else if (currentState == CurrentState.operation)
            {
                currentState = CurrentState.error;
                errorMessage = "Neplatný formát";
                PrintErrorMessage();
            }
        }

        /**
        * Funkce pro detekci stisknutých tlačítek na klávesnici
        */
        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            //testovací label
            label1.Text = "cV = " + currentValue.ToString() + "lV = " + lastValue + "cO = " + currentOperation + "lO = " + lastOperation + currentState.ToString();

            char pressedChar = e.KeyChar;

            if (pressedChar >= '0' && pressedChar <= '9')
            {
                double value = (double)(pressedChar - '0');
                AddValue(value);
            }
            else if (pressedChar == ',')
            {
                AddDecimal();
            }
            else if (pressedChar == '+')
            {
                AddOperation(OperationType.add);
            }
            else if (pressedChar == '-')
            {
                AddOperation(OperationType.sub);
            }
            else if (pressedChar == '/')
            {
                AddOperation(OperationType.div);
            }
            else if (pressedChar == '*')
            {
                AddOperation(OperationType.mul);
            }
            //tady dalsi operace

            else if (pressedChar == '=')
            {
                Result();
            }
        }
    }
}
