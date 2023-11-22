using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestConsoleApp
{
    public class WorldFunction
    {
        public string ReturnRahulIfZero(int num)
        {
            if (num == 0)
            {
                return "Rahul";
            }
            else
            {
                return "Send Zero Number";
            }
        }
    }
}
