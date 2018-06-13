using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    internal class Input
    {
        private StringBuilder currentInput = new StringBuilder();

        public Input(string currentInput)
            {
            this.currentInput.Append(currentInput);
            }

        internal string ReadInput
            {
            get { return currentInput.ToString(); }
            }
    }
}
