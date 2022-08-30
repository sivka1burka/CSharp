//*Задача 7.Создать классы Фотография, Категории фотографий
// * Класс Категории фотографий имеет свойства:
// *-CategoryId; -Title; -IsPublished;
//*Класс Фотография имеет следующие свойства:
// *-PhotoId; -CategoryId; -Title; -Rating(от 0 до 5);
//*Создать две коллекции элементов, одну содержащую категоррии фотографий\
// * (не меньше 3), другую содержащую несколько фотографий (не меньше 10)
 
using System;

namespace ConsoleApp2
{
    class PhotoCategory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsPublished { get; set; }

    }
    class Photo
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Photo photo = new Photo();
            photo.Id = 1;
            photo.CategoryId = 2;
            photo.Title = "dfgd";
            photo.Rating = 2;
        }
    }
}
