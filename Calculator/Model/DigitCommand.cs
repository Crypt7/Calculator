
namespace Calculator.Model
{
    internal class DigitCommand : ICommand
    {
        private Number currentNumber;
        private int unit;
        public DigitCommand(Digits unit, Number currentNumber)
        {
            this.currentNumber = currentNumber;
            this.unit = (int)unit;
        }
        public void Execute()
        {
            if (currentNumber.GetExpression.ToString() == "0")
            {
                currentNumber.Clear();
            }
            currentNumber.AddUnit(unit);
        }
    }
}
