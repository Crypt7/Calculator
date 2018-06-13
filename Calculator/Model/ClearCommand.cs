using System;

namespace Calculator.Model
{
    internal class ClearCommand : ICommand
    {
        private Number currentNumber;
        public ClearCommand(Number currentNumber)
        {
            this.currentNumber = currentNumber;
        }
        public void Execute()
        {
            currentNumber.Clear();
        }
    }
}