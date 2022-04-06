using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2
{
    class ArrayReader
    {
        public delegate void ArrayReaderDelegate(int variant);
        public event ArrayReaderDelegate ArrayReaderEvent;

        public void InitSort()
        {
            Console.WriteLine("Введите вариант сортировки в виде числа 1 или 2");
            int variant = Int32.Parse(Console.ReadLine());

            if (variant != 1 && variant != 2) throw new MyException("Совсем не то значение", variant);
            NumberEntered(variant);
        }

        protected void NumberEntered(int variant)
        {
            ArrayReaderEvent?.Invoke(variant);
        }

    }
}
