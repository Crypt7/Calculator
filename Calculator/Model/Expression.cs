using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    internal class Expression
    {
        private StringBuilder currentExpression;

        public Expression(object currentExpression)
        {
            this.currentExpression.Append((StringBuilder)(currentExpression));
        }

        string GetExpression { get{return currentExpression.ToString();}} 
    }
}
