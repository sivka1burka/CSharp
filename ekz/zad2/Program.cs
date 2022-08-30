using System;

namespace zad2
{
    interface IDog
    {
        public string name { get; set; }
        public string function { get;}
        public void showFunction();
    }
    class HuntingDog : IDog
    {
        public string name { get; set; }

        public string function 
        {
            get
            {
                return function;
            }
            set
            {
                value = "Охотничья";
            }
        }


        public void showFunction()
        {
            throw new NotImplementedException();
        }
    }
    class SeriveDog : IDog
    {
        public string name { get; set; }

        public string function
        {
            get
            {
                return function;
            }
            set
            {
                value = "Служебная";
            }
        }


        public void showFunction()
        {
            throw new NotImplementedException();
        }
    }
    //class DecorativeDog : IDog
    //{
    //    public string name { get; set; }
        
    //    public string function { get; }
    //    function="Декоративная";
        


    //    public void showFunction()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}   
    class Program
    {
        static void Main(string[] args)
        {
            HuntingDog test=new HuntingDog();
            test.name = "Bim";
            Console.WriteLine(test.function);
        }
    }
}
