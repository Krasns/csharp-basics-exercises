using System;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = "";

            while (inputData.ToLower() != "end")
            {
                Console.WriteLine("Enter: AnimalType AnimalName AnimalWeight AnimalLivingRegion");
                inputData = Console.ReadLine();

                var animalData = inputData.Split(' ');
                string[] foodData = new string[2];

                switch (animalData[0].ToLower())
                {
                    case "cat":
                        Console.Write("Enter cat breed: ");
                        var catBreed = Console.ReadLine();
                        var cat = new Cat(animalData[0], animalData[1], Convert.ToDouble(animalData[2]), animalData[3], catBreed);
                        cat.MakeSound();

                        Console.WriteLine("Enter: FoodTipe(Meat/Vegetable) EatenFoodQuantity");
                        foodData = Console.ReadLine().Split(' ');
                        cat._foodEaten = Convert.ToInt32(foodData[1]);

                        Console.WriteLine($"{cat._animalType}");

                        break;
                    case "tiger":
                        var tiger = new Tiger(animalData[0], animalData[1], Convert.ToDouble(animalData[2]), animalData[3]);
                        tiger.MakeSound();

                        Console.WriteLine("Enter: FoodTipe(Meat/Vegetable) EatenFoodQuantity");
                        foodData = Console.ReadLine().Split(' ');
                        if (foodData[0] == "Meat")
                        {
                            tiger._foodEaten = Convert.ToInt32(foodData[1]);
                        }
                        else
                        {
                            Console.WriteLine($"{tiger._animalType}are not eating that type of food!");
                        }
                        break;
                    case "mouse":
                        var mouse = new Mouse(animalData[0], animalData[1], Convert.ToDouble(animalData[2]), animalData[3]);
                        mouse.MakeSound();

                        Console.WriteLine("Enter: FoodTipe(Meat/Vegetable) EatenFoodQuantity");
                        foodData = Console.ReadLine().Split(' ');
                        if (foodData[0] == "Vegetable")
                        {
                            mouse._foodEaten = Convert.ToInt32(foodData[1]);
                        }
                        else
                        {
                            Console.WriteLine($"{mouse._animalType}are not eating that type of food!");
                        }

                        break;
                    case "zebra":
                        var zebra= new Zebra(animalData[0], animalData[1], Convert.ToDouble(animalData[2]), animalData[3]);
                        zebra.MakeSound();

                        Console.WriteLine("Enter: FoodTipe(Meat/Vegetable) EatenFoodQuantity");
                        foodData = Console.ReadLine().Split(' ');
                        if (foodData[0] == "Vegetable")
                        {
                            zebra._foodEaten = Convert.ToInt32(foodData[1]);
                        }
                        else
                        {
                            Console.WriteLine($"{zebra._animalType}are not eating that type of food!");
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong animal!");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}