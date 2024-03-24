using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    internal class ClothingProduct : Product
    {

        public string Size { get; }
        public string Color { get; }

        public ClothingProduct(string name, double price, string productCategory, string size, string color) : base(name, price, productCategory)
        {
            this.Size = size;
            this.Color = color;
        }


        public override void GetInfo() {
            base.GetInfo();
            Console.WriteLine($"\nSize: {Size}\nColor: {Color}");
        }
    }
}
