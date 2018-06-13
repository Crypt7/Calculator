using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    internal class InputCommands
    {
        private IDictionary<string, Input> inputKey;
        public InputCommands()
        {
            inputKey = new Dictionary<string, Input>();
            inputKey.Add("1", new Input("1"));
            inputKey.Add("2", new Input("2"));
            inputKey.Add("3", new Input("3"));
            inputKey.Add("4", new Input("4"));
            inputKey.Add("5", new Input("5"));
            inputKey.Add("6", new Input("6"));
            inputKey.Add("7", new Input("7"));
            inputKey.Add("8", new Input("8"));
            inputKey.Add("9", new Input("9"));
            inputKey.Add("0", new Input("0"));
            inputKey.Add("=", new Input("="));
            inputKey.Add("+", new Input("+"));
            inputKey.Add("-", new Input("-"));
            inputKey.Add("/", new Input("/"));
            inputKey.Add("*", new Input("*"));
            inputKey.Add("Clear", new Input("Clear"));
            inputKey.Add("Bacspace", new Input("Bacspace"));
        }
        internal Input getCommandCode(string key)
        {
            return inputKey[key];
        }
    }
}
