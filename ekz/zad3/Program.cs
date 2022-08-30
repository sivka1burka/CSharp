//3.Реализовать класс Динозавр.Имеющий следующие свойства:
//- Id
//- Название
//- Вес
//- Размер (Отдельный класс имеющий два параметра – высота и длина)
//Создать список динозавров (не менее 8). Реализовать меню в котором можно выбрать следующие опции (выборки делать при помощи LINQ):
//-Вывести список отсортированный по имени
//- Вывести динозавров вес которых задан диапазоном, который задает пользователь, отсортированные в обратном порядке начиная с самого крупного.
//- Вывести всех динозавров название которых содержит строку вводимую пользователем (например «завр», «раптор»), и которые выше числа
//введенного пользователем. Отсортировать результат по убыванию он самого высокого к самому маленькому.
//Продемонстрировать работу программы.
using System;
using System.Linq;
using System.Collections.Generic;

namespace zad3
{
    class Size
    {
        public int Heigth { get; set; }
        public int Length { get; set; }
       

    }
    class Dino
    {
        public int id { get; set; }
        public string name { get; set; }
        public int weight { get; set; }
        public Size size { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Dino> dinoList = new List<Dino>
            {
                new Dino { id=1,
                    name="Аардоникс",
                    weight=2,
                    size=new Size
                    {
                        Heigth=5,
                        Length=9
                    }
                },
                 new Dino { id=2,
                    name="Агносфитис",
                    weight=5,
                    size=new Size
                    {
                        Heigth=3,
                        Length=12
                    }
                },
                  new Dino { id=3,
                    name="Агухацератопс",
                    weight=3,
                    size=new Size
                    {
                        Heigth=17,
                        Length=5
                    }
                },
                   new Dino { id=4,
                    name="Адамантиазавр",
                    weight=8,
                    size=new Size
                    {
                        Heigth=5,
                        Length=17
                    }
                },
                    new Dino { id=5,
                    name="Аламозавр",
                    weight=12,
                    size=new Size
                    {
                        Heigth=8,
                        Length=9
                    }
                },
                     new Dino { id=6,
                    name="Анабисетия",
                    weight=5,
                    size=new Size
                    {
                        Heigth=7,
                        Length=6
                    }
                },
                      new Dino { id=7,
                    name="Анатотитан",
                    weight=8,
                    size=new Size
                    {
                        Heigth=4,
                        Length=9
                    }
                },
                       new Dino { id=8,
                    name="Велоцираптор",
                    weight=9,
                    size=new Size
                    {
                        Heigth=5,
                        Length=8
                    }
                },
            };
            Console.WriteLine("---------------------");
            //- Вывести список отсортированный по имени
            var sortedByName = dinoList.OrderBy(x => x.name);
            foreach (var dino in sortedByName)
            {
                Console.WriteLine("id: "+dino.id);
                Console.WriteLine("name: "+dino.name);
                Console.WriteLine("weight: " + dino.weight);
                Console.WriteLine("heigth: "+dino.size.Heigth);
                Console.WriteLine("lenght: "+dino.size.Length);
                Console.WriteLine();
            }

            Console.WriteLine("---------------------");
            //- Вывести динозавров вес которых задан диапазоном, который задает пользователь, отсортированные в обратном порядке начиная с самого крупного.
            Console.WriteLine("Введите диапазон веса:");
            Console.Write("От:");
            int i =Convert.ToInt32(Console.ReadLine());
            Console.Write("До:");
            int o = Convert.ToInt32(Console.ReadLine());
            var sortedByDiapazon = dinoList.Where(x => x.weight>=i &&x.weight<=o).OrderByDescending(x=>x.weight);
            foreach (var dino in sortedByDiapazon)
            {
                Console.WriteLine("id: " + dino.id);
                Console.WriteLine("name: " + dino.name);
                Console.WriteLine("weight: " + dino.weight);
                Console.WriteLine("heigth: " + dino.size.Heigth);
                Console.WriteLine("lenght: " + dino.size.Length);
                Console.WriteLine();
            }

            Console.WriteLine("---------------------");
            //- Вывести всех динозавров название которых содержит строку вводимую пользователем (например «завр», «раптор»), и которые выше числа
            // введенного пользователем. Отсортировать результат по убыванию он самого высокого к самому маленькому.

            Console.WriteLine("Введите строку которую должно иметь название динозавра:");
            string str = Console.ReadLine();
            Console.WriteLine("Введите минимальную высоту динозавра:");
            int heig =Convert.ToInt32(Console.ReadLine());
            var sortedByStroka = dinoList.Where(x => x.name.Contains(str) && x.size.Heigth > heig);
            foreach (var dino in sortedByStroka)
            {
                Console.WriteLine("id: " + dino.id);
                Console.WriteLine("name: " + dino.name);
                Console.WriteLine("weight: " + dino.weight);
                Console.WriteLine("heigth: " + dino.size.Heigth);
                Console.WriteLine("lenght: " + dino.size.Length);
                Console.WriteLine();
            }
        }
    }
}
