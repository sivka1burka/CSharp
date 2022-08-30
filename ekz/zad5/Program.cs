using System;

namespace zad5
{
    class Date<T,V>
    {
        public T day;
        public V month;
        public Date(T day,V month)
        {
            this.day = day;
            this.month = month;
        }
        public void ShowInfo()
        {
            Console.WriteLine("День: " +day);
            Console.WriteLine("Месяц: " + month);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Date<string, int> date = new Date<string, int>("девять", 2);
            date.ShowInfo();
            Date<int, int> date2 = new Date<int, int>(3, 2);
            date2.ShowInfo();
            Date<string, string> date3 = new Date<string, string>("девять", "второй");
            date3.ShowInfo();
        }
    }
}
