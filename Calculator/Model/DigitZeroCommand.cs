using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    internal class DigitZeroCommand : ICommand
    {
        private Number currentNumber;
        //private int unit;
        public DigitZeroCommand(Number currentNumber)
        {
            this.currentNumber = currentNumber;
        }
        public void Execute()
        {
            if (currentNumber.GetExpression.ToString() != "0")
            {
                currentNumber.AddUnit(0);
            }
        }
    }
}
