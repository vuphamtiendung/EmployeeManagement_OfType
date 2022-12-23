using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OfTypeInLinQ_002
{
    internal class PartTimeEmployee : Employee
    {
        public PartTimeEmployee() : base() { }

        public override double Salary() => base.Salary() + 500000;
        public override void InputEmployee() => base.InputEmployee();
        public override void Display() => base.Display();
    }
}
