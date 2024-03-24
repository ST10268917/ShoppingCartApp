using System.ComponentModel.Design;
using System.Numerics;

namespace ShoppingCartApp
{
    internal class Program
    {
        public enum ProductCategory
        {
            Clothing,
            Electronics,
            Home,
            Beauty,
            Groceries
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Shopping Cart App");

            ShoppingCart cart = null;
            Product chocolate = null;
            ElectronicsProduct laptop = null;
            ClothingProduct shirt = null;
            Product makeup = null;
            Product carpet = null;

            bool shouldContinue = true;
            do
            {
                Console.WriteLine("\n***********************************");
                Console.WriteLine("What would you like to do?\n1. Buy an item\n2. View cart\n3. Remove an item\n4. Exit");
                Console.WriteLine("***********************************");
                string userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    Console.WriteLine("\n***********************************");
                    Console.WriteLine("Items:\n1. Chocolate\n2. Laptop\n3. Shirt\n4. Makeup\n5. Carpet");
                    Console.WriteLine("***********************************");
                    Console.WriteLine("How many items would you like to purchase");
                    int numItems = Convert.ToInt32(Console.ReadLine());
                    cart = new ShoppingCart(numItems);

                    for (int i = 0; i < numItems; i++)
                    {
                        Console.Write("Enter the corresponding number for your item " + (i + 1) + ": ");
                        string item = Console.ReadLine();
                        if (item == "1")
                        {
                            chocolate = new Product("Chocolate", 20, ProductCategory.Groceries.ToString());
                            cart.AddProduct(chocolate);
                        }
                        else if (item == "2")
                        {
                            laptop = new ElectronicsProduct("Laptop", 900, ProductCategory.Electronics.ToString(), "Sonic", "Apple");
                            cart.AddProduct(laptop);
                        }
                        else if (item == "3")
                        {
                            shirt = new ClothingProduct("Shirt", 50, ProductCategory.Clothing.ToString(), "M", "Blue"); ;
                            cart.AddProduct(shirt);
                        }
                        else if (item == "4")
                        {
                            makeup = new Product("Makeup", 190, ProductCategory.Beauty.ToString()); ;
                            cart.AddProduct(makeup);
                        }
                        else if (item == "5")
                        {
                            carpet = new Product("Carpet", 1900, ProductCategory.Home.ToString()); ;
                            cart.AddProduct(carpet);
                        }
                    }

                }
                else if (userChoice == "2")
                {
                    int i = 1;
                    Console.WriteLine("\n***********************************");
                    Console.WriteLine("Products in the shopping cart:");
                    foreach (var product in cart.Products)
                    {
                        if (product != null)
                        {
                            Console.Write("\n" + i + ". ");
                            product.GetInfo();
                        }
                        i++;
                    }
                    Console.WriteLine("\n***********************************");

                }
                else if (userChoice == "3")
                {
                    int i = 1;
                    Console.WriteLine("***********************************");
                    Console.WriteLine("Products in the shopping cart:");
                    foreach (var product in cart.Products)
                    {
                        if (product != null)
                        {
                            Console.Write("\n" + i + ". ");
                            product.GetInfo();
                        }
                        i++;
                    }
                    Console.WriteLine("\n***********************************");

                    Console.WriteLine("Which product would you like to remove?");
                    int itemToRemove = Convert.ToInt32(Console.ReadLine());

                    for (int j =1; j<cart.Products.Length; j++)
                    {
                        if (j == itemToRemove)
                        {
                            cart.RemoveProduct(cart.Products[j-1]);
                        }
                    }


                    // Displaying products in the cart after removal
                    int k = 1;
                    Console.WriteLine("\n***********************************");
                    Console.WriteLine("\nProducts in the shopping cart after removal:");
                    foreach (var product in cart.Products)
                    {
                        if (product != null)
                        {
                            Console.Write("\n" + k + ". ");
                            product.GetInfo();
                        }
                        k++;
                        
                    }
                    Console.WriteLine("\n***********************************");

                }
                else
                {
                    shouldContinue = false;
                }


            } while (shouldContinue);
        }
    }
}
