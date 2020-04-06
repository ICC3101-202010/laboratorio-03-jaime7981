using System;
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

        private int[] productsId = new int[100];
        private int productidcouter = 0;

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
            for (int i = 0; i < productsId.Length; i++)
            {
                if (productsId[i] == id)
                {
                    this.id = 00000;
                    break;
                }
                this.id = id;
            }
            productsId[productidcouter] = id;
            productidcouter++;
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

        public string GetProductName(string name)
        {
            return name;
        }

        public int GetValue(int value)
        {
            return value;
        }

        public int GetId(int value)
        {
            return id;
        }
    }
}
