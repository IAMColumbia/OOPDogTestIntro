using DogLibrary;
using System;

namespace OOPDogTestIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dog Tests....");
            Dog d = new Dog();
            //Test Happy Birthday
            Console.WriteLine(d.About());
            d.HappyBirthday();
            Console.WriteLine(d.About());

            //Test Eat
            d.Eat();
            Console.WriteLine(d.About());
        }
    }
}
