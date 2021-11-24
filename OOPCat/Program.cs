using System;

namespace OOPCat
{
    class Program
    {
        class Cat
        {
            string name;
            string color;
            double hungriness;

            public Cat(string _name, string _color) //constructor
            {
                name = _name;
                color = _color;
                hungriness = 0;
                Console.WriteLine($"The Dog {name} has been created");
            }
            //getters'
            public string Name // name getter
            {
                get { return name; }
            }

            public string Color
            {
                get { return color; }
            }

            public double Happiness
            {
                get { return hungriness; }
            }

            public void Sleeps()
            {
                Console.WriteLine("ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ");
                hungriness += 0.2; //happiness = happiness + 0.2
            }
            public void Meow()
            {
                Console.WriteLine($"{Name} : says\" meow\"");
            }
            public void Rename(string newName)
            {
                name = newName;

            }
            public void ShopDogDate()
            {
                Console.WriteLine($"name: {Name}");
                Console.WriteLine($"spots: {color}");
                Console.WriteLine($"Lvl of happy: {hungriness}");
            }
        }
        static void Main(string[] args)
        {
            Cat myDog = new Cat("Garfield","gingerzz");
            


            while (myDog.Happiness != 1)
            {
                myDog.Sleeps();
            }
            myDog.Meow();
            Console.WriteLine($"Enter a New Name for the dog {myDog.Name}");
            string userInput = Console.ReadLine();
            myDog.Rename(userInput);
            myDog.ShopDogDate();
        }
    }
}
