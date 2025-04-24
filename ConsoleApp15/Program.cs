using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        delegate void Message(); // Объявление делегата

        static void Main(string[] args)
        {
            Message message; // Создание объекта делегата

            DateTime now = DateTime.Now;
            int hour = now.Hour;

            if (hour < 12)
            {
                message = GoodMorning;
            }
            else if (hour < 18)
            {
                message = GoodAfternoon;
            }
            else
            {
                message = GoodEvening;
            }

            message(); 
            Console.ReadKey();
        }

        static public void GoodMorning() => Console.WriteLine("Доброе утро");
        static public void GoodAfternoon() => Console.WriteLine("Добрый день");
        static public void GoodEvening() => Console.WriteLine("Добрый вечер");

    }
}
