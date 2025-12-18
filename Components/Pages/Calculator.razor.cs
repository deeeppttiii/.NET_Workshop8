using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop8.Pages
{
    public partial class Calculator
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public double Result { get; set; }

        public void Add()
        {
            Result = Number1 + Number2;
        }

        public void Subtract()
        {
            Result = Number1 - Number2;
        }

        public void Multiply()
        {
            Result = Number1 * Number2;
        }

        public void Divide()
        {
            Result = Number2 != 0 ? Number1 / Number2 : 0;
        }
    }
}
