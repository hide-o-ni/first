using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите ваше имя");
            //string name = Console.ReadLine();
            //Console.WriteLine ("Привет " + name);

            /*string secret = string.Empty;
            string someString = "переменная со строчной буквы,\n";
            string someString2 = "Объект с заглавной буквы";
            string s = someString + someString2;
            Console.WriteLine(secret);                                                              

            //дата и время
            DateTime thistime = new DateTime(2021,10,1); 
            bool isLeapYear = DateTime.IsLeapYear(thistime.Year);       //берем год и проверяем на високосный
            Console.WriteLine(isLeapYear);
            DateTime thisMoment = DateTime.Now;
            DateTime addHoursfromNow = thisMoment.AddHours(1);      //добавляет час
            Console.WriteLine(addHoursfromNow);
            int year = DateTime.Now.Year;       // 2021
            DayOfWeek dayOfweek = DateTime.Now.DayOfWeek;       //узнать день недели
            Console.WriteLine(dayOfweek);
            DateTime date = DateTime.Today;
            TimeSpan time = thisMoment.TimeOfDay;
            TimeSpan duration = new TimeSpan(3,0,0,0);       //продолжительность в днях 
            DateTime threeDaysFromNow = thisMoment.Add(duration);*/

            //типы данных
            int intValue = 10;
            long longValue;
            longValue = intValue;       //можно

            int intValue1;
            long longValue1 = 10;
            intValue1 = (int)longValue1;   //указать комилятору, что не будет потери данных                 
            var x = 3.0 + 2 - 1.5;      //авто определение
            Console.WriteLine(x.GetType().ToString());      //получить и вывести тип данных

            //строки
            string s1 = "1234";
            int lenghtOfString = s1.Length;


            Console.WriteLine("нажмите <Enter> для выхода....");
            Console.Read();
        }
    }
}
