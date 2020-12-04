using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSOLID._1_Single_resposibility_principle
{
    public class Product
    {
        public Product(int id, string description, double price, int stock)
        {
            Id = id;
            Description = description;
            Price = price;
            Stock = stock;
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }
}
