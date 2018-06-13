using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    class Number
    {
        StringBuilder currentNumber = new StringBuilder();

        public Number()
        {
            currentNumber.Append(0);
        }
        internal StringBuilder GetExpression { get { return currentNumber; } }

        internal void AddUnit(int unit)
        {
            currentNumber = currentNumber.Append(unit);
        }

        internal void Clear()
        {
            currentNumber.Clear();
        }
    }


}
