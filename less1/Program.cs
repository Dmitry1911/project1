using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Dmitry";
            DateTime dateTime = DateTime.Now;
            Console.WriteLine($"Привет!,меня зовут {name},сегодня {dateTime}");
            Console.ReadLine();

        }
    }
}
