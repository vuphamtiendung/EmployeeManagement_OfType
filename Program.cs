using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OfTypeInLinQ_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserAction useraction = new UserAction();
            useraction.Perform();
            ReadLine();
        }
    }
}
