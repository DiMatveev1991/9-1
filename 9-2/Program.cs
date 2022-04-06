using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _9_2;


class Program
{
    public static string[] SecondNameList;
    static void Main(string[] args)
    {
        Console.WriteLine("Введите 5 фамилий");
        SecondNameList = new string[5];
        try
        {
            for (int i = 0; i < 5; i++)
            {
                SecondNameList[i] = Console.ReadLine();
            }
            for (int i = 0; i < 5; i++)
            { 
                for (int j = i+1; j < 5; j++)
                {
                    if (SecondNameList[i] == SecondNameList[j]) throw new MyException1("введены две одинаковые фамилии");
                }
            }

        }
        catch (Exception ex) 
        { 
            Console.WriteLine (ex.Message);
        }

        ArrayReader arrayReader = new ArrayReader();
        arrayReader.ArrayReaderEvent += Sort;
        arrayReader.ArrayReaderEvent += ShowResult;


        try
        {
            arrayReader.InitSort();
        }
        catch (MyException ex)
        {
            Console.Beep();
            Console.WriteLine(ex.Message);
            Console.WriteLine($"Введенное значение: {ex.Value}");
            Console.WriteLine($"Подробнее об ошибке можно прочитать: {ex.HelpLink}");
        }


        static void Sort(int variant)
        {
            switch (variant)
            {
                case 1: Array.Sort(SecondNameList); break;
                case 2:
                    {
                        Array.Sort(SecondNameList);
                        Array.Reverse(SecondNameList);
                        break;
                    }


            }
        }
        static void ShowResult(int variant)
        {
            Console.WriteLine("Ниже отображается результат");
            foreach (var item in SecondNameList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
