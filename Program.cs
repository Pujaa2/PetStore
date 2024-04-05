
using PetStore;
using System.Text.Json;

namespace PetStore

{
    public class Program
    {

        static void Main(string[] args)
        {

            var productLogic = new ProductLogic();

            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Press 2 to view a dog leash");
            Console.WriteLine("Type 'exit' to quit");

            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "exit")
            {
                if (userInput == "1")
                {
                    Console.WriteLine("Enter product type (CatFood/DogLeash):");
                    string productType = Console.ReadLine();

                    if (productType.ToLower() == "catfood")
                    {
                        CatFood catFood = new CatFood();

                        Console.WriteLine("Enter name:");
                        catFood.Name = Console.ReadLine();

                        Console.WriteLine("Enter price:");
                        catFood.Price = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Enter quantity:");
                        catFood.Quantity = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter description:");
                        catFood.Description = Console.ReadLine();

                        Console.WriteLine("Enter weight (in pounds):");
                        catFood.WeightPounds = double.Parse(Console.ReadLine());

                        Console.WriteLine("Is it kitten food? (true/false):");
                        catFood.KittenFood = bool.Parse(Console.ReadLine());

                        productLogic.AddProduct(catFood);
                    }
                    else if (productType.ToLower() == "dogleash")
                    {
                        DogLeash dogLeash = new DogLeash();

                        Console.WriteLine("Enter name:");
                        dogLeash.Name = Console.ReadLine();

                        Console.WriteLine("Enter price:");
                        dogLeash.Price = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Enter quantity:");
                        dogLeash.Quantity = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter description:");
                        dogLeash.Description = Console.ReadLine();

                        Console.WriteLine("Enter length (in inches):");
                        dogLeash.LengthInches = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter material:");
                        dogLeash.Material = Console.ReadLine();

                        productLogic.AddProduct(dogLeash);
                    }
                    else
                    {
                        Console.WriteLine("Invalid product type.");
                    }
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("Enter the name of the dog leash:");
                    string leashName = Console.ReadLine();

                    DogLeash leash = productLogic.GetDogLeashByName(leashName);
                    if (leash != null)
                    {
                        Console.WriteLine(JsonSerializer.Serialize(leash));
                    }

                    Console.WriteLine("Press 1 to add a product");
                    Console.WriteLine("Press 2 to view a dog leash");
                    Console.WriteLine("Type 'exit' to quit");
                    userInput = Console.ReadLine();
                }
            }
        }


    }
}