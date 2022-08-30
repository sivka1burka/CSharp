//*Задача 5.Создать класс покупатель имеющий следующие поля(свойства):
// *-Id - Имя - Страна - Город - Дата регистрации
//* Создать коллекцию покупателей(не меньше 10)
// *С помощью запросов LINQ следующие выборки:
// *А) Всех покупателей по стране, отсортировать по имени покупателя
// * Б) Сгруппировать покупателей по городу
// * В) Выбрать пользователей по определенному году в "дате регистрации"
// * Г) Выбрать всех пользователей зарегистрированных между двумя датами
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp18
{
    class Buyer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public DateTime regDate { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Buyer> buyer=new List<Buyer>();
            buyer.Add(new Buyer()
            {
                id = 1,
                name = "John",
                country = "Spain",
                city = "Barcelona",
                regDate = new DateTime(2016, 7, 20)
            });
            buyer.Add(new Buyer()
            {
                id = 2,
                name = "Alex",
                country = "Spain",
                city = "Madrid",
                regDate = new DateTime(2018, 7, 20)
            });
            buyer.Add(new Buyer()
            {
                id = 3,
                name = "Harry",
                country = "Usa",
                city = "New-York",
                regDate = new DateTime(2015, 7, 20)
            });
            buyer.Add(new Buyer()
            {
                id = 4,
                name = "William",
                country = "Germany",
                city = "Bremen",
                regDate = new DateTime(2018, 7, 20)
            });
            buyer.Add(new Buyer()
            {
                id = 5,
                name = "Jacob",
                country = "Spain",
                city = "Barcelona",
                regDate = new DateTime(2021, 7, 20)
            });
            buyer.Add(new Buyer()
            {
                id = 6,
                name = "Oliver",
                country = "Germany",
                city = "Bremen",
                regDate = new DateTime(2020, 7, 20)
            });
            buyer.Add(new Buyer()
            {
                id = 7,
                name = "Ostin",
                country = "Canada",
                city = "Toronto",
                regDate = new DateTime(2018, 7, 20)
            });
            buyer.Add(new Buyer()
            {
                id = 8,
                name = "Oscar",
                country = "Spain",
                city = "Barcelona",
                regDate = new DateTime(2019, 7, 20)
            });
            buyer.Add(new Buyer()
            {
                id = 9,
                name = "Charley",
                country = "Spain",
                city = "Valencia",
                regDate = new DateTime(2021, 7, 20)
            });
            buyer.Add(new Buyer()
            {
                id = 10,
                name = "Thomas",
                country = "Canada",
                city = "Toronto",
                regDate = new DateTime(2016, 7, 20)
            });
            // *А) Всех покупателей по стране, отсортировать по имени покупателя
            var resultA =buyer.OrderBy(x => x.name);
            var resultB = resultA.GroupBy(x => x.country);

            foreach (var country in resultB)
            {
                Console.WriteLine("__________");
                Console.WriteLine(country.Key);
                Console.WriteLine();
                foreach (var item in country)
                {
                    Console.WriteLine(item.name);
                }
            }
            // * Б) Сгруппировать покупателей по городу
            Console.WriteLine("******************************************************************************");
            var resultC=buyer.GroupBy(x => x.city);
            foreach(var city in resultC)
            {
                Console.WriteLine("__________");
                Console.WriteLine(city.Key);
                Console.WriteLine();
                foreach (var item in city)
                {
                    Console.WriteLine(item.name);
                }
            }
            // * В) Выбрать пользователей по определенному году в "дате регистрации"
            Console.WriteLine("******************************************************************************");
            var resultG = buyer.GroupBy(x => x.regDate.Year);
            foreach (var year in resultG)
            {
                Console.WriteLine("__________");
                Console.WriteLine(year.Key);
                Console.WriteLine();
                foreach (var item in year)
                {
                    Console.WriteLine(item.name);
                }
            }
            // * Г) Выбрать всех пользователей зарегистрированных между двумя датами
            Console.WriteLine("******************************************************************************");
            int year1 = 2016;
            int year2 = 2020;
            var resultH = buyer.Where(x=> x.regDate.Year >= year1 && x.regDate.Year <= year2).GroupBy(x => x.regDate.Year);
            foreach (var year in resultH)
            {
                Console.WriteLine("__________");
                Console.WriteLine(year.Key);
                Console.WriteLine();
                foreach (var item in year)
                {
                    Console.WriteLine(item.name);
                }
            }



        }
    }
}
