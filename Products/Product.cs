﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kornerchop.Products
{
    class Product
    {
        private string name;
        private string brand;

        private int value;
        private int stock;
        private int id;

        public Product()
        {

        }

        public Product(string name, string brand, int value, int stock, int id)
        {
            this.name = name;
            this.brand = brand;
            if (value >= 0 && value >= 0)
            {
                this.value = value;
                this.stock = stock;
            }
            this.id = id;
        }

        public string ProductInfo()
        {
            Console.WriteLine("\n ID: " + id + "\n Name: " + name + "\n Brand: " + brand + "\n Value: " + value + "\n Stock: " + stock);
            return "\n Name: " + name + "\n Brand: " + brand + "\n Value: " + value + "\n Stock: " + stock;
        }

        public int ChangeStock(int stock)
        {
            if (stock != 0)
            {
                stock = stock - 1;
                return stock;
            }
            return stock;
        }

        public int GetStock()
        {
            return stock;
        }

        public string GetProductName()
        {
            return name;
        }

        public int GetValue()
        {
            return value;
        }

        public int GetId()
        {
            return id;
        }
    }
}
