using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    internal class ShoppingCart
    {

        public Product[] Products { get; }
        public int ItemCount { get; set; }

        public ShoppingCart(int capacity)
        {
            Products = new Product[capacity];

        }

        public void AddProduct(Product product)
        {
            if (ItemCount < Products.Length)
            {
                Products[ItemCount] = product;
                ItemCount++;
            }
            else
            {
                Console.WriteLine("Shopping cart is full!");
            }
        }

        public void RemoveProduct(Product product)
        {
            for (int i = 0; i < ItemCount; i++)
            {
                if (Products[i] == product)
                {
                    // Shift remaining elements to fill the gap
                    for (int j = i; j < ItemCount - 1; j++)
                    {
                        Products[j] = Products[j + 1];
                    }
                    Products[ItemCount - 1] = null;
                    ItemCount--;
                    return;
                }
            }
            Console.WriteLine("Product not found in the shopping cart.");
        

    }
    }
}
