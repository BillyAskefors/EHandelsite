using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ehandelsite.ViewModels
{
    public class Product
    {
        public Product(string name, double price, string id, string description, string meta, int discount, int numInStock,
            string status, string stockPos, string color, double weight, string measurements, double acValue, string supSKU)
        {
            Name = name;
            Price = price;
            ID = id;
            Description = description;
            Meta = Meta;
            Discount = discount;
            NumInStock = numInStock;
            Status = status;
            StockPos = stockPos;
            Color = color;
            Weight = weight;
            Measurements = measurements;
            AcValue = acValue;
            SupSKU = supSKU;

            ProdcutList = new List<Product>();
        }

        public Product(string name) //Konstruktor som är till för att admin ska kunna lägga till en produkt som inte är klar än
        {
            Name = name;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public string ID { get; set; }
        public string Description { get; set; }
        public string Meta { get; set; }
        public int Discount { get; set; }
        public int NumInStock { get; set; }
        public string Status { get; set; }
        public string StockPos { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public string Measurements { get; set; }
        public double AcValue { get; set; }
        public string SupSKU { get; set; }
        public List<Product> ProdcutList { get; set; }
    }
}
