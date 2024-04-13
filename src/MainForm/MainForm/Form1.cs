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
* Enum obsahující všechny BINÁRNÍ matematické operace.
* Sčítání, odčítání, dělení, násobení, umocňování, obecná odmocnina
*/
public enum OperationType
{
    add, sub, div, mul, exp, sqr
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
        * Funkce pro počítání cifer
        * @param num Číslo, pro které se má počet cifer vzpočítat
        * @return Počet cifer
        */
        public int NumOfDigits(string numStr)
        { 
            int numOfDigits = 0;
            for(int i = 0; i < numStr.Length; i++)
            { 
                if(numStr[i] >= '0' && numStr[i] <= '9')
                { 
                    numOfDigits++;
                }
            }
            return numOfDigits;
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
        * Funkce pro detekci zmáčknutého tlačítka s binární operací z GUI a získání jeho hodnoty (resp. operace)
        */
        private void OperationButtonClick(object sender, EventArgs e)
        {
            OperationButton clickedButton = (OperationButton)(sender);
            AddOperation(clickedButton.operation);
        }

        /**
        * Funkce pro detekci zmáčknutí tlačítka pro faktoriál z GUI
        */
        private void FactorialButtonClick(object sender, EventArgs e)
        {
            ExecuteFactorial();
        }

        /**
        * Funkce pro detekci zmáčknutí tlačítka pro absolutní hodnotu z GUI
        */
        private void AbsoluteButtonClick(object sender, EventArgs e)
        {
            ExecuteAbsolute();
        }

        /**
        * Funkce pro detekci zmáčknutého tlačítka s desetinnou čárkou z GUI
        */
        private void DecimalButtonClick(object sender, EventArgs e)
        {
            AddDecimal();
        }

        /**
        * Funkce pro detekci zmáčknutí tlačítka pro změnu znaménka z GUI
        */
        private void PlusMinusButtonClick(object sender, EventArgs e)
        {
            PlusMinus();
        }

        /**
        * Funkce pro detekci zmáčknutí tlačítka rovnosti z GUI
        */
        public void EqualButtonClick(object sender, EventArgs e)
        {
            Result();
        }

        /**
        * Funkce pro detekci zmáčknutí tlačítka pro mazání posledního znaku z GUI
        */
        private void BackspaceButtonClick(object sender, EventArgs e)
        {
            Backspace();
        }

        /**
        * Funkce pro detekci zmáčknutí resetovacího tlačítka z GUI
        */
        private void ClearButtonClick(object sender, EventArgs e)
        {
            ResetValues();
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

            int numOfDigits = currentValueStr.Length;
            if (currentValueStr.Contains(","))
            {
                numOfDigits--;
            }
            if (currentValueStr.Contains("-"))
            {
                numOfDigits--;
            }
            if (numOfDigits < maxNumOfDigits)
            {
                if (currentValueStr == "0")
                {
                    currentValueStr = value.ToString();
                }
                else if (currentValueStr == "-0")
                {
                    currentValueStr = "-" + value.ToString();
                }
                else
                {
                    currentValueStr += value.ToString();
                    //přidání požadované hodnoty jako poslední cifru
                }
                PrintCurrentValue();
                currentValue = Convert.ToDouble(currentValueStr);
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
        }

        /**
        * Funkce pro nastavení zda je číslo kladné nebo záporné
        */
        private void PlusMinus()
        {
            if (currentState == CurrentState.number)
            {
                if (currentValueStr.Contains("-"))
                {
                    currentValueStr = currentValueStr.Remove(0, 1);
                }
                else
                {
                    currentValueStr = "-" + currentValueStr;
                }
                PrintCurrentValue();
                currentValue = Convert.ToDouble(currentValueStr);
            }
            else if (currentState == CurrentState.operation)
            {
                AddValue(0); //ResetValue
                currentValueStr = "-" + currentValueStr;
                PrintCurrentValue();
            }
        }

        /**
        * Funkce pro mazání poslední cifry
        */
        private void Backspace()
        { 
            if (currentState == CurrentState.number)
            {
                if (NumOfDigits(currentValueStr) <= 1)
                {
                    currentValueStr = "0";
                }
                else
                { 
                   currentValueStr = currentValueStr.Remove(currentValueStr.Length - 1, 1);
                
                }
                PrintCurrentValue();
                currentValue = Convert.ToDouble(currentValueStr);
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
            else if (currentOperation == OperationType.exp)
            {
                mainValueBox.Text = "^";
            }
            else if (currentOperation == OperationType.sqr)
            {
                mainValueBox.Text = "√";
            }
            currentState = CurrentState.operation;
        }

        /**
        * Funkce pro vykonání binárních operací
        * Funkce pracuje s instancí matematické třídy Operations
        * @param operation Operace, která se má vykonat
        * @return Zda vykonání bylo úspěšné
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
            else if (operation == OperationType.exp)
            {
                if(currentValue % 1 == 0 && currentValue >= 0)//kontrola zda je exponent prirozene cislo
                { 
                    currentValue = operations.Exp(lastValue, currentValue);
                }
                else
                { 
                    currentState = CurrentState.error;
                    errorMessage = "Exponent musí být přirozený";
                    PrintErrorMessage();
                    return false;
                }
            }
            else if (operation == OperationType.sqr)
            {
                if(lastValue % 1 == 0 && lastValue >= 0)//kontrola zda je exponent prirozene cislo
                { 
                    if (lastValue % 2 == 0) //pro sudý index odmocniny musí být číslo nezáporné
                    {
                        if(currentValue >= 0)
                        { 
                            currentValue = operations.Sqr(lastValue, currentValue);
                        }
                        else
                        {    
                            currentState = CurrentState.error;
                            errorMessage = "Neplatný formát pro odmocninu";
                            PrintErrorMessage();
                            return false;
                        }
                    }
                    else
                    { 
                        currentValue = operations.Sqr(lastValue, currentValue);
                    }
                }
                else
                { 
                    currentState = CurrentState.error;
                    errorMessage = "Exponent musí být přirozený";
                    PrintErrorMessage();
                    return false;
                }
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
        * Funkce pro vykonání unární operace - faktoriál
        * Výsledek fukce se ihned zobrazí v hlavním textboxu
        */
        public void ExecuteFactorial()
        {
            if (currentState == CurrentState.number)
            {
                if(currentValue % 1 != 0 || currentValue < 0)//kontrola přirozeného čísla
                {
                    currentState = CurrentState.error;
                    errorMessage = "Základ musí být přirozený";
                    PrintErrorMessage();
                    return;
                }
                currentValue = operations.Fac(currentValue);
                if (currentValue > maxDisplayableVal)
                {
                    currentState = CurrentState.error;
                    errorMessage = "Přetečení";
                    PrintErrorMessage();
                    return;
                }
                currentValueStr = Convert.ToString(currentValue);
                PrintCurrentValue();
            }
        }

        /**
        * Funkce pro vykonání unární operace - absolutní hodnota
        * Výsledek fukce se ihned zobrazí v hlavním textboxu
        */
        public void ExecuteAbsolute()
        {
            if (currentState == CurrentState.number)
            {
                currentValue = operations.Abs(currentValue);
                currentValueStr = Convert.ToString(currentValue);
                PrintCurrentValue();
            }
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

                    //test = string.Format("{0:0.000000000000}", lastValue);
                    //label1.Text = test;

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
            else if (pressedChar == '^')
            {
                AddOperation(OperationType.exp);
            }
            //else if (pressedChar == "char ktery reprezentuje odmocninu")
            //{
            //    AddOperation(OperationType.sqr);
            //}
            //tady dalsi operace
            
            
            else if (pressedChar == (char)Keys.Back)
            {
                Backspace();
            }


            else if (pressedChar == '=')
            {
                Result();
            }
        }
    }
}
