using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kornerchop.Workers
{
    class Client : Person
    {

        private string[] ShopingCart = new string[20];

        public Client()
        {

        }

        public Client(string firstname, string lastname, string nationality, string rut, string birthdate, string gender, int personid) 
                : base(firstname, lastname, nationality, rut, birthdate, gender, personid)
        {

        }

        public void AddToShopingCart(string Productname, string brand, int stock)
        {

        }

        public void ShowShopingCart()
        {

        }
    }
}
