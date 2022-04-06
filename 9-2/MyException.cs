using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2
{
    class MyException : ArgumentException
    {
        public int Value { get; set; }


        public MyException(string message, int value) : base(message)
        {
            Value = value;
            HelpLink = "www.support.com";
        }

    }
    class MyException1 : Exception
    {
 
        public MyException1 (string massege )
        {
            Console.WriteLine (massege);
        }

    }

}
