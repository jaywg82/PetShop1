using System;
using System.Text.Json;

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string Description { get; set; }
}

class CatFood : Product
{
    public double WeightPounds { get; set; }
    public bool KittenFood { get; set; }
}

class DogLeash : Product
{
    public int LengthInches { get; set; }
    public string Material { get; set; }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Press 1 to add a product");
        Console.WriteLine("Type 'exit' to quit");

        string userInput = Console.ReadLine();

        while (userInput.ToLower() != "exit")
        {
            if (userInput == "1")
            {
                Console.WriteLine("Enter product type (1 for CatFood, 2 for DogLeash):");
                int productType = int.Parse(Console.ReadLine());

                Product product = null;

                if (productType == 1)
                {
                    CatFood catFood = new CatFood();
                    product = catFood;

                    Console.Write("Enter CatFood Name: ");
                    catFood.Name = Console.ReadLine();

                    Console.Write("Enter CatFood Price: ");
                    catFood.Price = decimal.Parse(Console.ReadLine());

                    Console.Write("Enter CatFood Quantity: ");
                    catFood.Quantity = int.Parse(Console.ReadLine());

                    Console.Write("Enter CatFood Description: ");
                    catFood.Description = Console.ReadLine();

                    Console.Write("Enter CatFood Weight (in pounds): ");
                    catFood.WeightPounds = double.Parse(Console.ReadLine());

                    Console.Write("Is it Kitten Food? (true or false): ");
                    catFood.KittenFood = bool.Parse(Console.ReadLine());
                }
                else if (productType == 2)
                {
                    DogLeash dogLeash = new DogLeash();
                    product = dogLeash;

                    Console.Write("Enter DogLeash Name: ");
                    dogLeash.Name = Console.ReadLine();

                    Console.Write("Enter DogLeash Price: ");
                    dogLeash.Price = decimal.Parse(Console.ReadLine());

                    Console.Write("Enter DogLeash Quantity: ");
                    dogLeash.Quantity = int.Parse(Console.ReadLine());

                    Console.Write("Enter DogLeash Description: ");
                    dogLeash.Description = Console.ReadLine();

                    Console.Write("Enter DogLeash Length (in inches): ");
                    dogLeash.LengthInches = int.Parse(Console.ReadLine());

                    Console.Write("Enter DogLeash Material: ");
                    dogLeash.Material = Console.ReadLine();
                }

                Console.WriteLine(JsonSerializer.Serialize(product));
            }

            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit");

            userInput = Console.ReadLine();
        }
    }
}
