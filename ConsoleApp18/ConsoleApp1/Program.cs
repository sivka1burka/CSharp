//*Задача 6.Создать интерфейс IAnimal, имеющий следующие свойства:
// *-класс(млекопитающие, насемые, птицы, пресмыкающиеся и т.д.)
// * -вид(усатый кит, беркут, серый волк, стрекоза, бенгальский тигр)
// * Реализовать интерфейс IAnimal в трех классах.
// * Создать коллекцию IAnimal (не меньше 6 экземпляров)
// *А) Сгруппировать элементы коллекции по классу (млекопитающие, насекомые)
// *Б) Сгруппировать элементы коллекции по классу первого элемента
// * в коллекции, отсортировать элементы по виду
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    interface IAnimal
    {
        string AnimalClass { get; set; }
        string type { get; set; }

    }
    class Animal1 : IAnimal
    {
        public string AnimalClass { get; set; }
        public string type { get; set; }
    }
    class Animal2 : IAnimal
    {
        public string AnimalClass { get; set; }
        public string type { get; set; }
    }
    class Animal3 : IAnimal
    {
        public string AnimalClass { get; set; }
        public string type { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(new Animal1()
            {
                AnimalClass = "Птицы",
                type ="Беркут"
            }) ;
            animals.Add(new Animal2()
            {
                AnimalClass = "Насекомые",
                type = "Гусеница"
            });
            animals.Add(new Animal3()
            {
                AnimalClass = "Насекомые",
                type = "Богомол"
            });
            animals.Add(new Animal3()
            {
                AnimalClass = "Млекопитающие",
                type = "Белка"
            });
            animals.Add(new Animal3()
            {
                AnimalClass = "Пресмыкающиеся",
                type = "Ящерица"
            });
            animals.Add(new Animal3()
            {
                AnimalClass = "Млекопитающие",
                type = "Летучая мышь"
            });
            // *А) Сгруппировать элементы коллекции по классу (млекопитающие, насекомые)

            var collection1 = animals.Where(x => x.AnimalClass == "Млекопитающие" || x.AnimalClass == "Насекомые").GroupBy(x => x.AnimalClass);
            foreach (var AnimClass in collection1)
            {
                Console.WriteLine("______________________");
                Console.WriteLine(AnimClass.Key + ":");
                Console.WriteLine();
                foreach (var item in AnimClass)
                {
                    Console.WriteLine(item.type);
                }
            }
            // *Б) Сгруппировать элементы коллекции по классу первого элемента
            // * в коллекции, отсортировать элементы по виду
            string AnimClassFirst = animals[0].AnimalClass;
            var collection2=animals.Where(x => x.AnimalClass == AnimClassFirst).OrderBy(x => x.type).GroupBy(x => x.AnimalClass);
            foreach (var AnimClass in collection2)
            {
                Console.WriteLine("______________________");
                Console.WriteLine(AnimClass.Key + ":");
                Console.WriteLine();
                foreach (var item in AnimClass)
                {
                    Console.WriteLine(item.type);
                }
            }
            
        }
    }
}
