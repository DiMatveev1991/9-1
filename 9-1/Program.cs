using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _9_1;

class Program
{
    static void Main (string [] args)
    {
        Exception[] exception = { new PlatformNotSupportedException(), new ArgumentNullException(), new ArgumentOutOfRangeException(), new FormatException(), new MyException () };

        foreach (Exception e in exception)
        {
            try
            {
                throw e;
            }
            catch (PlatformNotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


    }

}