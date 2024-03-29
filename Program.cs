
using PetStore;
using System.Text.Json;

namespace PetStore

{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit");

            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "exit")
            {
                Console.WriteLine("Press 1 to add a product");
                Console.WriteLine("Type 'exit' to quit");

                userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Console.WriteLine("Enter product type (CatFood or DogLeash): ");
                    string productType = Console.ReadLine();

                    switch (productType.ToLower())
                    {
                        case "catfood":
                            CatFood catFood = new CatFood();
                            Console.WriteLine("Enter Name:");
                            catFood.Name = Console.ReadLine();
                            Console.WriteLine("Enter Price:");
                            catFood.Price = decimal.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Quantity:");
                            catFood.Quantity = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Description:");
                            catFood.Description = Console.ReadLine();
                            Console.WriteLine("Enter Weight (in pounds):");
                            catFood.WeightPounds = double.Parse(Console.ReadLine());
                            Console.WriteLine("Is it Kitten Food? (true/false):");
                            catFood.KittenFood = bool.Parse(Console.ReadLine());
                            Console.WriteLine(JsonSerializer.Serialize(catFood));
                            break;

                        case "dogleash":
                            DogLeash dogLeash = new DogLeash();
                            Console.WriteLine("Enter Name:");
                            dogLeash.Name = Console.ReadLine();
                            Console.WriteLine("Enter Price:");
                            dogLeash.Price = decimal.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Quantity:");
                            dogLeash.Quantity = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Description:");
                            dogLeash.Description = Console.ReadLine();
                            Console.WriteLine("Enter Length (in inches):");
                            dogLeash.LengthInches = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Material:");
                            dogLeash.Material = Console.ReadLine();
                            Console.WriteLine(JsonSerializer.Serialize(dogLeash));
                            break;

                        default:
                            Console.WriteLine("Invalid product type!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please try again.");
                }
            }
        }
    }



}
