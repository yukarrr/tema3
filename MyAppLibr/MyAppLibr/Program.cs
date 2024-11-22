using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppLibr
{
    internal class Program
    {
        class Program1
        {
            static void Main(string[] args)
            {
                MyLibrary myLib = new MyLibrary();

                myLib.Hello();
                myLib.User("Юля");

                int result = myLib.sum(5, 3);
                Console.WriteLine($"Сумма: {result}");

                int dellPrint = myLib.dell(10, 2);
                Console.WriteLine(dellPrint);

                bool isEven = myLib.IsEven(4);
                Console.WriteLine($"Число четное? {isEven}");

                Console.ReadLine();
            }
        }
    }
}
