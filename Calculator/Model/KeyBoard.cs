using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Calculator.Model
{
    internal class KeyBoard
    {
        internal IDictionary<Keys, Input> inputKey = new Dictionary<Keys, Input>();
        
        public KeyBoard()
        {
            inputKey.Add(Keys.D1, new Input("1"));
            inputKey.Add(Keys.NumPad1, new Input("1"));
            inputKey.Add(Keys.D2, new Input("2"));
            inputKey.Add(Keys.NumPad2, new Input("2"));
            inputKey.Add(Keys.D3, new Input("3"));
            inputKey.Add(Keys.NumPad3, new Input("3"));
            inputKey.Add(Keys.D4, new Input("4"));
            inputKey.Add(Keys.NumPad4, new Input("4"));
            inputKey.Add(Keys.D5, new Input("5"));
            inputKey.Add(Keys.NumPad5, new Input("5"));
            inputKey.Add(Keys.D6, new Input("6"));
            inputKey.Add(Keys.NumPad6, new Input("6"));
            inputKey.Add(Keys.D7, new Input("7"));
            inputKey.Add(Keys.NumPad7, new Input("7"));
            inputKey.Add(Keys.D8, new Input("8"));
            inputKey.Add(Keys.NumPad8, new Input("8"));
            inputKey.Add(Keys.D9, new Input("9"));
            inputKey.Add(Keys.NumPad9, new Input("9"));
            inputKey.Add(Keys.D0, new Input("0"));
            inputKey.Add(Keys.NumPad0, new Input("0"));
            inputKey.Add(Keys.Enter, new Input("="));
            inputKey.Add(Keys.Add, new Input("+"));
            inputKey.Add(Keys.Oemplus, new Input("+"));
            inputKey.Add(Keys.Subtract, new Input("-"));
            inputKey.Add(Keys.OemMinus, new Input("-"));
            inputKey.Add(Keys.Divide, new Input("/"));
            inputKey.Add(Keys.Multiply, new Input("*"));
            inputKey.Add(Keys.Escape, new Input("Clear"));
            inputKey.Add(Keys.Back, new Input("Bacspace"));
        }
    }
}