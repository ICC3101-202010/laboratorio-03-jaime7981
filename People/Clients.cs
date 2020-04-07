using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kornerchop.Workers
{
    class Client : Person
    {

        public List<int> shopingCart = new List<int> { };

        public Client()
        {

        }

        public Client(string firstname, string lastname, string nationality, string rut, string birthdate, string gender, int personid) 
                : base(firstname, lastname, nationality, rut, birthdate, gender, personid)
        {

        }

        public void AddToShopingCart(int id)
        {
            shopingCart.Add(id);
        }

        public void RemoveFromShopingCart(int id)
        {
            shopingCart.Remove(id);
        }

        public int ShowShopingCart()
        {
            foreach (int itemid in shopingCart)
            {
                return itemid;
            }
            return 0;
        }
    }
}
