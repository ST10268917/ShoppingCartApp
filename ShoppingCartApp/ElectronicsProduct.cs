using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    internal class ElectronicsProduct: Product
    {
        public string Brand { get; }
        public string Model { get; }

        public ElectronicsProduct(string name, double price, string productCategory, string brand, string model) : base(name, price, productCategory)
        {
            this.Brand = brand;
            this.Model = model;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"\nBrand: {Brand}\nModel: {Model}");
        }
    }
}
