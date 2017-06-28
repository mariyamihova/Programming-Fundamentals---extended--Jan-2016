using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        class Dog
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int NumberOfLegs { get; set; }
            public void ProduceSound()
            {
                Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
            }
        }
        class Cat
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int IntelligentIQ { get; set; }
            public void ProduceSound()
            {
                Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
            }
        }
        class Snake
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int CrueltyCoefficient { get; set; }

            public  void ProduceSound()
            {
                Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
            }
        }
        static void Main()
        {
            var inputLine = Console.ReadLine();
            var dogs = new Dictionary<string,Dog>();
            var cats = new Dictionary<string, Cat>();
            var snakes = new Dictionary<string, Snake>();

            while (inputLine!= "I'm your Huckleberry")
            {
                var splittedInput = inputLine.Split(' ');
                if (splittedInput.Length > 2)
                {
                    var type = splittedInput[0];
                    var name = splittedInput[1];
                    var age = int.Parse(splittedInput[2]);
                    var parameter = int.Parse(splittedInput[3]);

                    if (type == "Dog")
                    {
                        var newDog = new Dog
                        {
                            Name = name,
                            Age = age,
                            NumberOfLegs = parameter

                        };
                        dogs.Add(newDog.Name, newDog);
                    }
                    else if (type == "Cat")
                    {
                        var newCat = new Cat
                        {
                            Name = name,
                            Age = age,
                            IntelligentIQ = parameter
                        };
                        cats.Add(newCat.Name, newCat);
                    }
                    else if (type == "Snake")
                    {
                        var newSnake = new Snake
                        {
                            Name = name,
                            Age = age,
                            CrueltyCoefficient = parameter

                        };
                        snakes.Add(newSnake.Name, newSnake);
                    }
                }
                else
                {
                    var animalName = splittedInput[1];
                    if (dogs.ContainsKey(animalName))
                    {
                        dogs[animalName].ProduceSound();
                    }
                    else if (cats.ContainsKey(animalName))
                    {
                       cats[animalName].ProduceSound();
                    }
                    else if (snakes.ContainsKey(animalName))
                    {
                        snakes[animalName].ProduceSound();
                    }
                }
                inputLine = Console.ReadLine();
            }

            foreach (var dog in dogs.Values)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }
            foreach (var cat in cats.Values)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IntelligentIQ}");
            }
            foreach (var snake in snakes.Values)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }
        }
    }
}
