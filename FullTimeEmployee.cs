using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OfTypeInLinQ_002
{
    internal class FullTimeEmployee : Employee
    {
        public FullTimeEmployee() : base()
        {
        }

        public override double Salary() => base.Salary() + 1500000;

        public override void InputEmployee() => base.InputEmployee();
        
        public override void Display() => base.Display();
    }
}
