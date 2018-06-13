using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Calculator.Model;
namespace Calculator
{
    delegate void Message();
    public partial class calculatorForm : Form
    {
        internal Number currentNumber = new Number();
        InputCommands keyCommandsCollection = new InputCommands();
        KeyBoard _keyBoardInterception = new KeyBoard();
            //private IDictionary<string, Input> inputKey = new Dictionary<string, Input>();

        private IDictionary<string, ICommand> _command = new Dictionary<string, ICommand>();

        public calculatorForm()
        {
            InitializeComponent();
        }

        private void calculatorForm_Load(object sender, EventArgs e)
        {
            _command.Add("1", new DigitCommand(Digits.digit1, currentNumber));
            _command.Add("2", new DigitCommand(Digits.digit2, currentNumber));
            _command.Add("3", new DigitCommand(Digits.digit3, currentNumber));
            _command.Add("4", new DigitCommand(Digits.digit4, currentNumber));
            _command.Add("5", new DigitCommand(Digits.digit5, currentNumber));
            _command.Add("6", new DigitCommand(Digits.digit6, currentNumber));
            _command.Add("7", new DigitCommand(Digits.digit7, currentNumber));
            _command.Add("8", new DigitCommand(Digits.digit8, currentNumber));
            _command.Add("9", new DigitCommand(Digits.digit9, currentNumber));
            _command.Add("0", new DigitZeroCommand(currentNumber));
            _command.Add("Clear", new ClearCommand(currentNumber));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _command[keyCommandsCollection.getCommandCode("1").ReadInput].Execute();
            display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _command[button2.Text].Execute();
            display();
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            _command[buttonZero.Text].Execute();
            display();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _command[button4.Text].Execute();
            display();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _command[button5.Text].Execute();
            display();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _command[button6.Text].Execute();
            display();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _command[button7.Text].Execute();
            display();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _command[button8.Text].Execute();
            display();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _command[button9.Text].Execute();
            display();
        }


        private void calculatorForm_KeyDown(object sender, KeyEventArgs e)
        {

            if (_keyBoardInterception.inputKey.ContainsKey(e.KeyCode))
            {
                //textBox1.Text= inputKey[e.KeyCode.ToString()].ReadInput.ToString();
                _command[_keyBoardInterception.inputKey[e.KeyCode].ReadInput.ToString()].Execute();
                display();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _command[button3.Text].Execute();
            display();
        }
        private void display()
        {
            textBox1.Text = currentNumber.GetExpression.ToString();
        }
         
        private void ActivateOperationButtons()
        {
            addButton.Enabled = true;
            divideButton.Enabled = true;
            multiplyButton.Enabled = true;
            substractButton.Enabled = true;
        }

        private void DeactivateOperationButtons()
        {
            addButton.Enabled = false;
            divideButton.Enabled = false;
            multiplyButton.Enabled = false;
            substractButton.Enabled = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            _command["Clear"].Execute();
            display();
        }
    }
}
