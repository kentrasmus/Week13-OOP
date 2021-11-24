using System;

namespace OOP_PartI
{
    class Program
    {
        class Dog
        {
            string name;
             int spots;
             double happiness;

            public Dog(string _name, int _spots) //constructor
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"The Dog {name} has been created");
            }
            //getters'
            public string Name // name getter
            {
                get { return name; }
            }

            public int Spots
            {
                get { return spots; }
            }

            public double Happiness 
            {
                get { return happiness; }
            }

            public void Barks()
            {
                Console.WriteLine("Woof-woof!");
                happiness += 0.2; //happiness = happiness + 0.2
            }
            public void Wags()
            {
                Console.WriteLine($"{Name} : Wiggle-Wiggle");
            }
            public void Rename(string newName)
            {
                name = newName;
                
            }
            public void ShopDogDate()
            {
                Console.WriteLine($"name: {Name}");
                Console.WriteLine($"spots: {spots}");
                Console.WriteLine($"Lvl of happy: {happiness}");
            }
        }
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Koer",15);
            myDog.Barks();
            Console.WriteLine($"{myDog.Name}'s level of happiness: {myDog.Happiness} ");
            Dog myDogZZ = new Dog("Jack", 169);
            Console.WriteLine($"{myDogZZ.Name}'s level of happiness: {myDogZZ.Happiness} ");


            while(myDog.Happiness != 1)
            {
                myDog.Barks();
            }
            myDog.Wags();
            Console.WriteLine($"Enter a New Name for the dog {myDog.Name}");
            string userInput = Console.ReadLine();
            myDog.Rename(userInput);
            myDog.ShopDogDate();
        }
    }
}
