using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1
{
    internal class MyException: FileNotFoundException
    {
public MyException ()
        {

        }
        public MyException (string message) : base(message)
        { }
    }
}
